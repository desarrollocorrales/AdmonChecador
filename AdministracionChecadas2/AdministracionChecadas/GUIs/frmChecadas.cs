
using DescargarChecadas.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionChecadas.GUIs
{
    public partial class frmChecadas : Form
    {
        #region Variables
        DescargarChecadas.Modelos.Efectos objEfectos = new DescargarChecadas.Modelos.Efectos();
        DescargarChecadas.Modelos.Utilerias objUtilerias = new DescargarChecadas.Modelos.Utilerias();
        private bool _comEx = false;
        IConsultasNegocio _consultasNegocio;
        public zkemkeeper.CZKEM axCZKEM1;
        #endregion

        #region Constructor
        public frmChecadas()
        {
            InitializeComponent();
        }

        private void frmChecadas_Load(object sender, EventArgs e)
        {
            try
            {
                // valida si ya tiene alguna clave guardada para el archivo
                string cveActual = Properties.Settings.Default.accesoConfig;

                if (string.IsNullOrEmpty(cveActual))
                {
                    string acceso = objUtilerias.Transform("p4ssw0rd");

                    Properties.Settings.Default.accesoConfig = acceso;
                    Properties.Settings.Default.Save();
                }

                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DescChec\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                if (file == null)
                {
                    // no existe
                    // abrir el formulario para llenar la configuracion de conexion 
                    frmConfiguracion form = new frmConfiguracion();
                    form.ShowDialog();
                }
                else
                {
                    // si existe
                    // obtener la cadena de conexion del archivo
                    FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(file, "milagros");

                    if (result.status == FEncrypt.Estatus.ERROR)
                        throw new Exception(result.error);

                    if (result.status == FEncrypt.Estatus.OK)
                    {
                        string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                        string ip = list[0].Substring(2);           // ip
                        string puerto = list[1].Substring(2);       // puerto
                        string servidor = list[2].Substring(2);     // servidor
                        string usuario = list[3].Substring(2);      // usuario
                        string contra = list[4].Substring(2);       // contraseña
                        string baseDatos = list[5].Substring(2);    // base de datos
                        string nomChecador = list[6].Substring(2);  // nombre checador
                        string tipoChecador = list[7].Substring(2); // tipo de checador
                        string numChecador = list[8].Substring(2); // num de checador

                        // si licencia pasa asigna cadena de conexion
                        DescargarChecadas.Modelos.ConectionString.conn = string.Format(
                            "server={0};User Id={1};password={2};database={3}",
                            servidor, usuario, contra, baseDatos);

                        DescargarChecadas.Modelos.ConectionString.ip = ip;
                        DescargarChecadas.Modelos.ConectionString.puerto = puerto;
                        DescargarChecadas.Modelos.ConectionString.tipoCh = tipoChecador;
                        DescargarChecadas.Modelos.ConectionString.numCh = Convert.ToInt16(numChecador);

                        this.lbChecador.Text = "Checador: " + nomChecador + " - " + tipoChecador;

                        this.lbChecador.Left = (this.ClientSize.Width - this.lbChecador.Width) / 2;
                    }
                }

                // inicializa librerias SDK checador
                //axCZKEM1 = new zkemkeeper.CZKEM();

            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                // MessageBox.Show(cex.Message, "Descarga Checadores COMEx", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Problemas con la conexion al Checador\nRevise si las librerías están correctamente instaladas.",
                    "Descarga Checadores COMEx", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this._comEx = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Descarga Checadores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Eventos

        private void peAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                #region Validacion
                if (this._comEx)
                    throw new Exception("Problemas con la conexión al checador");

                if (!string.IsNullOrEmpty(this.tbResultados.Text)) { this.tbResultados.Clear(); this.tbResultados.Refresh(); }

                if (string.IsNullOrEmpty(DescargarChecadas.Modelos.ConectionString.ip) ||
                    string.IsNullOrEmpty(DescargarChecadas.Modelos.ConectionString.puerto))
                    throw new Exception("No se han definido los parámetros de conexión del Checador, ir a modulo de Configuración.");

                if (string.IsNullOrEmpty(DescargarChecadas.Modelos.ConectionString.conn))
                    throw new Exception("No se ha definido la cadena de conexión a la base de datos, ir a modulo de Configuración.");
                #endregion
                objEfectos.MouseLeaveEfectoPE(peAceptar, AdministracionChecadas.Properties.Resources.Dchecadas2);

                string ip = DescargarChecadas.Modelos.ConectionString.ip;
                int puerto = Convert.ToInt32(DescargarChecadas.Modelos.ConectionString.puerto);
                string tipoCh = DescargarChecadas.Modelos.ConectionString.tipoCh;
                int numCh = DescargarChecadas.Modelos.ConectionString.numCh;
                Cursor = Cursors.WaitCursor;

                // inicializa clase de conexion a la base de datos
                this._consultasNegocio = new ConsultasNegocio();
                // conectando con la base de datos
                new DescargarChecadas.Modelos.Utilerias().agregarDetalle("Conectando con la base de datos", tbResultados);
                bool conectaBd = this._consultasNegocio.conectaBase();

                if (conectaBd)
                    new DescargarChecadas.Modelos.Utilerias().agregarDetalle("Conexión Exitosa!!!", tbResultados);
                else
                    throw new Exception("Problemas al conectar con la base de datos");

                // obtener la ultima checada
                new DescargarChecadas.Modelos.Utilerias().agregarDetalle("Obteniendo la última fecha de registro", tbResultados);
                DateTime ultFecha = this._consultasNegocio.obtUltimaFecha(numCh);
                new DescargarChecadas.Modelos.Utilerias().agregarDetalle("Fecha: " + ultFecha.ToString("yyyy-MM-dd HH:mm"), tbResultados);

                new DescargarChecadas.Modelos.Utilerias().agregarDetalle("Tipo de Checador Seleccionado '" + tipoCh + "'", tbResultados);

                DescargarChecadas.Modelos.Response respuesta = new DescargarChecadas.Modelos.Response();

                switch (tipoCh)
                {
                    case "TFT":
                        zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
                        respuesta = checadasTFT(ip, puerto, ultFecha, 0, false, axCZKEM1);
                        new DescargarChecadas.Modelos.Checador().Desconectar(tbResultados, true, axCZKEM1);
                        //checadasTFT(ip, puerto, ultFecha, 0, true, axCZKEM1);
                        new DescargarChecadas.Modelos.Utilerias().agregarDetalle("*Proceso de Descarga Concluido", tbResultados);
                        Cursor = Cursors.Default;
                        objEfectos.MouseLeaveEfectoPE(peAceptar, AdministracionChecadas.Properties.Resources.Dchecadas1);
                        break;
                    case "BlackWhite":

                        //respuesta = this.checadasBW(ip, puerto, ultFecha);

                        break;
                    default:

                        break;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void peMinimiza_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region Metodos
        // conexion y checadas TFT
        private DescargarChecadas.Modelos.Response checadasTFT(string ip, int puerto, DateTime ultFecha, int txtCommKey1, bool conectar, zkemkeeper.CZKEMClass axCZKEM1)
        {
            DescargarChecadas.Modelos.Response result = new DescargarChecadas.Modelos.Response();
            try
            {
                Cursor = Cursors.WaitCursor;
                // estableciendo conexion con el checador
                new DescargarChecadas.Modelos.Utilerias().agregarDetalle("Estableciendo conexión con el checador", tbResultados);
                result.status = new DescargarChecadas.Modelos.Checador().Conectar(tbResultados, ip, puerto, txtCommKey1, conectar, axCZKEM1);

                if (result.status == DescargarChecadas.Modelos.Estatus.ERROR)
                    throw new Exception(result.error);

                new DescargarChecadas.Modelos.Utilerias().agregarDetalle("Conexión Exitosa!!!", tbResultados);

                // inicializa clase de conexion a la base de datos
                this._consultasNegocio = new ConsultasNegocio();

                // obtiene checadas
                new DescargarChecadas.Modelos.Utilerias().agregarDetalle("Obteniendo los registros del checador", tbResultados);
                List<DescargarChecadas.Modelos.AttLogs> resultado = new DescargarChecadas.Modelos.Checador().ObtenerChecadas(tbResultados, axCZKEM1);

                List<DescargarChecadas.Modelos.AttLogs> traspaso = resultado.FindAll(fl => fl.fecha >= ultFecha);
                DescargarChecadas.Modelos.AttLogs ent;

                foreach (DescargarChecadas.Modelos.AttLogs res in traspaso)
                {
                    try
                    {
                        ent = new DescargarChecadas.Modelos.AttLogs();
                        ent.enrolIdNumber = res.enrolIdNumber;
                        ent.fecha = res.fecha;
                        ent.noChecador = DescargarChecadas.Modelos.ConectionString.numCh;

                        // ingresa un usuario como pendiente en caso de no tenerlo registrado
                        this._consultasNegocio.insertaNuevo(res.enrolIdNumber);

                        // inserta los registros a la base de datos
                        this._consultasNegocio.insertaRegistro(ent);

                        // imprime mensajes en pantalla
                        objUtilerias.agregarDetalle("Registro Agregado: IdInterno: " + res.enrolIdNumber + "\tFecha: " + res.fecha.ToString("yyyy-MM-dd HH:mm"), tbResultados);
                    }
                    catch (Exception EX)
                    {
                        if (EX.Message.ToLower().Contains("duplicate entry"))
                        {
                            objUtilerias.agregarDetalle(string.Format("El registro con IdInteno: {0} y FechaHora: {1} ya existe.", res.enrolIdNumber, res.fecha.ToString("yyyy-MM-dd HH:mm")), tbResultados);
                            Application.DoEvents();
                            continue;
                        }

                        throw new Exception(EX.Message);
                    }
                }               

                result.status = DescargarChecadas.Modelos.Estatus.OK;
                Cursor = Cursors.Default;
            }
            catch (Exception Ex)
            {
                Cursor = Cursors.Default;
                result.error = Ex.Message;
                result.status = DescargarChecadas.Modelos.Estatus.ERROR;
            }

            return result;
        }

        #endregion

    }
}
