
using DescargarChecadas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionChecadas.GUIs
{
    public partial class frmAcceso : Form
    {
        #region Variables
        Efectos objEfectos = new Efectos();
        Utilerias objUtilerias = new Utilerias();
        string form = string.Empty;
        #endregion

        #region Constructor
        public frmAcceso()
        {
            InitializeComponent();
        }

        public frmAcceso(string formulario)
        {
            InitializeComponent();
            form = formulario;
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(309, 220);
                this.ActiveControl = this.tbAccess;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Eventos
        private void peAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbAccess.Text))
                    throw new Exception("Ingrese la clave de acceso");

                string claveAcceso = objUtilerias.Transform(this.tbAccess.Text);

                string acceso = string.Empty;
                if(form == "config")
                    acceso = Properties.Settings.Default.accesoConfig;
                else acceso = Properties.Settings.Default.accesoAdmon;

                if (objUtilerias.Transform(acceso).Equals(objUtilerias.Transform(claveAcceso)))
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                else
                {
                    this.ActiveControl = this.tbAccess;
                    this.tbAccess.SelectAll();
                    throw new Exception("Clave incorrecta");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void peCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peCancelarNC_Click(object sender, EventArgs e)
        {
            try
            {
                // regresa el tamaño del formulario
                this.Size = new Size(309, 220);

                // habilita el acceso
                this.label1.Enabled = this.tbAccess.Enabled = this.btnAceptar.Enabled = this.btnCancelar.Enabled = this.btnCambCve.Enabled = pnbotones.Enabled = true;

                // deshabilita el panel
                this.panel1.Enabled = false;

                this.ActiveControl = this.tbAccess;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peCambiarC_Click(object sender, EventArgs e)
        {
            try
            {
                // mostrar el panel del cambio de clave
                this.Size = new Size(304, 542);

                // se habilita el panel
                this.panel1.Enabled = true;

                // se deshabilita el acceso
                this.label1.Enabled = this.tbAccess.Enabled = pnbotones.Enabled = false;
                this.tbAccess.Text = string.Empty;

                // habilita el panel
                this.tbPCveAnt.Text = this.tbPCveNueva.Text = this.tbPConfirmCve.Text = string.Empty;
                this.ActiveControl = this.tbPCveAnt;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peAceptarNC_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbPCveAnt.Text))
                    throw new Exception("Ingrese la clave anterior");

                if (string.IsNullOrEmpty(this.tbPCveNueva.Text))
                    throw new Exception("Ingrese la clave nueva");

                if (string.IsNullOrEmpty(this.tbPConfirmCve.Text))
                    throw new Exception("Ingrese la clave a confirmar");

                // valida si la clave anterior es correcta
                string claveAcceso = objUtilerias.Transform(this.tbPCveAnt.Text);

                string acceso = string.Empty;
                if (form == "config")
                    acceso = Properties.Settings.Default.accesoConfig;
                else acceso = Properties.Settings.Default.accesoAdmon;

                if (!objUtilerias.Transform(acceso).Equals(objUtilerias.Transform(claveAcceso)))
                {
                    this.ActiveControl = this.tbPCveAnt;
                    this.tbPCveAnt.SelectAll();
                    throw new Exception("Clave anterior incorrecta");
                }

                string claveNueva = this.tbPCveNueva.Text;
                string claveConfirm = this.tbPConfirmCve.Text;

                if (!claveNueva.Equals(claveConfirm))
                {
                    this.ActiveControl = this.tbPCveNueva;
                    this.tbPConfirmCve.Text = string.Empty;
                    this.tbPCveNueva.SelectAll();
                    throw new Exception("La claves no coinciden");
                }

                string cveNAcceso = objUtilerias.Transform(this.tbPCveNueva.Text);

                if (form == "config")
                    AdministracionChecadas.Properties.Settings.Default.accesoConfig = cveNAcceso;
                else AdministracionChecadas.Properties.Settings.Default.accesoAdmon = cveNAcceso;

                //AdministracionChecadas.Properties.Settings.Default.accesoConfig = cveNAcceso;
                AdministracionChecadas.Properties.Settings.Default.Save();

                MessageBox.Show("Clave Modificada!!!", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.peCancelarNC_Click(null, null);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void peAceptar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                //switch (btn.Tag.ToString())
                //{
                //    //case "acepta":
                //    //    objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.aceptar1);
                //    //    break;
                //    //case "cancel":
                //    //    objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar1);
                //    //    break;
                //    //case "aceptac":
                //    //    objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.aceptar1);
                //    //    break;
                //    //case "cancelc":
                //    //    objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar1);
                //    //    break;
                //    //case "cambia":
                //    //    objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Actualizar1);
                //    //    break;
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
                //    case "acepta":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.aceptar2);
                //        break;
                //    case "cancel":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar2);
                //        break;
                //    case "aceptac":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.aceptar2);
                //        break;
                //    case "cancelc":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar2);
                //        break;
                //    case "cambia":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Actualizar2);
                //        break;
                //}

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tbAccess_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (tbAccess.Text.Trim() != "")
                {
                    if (e.Handled = new Utilerias().teclaEnter(e) == true)
                        peAceptar_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region Metodos
        #endregion

    }
}
