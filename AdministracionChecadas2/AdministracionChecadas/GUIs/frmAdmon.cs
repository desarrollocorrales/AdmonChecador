
using DescargarChecadas.Modelos;
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
    public partial class frmAdmon : Form
    {
        #region Variables
        SiNoDialog frmSiNo;
        Efectos objEfectos = new Efectos(); Checador objChecador = new Checador(); Utilerias objUtilerias = new Utilerias();
        string btnTag = string.Empty; string ip = string.Empty; string puerto = string.Empty; string servidor = string.Empty; string usuario = string.Empty; string contra = string.Empty; string baseDatos = string.Empty; string nomChecador = string.Empty; string tipoChecador = string.Empty; string numChecador = string.Empty;
        private static int iMachineNumber = 1; private static int idwErrorCode = 0; 
        zkemkeeper.CZKEMClass axCZKEM1;
        #endregion

        #region Constructor
        public frmAdmon()
        {
            InitializeComponent();
        }

        private void frmAdmon_Load(object sender, EventArgs e)
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

                        ip = list[0].Substring(2);           // ip
                        puerto = list[1].Substring(2);       // puerto
                        servidor = list[2].Substring(2);     // servidor
                        usuario = list[3].Substring(2);      // usuario
                        contra = list[4].Substring(2);       // contraseña
                        baseDatos = list[5].Substring(2);    // base de datos
                        nomChecador = list[6].Substring(2);  // nombre checador
                        tipoChecador = list[7].Substring(2); // tipo de checador
                        numChecador = list[8].Substring(2); // num de checador

                        // si licencia pasa asigna cadena de conexion
                        DescargarChecadas.Modelos.ConectionString.conn = string.Format(
                            "server={0};User Id={1};password={2};database={3}",
                            servidor, usuario, contra, baseDatos);

                        DescargarChecadas.Modelos.ConectionString.ip = ip;
                        DescargarChecadas.Modelos.ConectionString.puerto = puerto;
                        DescargarChecadas.Modelos.ConectionString.tipoCh = tipoChecador;
                        DescargarChecadas.Modelos.ConectionString.numCh = Convert.ToInt16(numChecador);

                        axCZKEM1 = new zkemkeeper.CZKEMClass();
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
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Descarga Checadores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Eventos

        //Tiempo
        private void peSyncTime_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                btnTag = btn.Tag.ToString();
                ecpMenu_ExpandCollapse(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void peSync_Click(object sender, EventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfectoPE(peGTime, AdministracionChecadas.Properties.Resources.getTime1);
                objEfectos.MouseLeaveEfectoPE(peSetTime, AdministracionChecadas.Properties.Resources.SetTime1);
                objEfectos.MouseLeaveEfectoPE(peSync, AdministracionChecadas.Properties.Resources.sync2);

                new Generales().limpiaControles(pnSyncTime);
                Cursor = Cursors.WaitCursor;
                //axCZKEM1 = new zkemkeeper.CZKEMClass();
                SyncTiempo(lbSyncTime, axCZKEM1);
                objChecador.Desconectar(textBox1, true, axCZKEM1);
                Cursor = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peGTime_Click(object sender, EventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfectoPE(peGTime, AdministracionChecadas.Properties.Resources.getTime2);
                objEfectos.MouseLeaveEfectoPE(peSetTime, AdministracionChecadas.Properties.Resources.SetTime1);
                objEfectos.MouseLeaveEfectoPE(peSync, AdministracionChecadas.Properties.Resources.sync1);

                new Generales().limpiaControles(pnSyncTime);
                Cursor = Cursors.WaitCursor;
                //axCZKEM1 = new zkemkeeper.CZKEMClass();
                ObtenerTiempo(lblGetTime, axCZKEM1);
                objChecador.Desconectar(textBox1, true, axCZKEM1);
                Cursor = Cursors.Default;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peSetTime_Click(object sender, EventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfectoPE(peGTime, AdministracionChecadas.Properties.Resources.getTime1);
                objEfectos.MouseLeaveEfectoPE(peSetTime, AdministracionChecadas.Properties.Resources.SetTime2);
                objEfectos.MouseLeaveEfectoPE(peSync, AdministracionChecadas.Properties.Resources.sync1);

                new Generales().limpiaControles(pnSyncTime);
                Cursor = Cursors.WaitCursor;
                //axCZKEM1 = new zkemkeeper.CZKEMClass();
                new DescargarChecadas.Modelos.Checador().Conectar(textBox1, ip, int.Parse(puerto), 0, false, axCZKEM1);
                EstablecerHora(lblSetTime, dtpTiempo);
                objChecador.Desconectar(textBox1, true, axCZKEM1);
                Cursor = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //***

        private void peDeleteLog_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "Se eliminaran los registros del checador " + nomChecador;
                frmSiNo = new SiNoDialog(mensaje);
                frmSiNo.FormClosed += new FormClosedEventHandler(ConfirmaE);
                frmSiNo.ShowDialog();                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }			
        }

        private void peRestart_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                btnTag = btn.Tag.ToString();
                ecpMenu_ExpandCollapse(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peUser_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                btnTag = btn.Tag.ToString();
                ecpMenu_ExpandCollapse(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ecpMenu_ExpandCollapse(object sender, MakarovDev.ExpandCollapsePanel.ExpandCollapseEventArgs e)
        {
            try
            {
                if (ecpMenu.IsExpanded)
                {
                    switch (btnTag)
                    {
                        case "time":
                            pnSyncTime.Visible = pnContenedor.Visible = true;
                            ecpMenu.IsExpanded = pnReinicio.Visible = pnUser.Visible = pnDatos.Visible = false;
                            break;
                        case "reinicio":
                            pnReinicio.Visible = pnContenedor.Visible = true;
                            ecpMenu.IsExpanded = pnSyncTime.Visible = pnUser.Visible = pnDatos.Visible = false;
                            break;
                        case "user":
                            pnUser.Visible = pnDatos.Visible = pnContenedor.Visible = true;
                            ecpMenu.IsExpanded = pnSyncTime.Visible = pnReinicio.Visible =  false;
                            lblContrasenia.Text = "Contraseña"; lblID.Text = "ID"; lblNombre.Text = "Nombre"; lblPrivilegio.Text = "Privilegio";
                            break;
                    }
                }
                else
                {
                    switch (btnTag)
                    {
                        case "inicio":
                            new Generales().limpiaControles(pnReinicio);
                            new Generales().limpiaControles(pnSyncTime);
                            new Generales().limpiaControles(pnUser);
                            new Generales().limpiaControles(pnDatos);
                            pnContenedor.Visible = false;
                            ecpMenu.IsExpanded = true;
                            break;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void peCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfectoPE(peGTime, AdministracionChecadas.Properties.Resources.getTime1);
                objEfectos.MouseLeaveEfectoPE(peSetTime, AdministracionChecadas.Properties.Resources.SetTime1);
                objEfectos.MouseLeaveEfectoPE(peSync, AdministracionChecadas.Properties.Resources.sync1);
                objEfectos.MouseLeaveEfectoPE(peGetUser, AdministracionChecadas.Properties.Resources.GetUser1);
                objEfectos.MouseLeaveEfectoPE(peSetUser, AdministracionChecadas.Properties.Resources.setuser1);

                DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                btnTag = btn.Tag.ToString();
                pnDatos.Visible = pnAGU.Visible = pnbASU.Visible = false;                
                ecpMenu_ExpandCollapse(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        private void peAceptarSet_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (txtUserID.Text.Trim() == "" || cbPrivilege.Text.Trim() == "")
                {
                    MessageBox.Show("*NO has capturado un ID de usuario o el privilegio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                 
                //axCZKEM1 = new zkemkeeper.CZKEMClass();
                new DescargarChecadas.Modelos.Checador().Conectar(textBox1, ip, int.Parse(puerto), 0, false, axCZKEM1);
                string res = AgregaUsuario(axCZKEM1, txtUserID, txtName, cbPrivilege, txtPassword);
                objChecador.Desconectar(textBox1, true, axCZKEM1);
                MessageBox.Show(res, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Generales().limpiaControles(pnDatos);
                pnDatos.Visible = pnbASU.Visible= false;
                Cursor = Cursors.Default;
                objEfectos.MouseLeaveEfectoPE(peSetUser, AdministracionChecadas.Properties.Resources.setuser1);
                objEfectos.MouseLeaveEfectoPE(peGetUser, AdministracionChecadas.Properties.Resources.GetUser1);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peAceptarGet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text.Trim() == "")
                {
                    MessageBox.Show("*Ingrese el ID de usuario");
                    return;
                }

                Cursor = Cursors.WaitCursor;
                new DescargarChecadas.Modelos.Checador().Conectar(textBox1, ip, int.Parse(puerto), 0, false, axCZKEM1);


                int iPIN2Width = 0;
                string strTemp = "";
                axCZKEM1.GetSysOption(new Checador().GetMachineNumber(), "~PIN2Width", out strTemp);
                iPIN2Width = Convert.ToInt32(strTemp);

                if (txtUserID.Text.Length > iPIN2Width)
                {
                    MessageBox.Show("*ID error! La longitud debe ser de: " + iPIN2Width.ToString());
                    return;
                }

                int idwErrorCode = 0;
                int iPrivilege = 0;
                string strName = "";
                string strCardno = "";
                string strPassword = "";
                bool bEnabled = false;

                axCZKEM1.EnableDevice(iMachineNumber, false);
                if (axCZKEM1.SSR_GetUserInfo(iMachineNumber, txtUserID.Text.Trim(), out strName, out strPassword, out iPrivilege, out bEnabled))//upload the user's information(card number included)
                {
                    axCZKEM1.GetStrCardNumber(out strCardno);
                    if (strCardno.Equals("0"))
                    {
                        strCardno = "";
                    }
                    txtName.Text = strName;
                    txtPassword.Text = strPassword;
                    txtCardnumber.Text = strCardno;
                    cbPrivilege.SelectedIndex = iPrivilege;
                    //lblOutputInfo.Items.Add("Get user information successfully");
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    //modify by Leonard 2017/12/18
                    txtName.Text = " ";
                    txtPassword.Text = " ";
                    txtCardnumber.Text = " ";
                    cbPrivilege.SelectedIndex = 5;
                    MessageBox.Show("El usuario no existe");
                }

                axCZKEM1.EnableDevice(iMachineNumber, true);
                objChecador.Desconectar(textBox1, true, axCZKEM1);

                new Generales().limpiaControles(pnDatos);
                pnDatos.Visible = pnAGU.Visible = false;
                Cursor = Cursors.Default;
                objEfectos.MouseLeaveEfectoPE(peSetUser, AdministracionChecadas.Properties.Resources.setuser1);
                objEfectos.MouseLeaveEfectoPE(peGetUser, AdministracionChecadas.Properties.Resources.GetUser1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peReiniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "Se reiniciara el checador " + nomChecador;
                frmSiNo = new SiNoDialog(mensaje);
                frmSiNo.FormClosed += new FormClosedEventHandler(ConfirmaR);
                frmSiNo.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }	
        }

        private void peOff_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "Se apagara el " + nomChecador;
                frmSiNo = new SiNoDialog(mensaje);
                frmSiNo.FormClosed += new FormClosedEventHandler(ConfirmaA);
                frmSiNo.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peBorrarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "Se Borraran todos los datos del " + nomChecador + ". Registros de Checadas, huellas, etc.";
                frmSiNo = new SiNoDialog(mensaje);
                frmSiNo.FormClosed += new FormClosedEventHandler(ConfirmaCA);
                frmSiNo.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peSetUser_Click(object sender, EventArgs e)
        {
            try
            {
                //objEfectos.MouseLeaveEfectoPE(peSetUser, AdministracionChecadas.Properties.Resources.setuser2);
                //objEfectos.MouseLeaveEfectoPE(peGetUser, AdministracionChecadas.Properties.Resources.GetUser1);
                //pnAGU.Visible = false;
                //pnbASU.Visible = true;
                Cursor = Cursors.WaitCursor;
                if (txtUserID.Text.Trim() == "" || cbPrivilege.Text.Trim() == "")
                {
                    MessageBox.Show("*NO has capturado un ID de usuario o el privilegio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //axCZKEM1 = new zkemkeeper.CZKEMClass();
                new DescargarChecadas.Modelos.Checador().Conectar(textBox1, ip, int.Parse(puerto), 0, false, axCZKEM1);
                string res = AgregaUsuario(axCZKEM1, txtUserID, txtName, cbPrivilege, txtPassword);
                objChecador.Desconectar(textBox1, true, axCZKEM1);
                MessageBox.Show(res, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Generales().limpiaControles(pnDatos);
                lblID.Text = "ID"; lblContrasenia.Text = "Contraseña"; lblNombre.Text = "Nombre"; lblPrivilegio.Text = "Privilegio";
                Cursor = Cursors.Default;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peGetUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text.Trim() == "")
                {
                    MessageBox.Show("*Ingrese el ID de usuario");
                    return;
                }

                Cursor = Cursors.WaitCursor;
                new DescargarChecadas.Modelos.Checador().Conectar(textBox1, ip, int.Parse(puerto), 0, false, axCZKEM1);


                int iPIN2Width = 0;
                string strTemp = "";
                axCZKEM1.GetSysOption(new Checador().GetMachineNumber(), "~PIN2Width", out strTemp);
                iPIN2Width = Convert.ToInt32(strTemp);

                if (txtUserID.Text.Length > iPIN2Width)
                {
                    MessageBox.Show("*ID error! La longitud debe ser de: " + iPIN2Width.ToString());
                    return;
                }

                int idwErrorCode = 0;
                int iPrivilege = 0;
                string strName = "";
                string strCardno = "";
                string strPassword = "";
                bool bEnabled = false;

                axCZKEM1.EnableDevice(iMachineNumber, false);
                if (axCZKEM1.SSR_GetUserInfo(iMachineNumber, txtUserID.Text.Trim(), out strName, out strPassword, out iPrivilege, out bEnabled))//upload the user's information(card number included)
                {
                    axCZKEM1.GetStrCardNumber(out strCardno);
                    if (strCardno.Equals("0"))
                    {
                        strCardno = "";
                    }
                    txtName.Text = strName;
                    txtPassword.Text = strPassword;
                    txtCardnumber.Text = strCardno;
                    cbPrivilege.SelectedIndex = iPrivilege;
                    //lblOutputInfo.Items.Add("Get user information successfully");
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    //modify by Leonard 2017/12/18
                    txtName.Text = " ";
                    txtPassword.Text = " ";
                    txtCardnumber.Text = " ";
                    cbPrivilege.SelectedIndex = 5;
                    MessageBox.Show("El usuario no existe");
                }

                axCZKEM1.EnableDevice(iMachineNumber, true);
                objChecador.Desconectar(textBox1, true, axCZKEM1);

                Cursor = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void peOcultaMenu_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = new DescargarChecadas.Modelos.Generales().teclaNumero(e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #region No usados
        private void peSyncTime_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                //DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                //switch (btn.Tag.ToString())
                //{
                //    case "time":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.tiempo1);
                //        break;
                //    case "borra":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.checadas1);
                //        break;
                //    case "reinicio":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.reinicio1);
                //        break;
                //    case "sync":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.sync1);
                //        break;
                //    case "GetTime":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.getTime1);
                //        break;
                //    case "SetTime":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.SetTime1);
                //        break;
                //    case "reinicia":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Reinicio11);
                //        break;
                //    case "off":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.apagar1);
                //        break;
                //    case "minimiza":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.minimizar1);
                //        break;
                //    case "cancel":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar1);
                //        break;
                //    case "inicio":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar1);
                //        break;
                //    case "user":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.user1);
                //        break;
                //    case "clear":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.btodo1);
                //        break;
                //    case "setuser":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.setuser1);
                //        break;
                //    case "getuser":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.GetUser1);
                //        break;
                //    case "acepta":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.aceptar1);
                //        break;
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void peSyncTime_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                //DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                //switch (btn.Tag.ToString())
                //{
                //    case "time":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.tiempo2);
                //        break;
                //    case "borra":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.checadas2);
                //        break;
                //    case "reinicio":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.reinicio2);
                //        break;
                //    case "sync":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.sync2);
                //        break;
                //    case "GetTime":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.getTime2);
                //        break;
                //    case "SetTime":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.SetTime2);
                //        break;
                //    case "reinicia":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.reinicio22);
                //        break;
                //    case "off":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.apagar2);
                //        break;
                //    case "minimiza":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.minimizar2);
                //        break;
                //    case "cancel":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar2);
                //        break;
                //    case "inicio":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar2);
                //        break;
                //    case "user":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.user2);
                //        break; 
                //    case "clear":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.btodo2);
                //        break;
                //    case "setuser":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.setuser2);
                //        break;
                //    case "getuser":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.GetUser2);
                //        break;
                //    case "acepta":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.aceptar2);
                //        break;
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #endregion

        #region Metodos
        //Obtiene el tiempo actual en el Checador
        public Response ObtenerTiempo(Label lbDeviceTime, zkemkeeper.CZKEMClass axCZKEM1)
        {

            Response result = new Response();
            int idwYear = 0;
            int idwMonth = 0;
            int idwDay = 0;
            int idwHour = 0;
            int idwMinute = 0;
            int idwSecond = 0;

            result.status = new DescargarChecadas.Modelos.Checador().Conectar(textBox1, ip, int.Parse(puerto), 0, false, axCZKEM1);

            if (axCZKEM1.GetDeviceTime(iMachineNumber, ref idwYear, ref idwMonth, ref idwDay, ref idwHour, ref idwMinute, ref idwSecond))//show the time
            {
                lbDeviceTime.Text = idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString();
                //lblOutputInfo.Items.Add("Get device time successfully");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                lbDeviceTime.Text = "*Operation failed,ErrorCode=" + idwErrorCode.ToString();
            }

            return result;
        }

        //Sincroniza el tiempo del dispositivo como el de la computadora.
        public int SyncTiempo(Label lbDeviceTime, zkemkeeper.CZKEMClass axCZKEM1)
        {
            new DescargarChecadas.Modelos.Checador().Conectar(textBox1, ip, int.Parse(puerto), 0, false, axCZKEM1);

            if (axCZKEM1.SetDeviceTime(iMachineNumber))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                ObtenerTiempo(lbDeviceTime, axCZKEM1);
                lbDeviceTime.Text = "Se sincronizo correctamente el tiempo del checador con el Servidor, " + lbDeviceTime.Text;
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                lbDeviceTime.Text = "*Operation failed,ErrorCode=" + idwErrorCode.ToString();
            }

            return 1;
        }

        public string AgregaUsuario(zkemkeeper.CZKEMClass axCZKEM1, TextBox txtUserID, TextBox txtName, ComboBox cbPrivilege, TextBox txtPassword)
        {
            Checador objChecador = new Checador();
            int iPrivilege = cbPrivilege.SelectedIndex;
            bool bFlag = false;
            string msj = string.Empty;

            int iPIN2Width = 0; int iIsABCPinEnable = 0; int iT9FunOn = 0;
            string strTemp = "";
            axCZKEM1.GetSysOption(objChecador.GetMachineNumber(), "~PIN2Width", out strTemp);
            iPIN2Width = Convert.ToInt32(strTemp);
            axCZKEM1.GetSysOption(objChecador.GetMachineNumber(), "~IsABCPinEnable", out strTemp);
            iIsABCPinEnable = Convert.ToInt32(strTemp);
            axCZKEM1.GetSysOption(objChecador.GetMachineNumber(), "~T9FunOn", out strTemp);
            iT9FunOn = Convert.ToInt32(strTemp);

            if (txtUserID.Text.Length > iPIN2Width)
            {
                msj = "*El ID usuario no puede ser mas grande de: " + iPIN2Width.ToString();
                return msj;
            }

            if (iIsABCPinEnable == 0 || iT9FunOn == 0)
            {
                if (txtUserID.Text.Substring(0, 1) == "0")
                {
                    msj = "*El ID usuario no puede comenzar con 0";
                    return msj;
                }
            }

            int idwErrorCode = 0;
            string sdwEnrollNumber = txtUserID.Text.Trim();
            string sName = txtName.Text.Trim();
            string sCardnumber = txtCardnumber.Text.Trim();
            string sPassword = txtPassword.Text.Trim();

            bool bEnabled = true;
            
            axCZKEM1.EnableDevice(iMachineNumber, false);
            axCZKEM1.SetStrCardNumber(sCardnumber);//Before you using function SetUserInfo,set the card number to make sure you can upload it to the device
            if (axCZKEM1.SSR_SetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled))
            {
                msj = "Se Agrego el usuario: " + sdwEnrollNumber + "-" + sName;
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                msj = "*OPeracion Fallida, Codigo de Error=" + idwErrorCode.ToString();
            }
            axCZKEM1.RefreshData(iMachineNumber);
            axCZKEM1.EnableDevice(iMachineNumber, true);

            return msj;
        }

        //establece la Hora colocada
        public int EstablecerHora(Label lblOutputInfo, DateTimePicker dtDeviceTime)
        {

            DateTime date = DateTime.Parse(dtDeviceTime.Text);
            int idwYear = Convert.ToInt32(date.Year.ToString());
            int idwMonth = Convert.ToInt32(date.Month.ToString());
            int idwDay = Convert.ToInt32(date.Day.ToString());
            int idwHour = Convert.ToInt32(date.Hour.ToString());
            int idwMinute = Convert.ToInt32(date.Minute.ToString());
            int idwSecond = Convert.ToInt32(date.Second.ToString());

            if (axCZKEM1.SetDeviceTime2(iMachineNumber, idwYear, idwMonth, idwDay, idwHour, idwMinute, idwSecond))
            {
                axCZKEM1.RefreshData(iMachineNumber);
                lblOutputInfo.Text = "Se establecio con éxito la hora";
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                lblOutputInfo.Text = "*Operation failed,ErrorCode=" + idwErrorCode.ToString();
            }

            return 1;
        }

        //Reinicio del checador y de la aplicacion
        public int ResetChecador(zkemkeeper.CZKEMClass axCZKEM1)
        {
            if (axCZKEM1.RestartDevice(iMachineNumber))
                axCZKEM1.Disconnect();
            else
                axCZKEM1.GetLastError(ref idwErrorCode);
            return 1;
        }

        //Eliminacion de Checadas en el dispositivo
        public string BorrarChecadas(zkemkeeper.CZKEMClass axCZKEM1)
        {
            string msjR = string.Empty;

            axCZKEM1.EnableDevice(objChecador.GetMachineNumber(), false);//disable the device


            if (axCZKEM1.ClearGLog(objChecador.GetMachineNumber()))
            {
                axCZKEM1.RefreshData(objChecador.GetMachineNumber());
                msjR = "Se Eliminaron correctamente los registros del checador " + nomChecador;
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                int ret = idwErrorCode;

                if (idwErrorCode != 0)
                    msjR = "**No se pudieron eliminar los registros, Codigo de error: " + idwErrorCode.ToString();
                else
                    msjR = "El checador no contiene datos!!!";
            }

            axCZKEM1.EnableDevice(objChecador.GetMachineNumber(), true);//enable the device

            return msjR;
        }

        //Apagar dispositivo
        public int ApagarChecador(zkemkeeper.CZKEMClass axCZKEM1)
        {
            if (axCZKEM1.PowerOffDevice(iMachineNumber))
                axCZKEM1.Disconnect();

            return 1;
        }

        //Borrar Todos los datos del checador
        public string EliminarTodo(zkemkeeper.CZKEMClass axCZKEM1)
        {
            string ret = string.Empty;

            axCZKEM1.EnableDevice(objChecador.GetMachineNumber(), false);

            if (axCZKEM1.ClearKeeperData(objChecador.GetMachineNumber()))
            {
                axCZKEM1.RefreshData(objChecador.GetMachineNumber());//the data in the device should be refreshed
                ret = "Se han Eliminado todos los datos del dispositivo";
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                if (idwErrorCode != 0)
                    ret = "*Falla en borrar todo, Codigo de error=" + idwErrorCode.ToString();
                else
                    ret ="No se encontraron datos en la terminal";
            }

            axCZKEM1.EnableDevice(objChecador.GetMachineNumber(), true);
            return ret;
        }

        private void ConfirmaE(object sender, EventArgs e)
        {
            try
            {
                if (frmSiNo.DialogResult.ToString() == "OK")
                {
                    Cursor = Cursors.WaitCursor;
                    axCZKEM1 = new zkemkeeper.CZKEMClass();
                    new DescargarChecadas.Modelos.Checador().Conectar(textBox1, ip, int.Parse(puerto), 0, false, axCZKEM1);
                    BorrarChecadas(axCZKEM1);
                    objChecador.Desconectar(textBox1, true, axCZKEM1);
                    Cursor = Cursors.Default;                 
                }
            }
            catch(Exception ex)
            { throw ex;  }
        }

        private void ConfirmaR(object sender, EventArgs e)
        {
            try
            {
                if (frmSiNo.DialogResult.ToString() == "OK")
                {
                    Cursor = Cursors.WaitCursor;
                    axCZKEM1 = new zkemkeeper.CZKEMClass();
                    new DescargarChecadas.Modelos.Checador().Conectar(textBox1, ip, int.Parse(puerto), 0, false, axCZKEM1);
                    ResetChecador(axCZKEM1);
                    this.Close(); //to turn off current app
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void ConfirmaA(object sender, EventArgs e)
        {
            try
            {
                if (frmSiNo.DialogResult.ToString() == "OK")
                {
                    Cursor = Cursors.WaitCursor;
                    axCZKEM1 = new zkemkeeper.CZKEMClass();
                    new DescargarChecadas.Modelos.Checador().Conectar(textBox1, ip, int.Parse(puerto), 0, false, axCZKEM1);
                    ApagarChecador(axCZKEM1);
                    this.Close(); //to turn off current app
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void ConfirmaCA(object sender, EventArgs e)
        {
            try
            {
                if (frmSiNo.DialogResult.ToString() == "OK")
                {
                    Cursor = Cursors.WaitCursor;
                    axCZKEM1 = new zkemkeeper.CZKEMClass();
                    new DescargarChecadas.Modelos.Checador().Conectar(textBox1, ip, int.Parse(puerto), 0, false, axCZKEM1);
                    string mensaje = EliminarTodo(axCZKEM1);
                    MessageBox.Show(mensaje, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void cambiaImagen(DevExpress.XtraEditors.PictureEdit btn)
        {
            try
            {
                switch (btn.Tag.ToString())
                {
                    case "configura":
                        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Configuracion1);
                        break;
                    case "descarga":
                        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.descarga1);
                        break;
                    case "admin":
                        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.admin1);
                        break;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RegresaImagen(DevExpress.XtraEditors.PictureEdit btn)
        {
            try
            {
                switch (btn.Tag.ToString())
                {
                    case "configura":
                        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Configuracion2);
                        break;
                    case "descarga":
                        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.descarga2);
                        break;
                    case "admin":
                        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.admin2);
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        #endregion
    }
}
