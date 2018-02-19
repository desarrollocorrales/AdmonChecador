
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
    public partial class frmConfiguracion : Form
    {
        #region Variables
        DescargarChecadas.Modelos.Efectos objEfectos = new DescargarChecadas.Modelos.Efectos();
        IConsultasNegocio _consultasNegocio;
        private string _path = string.Empty;
        #endregion

        #region Constructor
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        public frmConfiguracion(frmInicio inicio)
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            try
            {
                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DescChec\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                this._path = pathConfigFile + fileName;

                if (file != null)
                {
                    // si existe
                    // cargar los datos en los campos
                    FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(this._path, "milagros");

                    if (result.status == FEncrypt.Estatus.ERROR)
                        throw new Exception(result.error);

                    if (result.status == FEncrypt.Estatus.OK)
                    {
                        string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                        this.tbIP.Text = list[0].Substring(2);              // IP
                        this.tbPuerto.Text = list[1].Substring(2);          // PUERTO
                        this.tbServidor.Text = list[2].Substring(2);        // servidor
                        this.tbUsuario.Text = list[3].Substring(2);         // usuario
                        this.tbContrasenia.Text = list[4].Substring(2);     // contraseña
                        this.tbBaseDeDatos.Text = list[5].Substring(2);     // base de datos
                        this.tbNomChecador.Text = list[6].Substring(2);     // nombre del checador
                        this.cmbTipo.SelectedItem = list[7].Substring(2);   // tipo del checador
                        this.tbNumChec.Text = list[8].Substring(2);   // numero del checador
                    }
                    else tbIP.Focus();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Eventos

        private void peAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                foreach (Control x in this.groupBox1.Controls)
                {
                    if (x is TextBox)
                    {
                        if (string.IsNullOrEmpty(((TextBox)x).Text))
                            throw new Exception("Campos incompletos, Por favor verifique");
                    }
                }

                // validaciones
                foreach (Control x in this.groupBox2.Controls)
                {
                    if (x is TextBox)
                    {
                        if (string.IsNullOrEmpty(((TextBox)x).Text))
                            throw new Exception("Campos incompletos, Por favor verifique");
                    }
                }
                if (this.cmbTipo.SelectedIndex == -1)
                    throw new Exception("Seleccione el tipo de Checador");

                // define texto del archivo
                string cadena = string.Empty;

                cadena += "I_" + this.tbIP.Text + "||";
                cadena += "P_" + this.tbPuerto.Text + "||";
                cadena += "S_" + this.tbServidor.Text + "||";
                cadena += "U_" + this.tbUsuario.Text + "||";
                cadena += "C_" + this.tbContrasenia.Text + "||";
                cadena += "B_" + this.tbBaseDeDatos.Text + "||";
                cadena += "N_" + this.tbNomChecador.Text + "||";
                cadena += "T_" + this.cmbTipo.SelectedItem + "||";
                cadena += "H_" + this.tbNumChec.Text + "||";


                // prosigue con la creación del archivo
                FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.EncryptFile("milagros", cadena, this._path);

                if (result.status == FEncrypt.Estatus.ERROR)
                    throw new Exception(result.error);

                if (result.status == FEncrypt.Estatus.OK)
                {
                    DescargarChecadas.Modelos.ConectionString.conn = string.Format(
                        "server={0};User Id={1};password={2};database={3}",
                        this.tbServidor.Text,
                        this.tbUsuario.Text,
                        this.tbContrasenia.Text,
                        this.tbBaseDeDatos.Text);

                    DescargarChecadas.Modelos.ConectionString.ip = this.tbIP.Text;
                    DescargarChecadas.Modelos.ConectionString.puerto = this.tbPuerto.Text;
                    DescargarChecadas.Modelos.ConectionString.tipoCh = (string)this.cmbTipo.SelectedItem;
                    DescargarChecadas.Modelos.ConectionString.numCh = Convert.ToInt16(this.tbNumChec.Text);

                    MessageBox.Show("Se cargó correctamente la información", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peProbarC_Click(object sender, EventArgs e)
        {
            try
            {
                DescargarChecadas.Modelos.ConectionString.conn = string.Format(
                            "server={0};User Id={1};password={2};database={3}",
                            this.tbServidor.Text,
                            this.tbUsuario.Text,
                            this.tbContrasenia.Text,
                            this.tbBaseDeDatos.Text);

                _consultasNegocio = new ConsultasNegocio();

                this._consultasNegocio.pruebaConn();

                MessageBox.Show("Conexión Exitosa!!!", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peAceptar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                //DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                //switch (btn.Tag.ToString())
                //{
                //    case "conexion":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.probar1);
                //        break;
                //    case "cancel":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar1);
                //        break;
                //    case "aceptar":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.aceptar1);
                //        break;
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                //DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                //switch (btn.Tag.ToString())
                //{
                //    case "conexion":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.probar2);
                //        break;
                //    case "cancel":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar2);
                //        break;
                //    case "aceptar":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.aceptar2);

                //        break;

                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tbIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = new DescargarChecadas.Modelos.Generales().teclapresionda(e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tbPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = new DescargarChecadas.Modelos.Generales().teclaNumero(e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Metodos
        #endregion       

    }
}
