
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
    public partial class frmInicio : Form
    {
        #region Variables
        Efectos objEfectos = new Efectos(); 
        #endregion

        #region Constructor
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.Show();
        }
        #endregion

        #region Eventos
        private void peConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                cambiaImagen(btn);

                frmAcceso formA = new frmAcceso("config");
                var respuesta = formA.ShowDialog();

                if (respuesta == System.Windows.Forms.DialogResult.OK)
                {
                    this.Hide();
                    frmConfiguracion form = new frmConfiguracion();
                    var resultado = form.ShowDialog();

                    if (resultado == System.Windows.Forms.DialogResult.OK)
                        this.frmInicio_Load(null, null);
                }

                RegresaImagen(btn);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peDescarga_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChecadas form = new frmChecadas();
            var resultado = form.ShowDialog();

            if(resultado == System.Windows.Forms.DialogResult.OK)
            {
                this.frmInicio_Load(null, null);
            }
        }

        private void peAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                cambiaImagen(btn);
                frmAcceso formA = new frmAcceso("admon");
                var respuesta = formA.ShowDialog();

                if (respuesta == System.Windows.Forms.DialogResult.OK)
                {
                    this.Hide();
                    frmAdmon form = new frmAdmon();
                    var resultado = form.ShowDialog();

                    if (resultado == System.Windows.Forms.DialogResult.OK) 
                        this.frmInicio_Load(null, null);
                }

                RegresaImagen(btn);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void peSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void peConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                //DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                //switch (btn.Tag.ToString())
                //{
                //    case "configura":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Configuracion1);
                //        break;
                //    case "descarga":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.descarga1);
                //        break;
                //    case "admin":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.admin1);
                //        break;
                //    case "salir":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.salir1);
                //        break;
                //    case "mini":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.oculta11);
                //        break;
                //}
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peConfiguracion_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                //DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                //switch (btn.Tag.ToString())
                //{
                //    case "configura":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Configuracion2);
                //        break;
                //    case "descarga":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.descarga2);
                //        break;
                //    case "admin":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.admin2);
                //        break;
                //    case "salir":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.salir2);
                //        break;
                //    case "mini":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.oculta1);
                //        break;
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Metodos

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
