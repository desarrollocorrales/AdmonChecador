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
    public partial class SiNoDialog : Form
    {
        string mensaje = string.Empty;
        Efectos objEfectos = new Efectos();
        public SiNoDialog()
        {
            InitializeComponent();
        }

        public SiNoDialog(string msj)
        {
            InitializeComponent();
            mensaje = msj;
        }

        private void SiNoDialog_Load(object sender, EventArgs e)
        {
            if (mensaje != "")
                txtMsj.Text = mensaje + " \n\t¿Desea Confirmar esta Acción?";
        }

        private void peAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void peCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void peAceptar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                //DevExpress.XtraEditors.PictureEdit btn = (DevExpress.XtraEditors.PictureEdit)sender;
                //switch (btn.Tag.ToString())
                //{
                //    case "acepta":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.aceptar1);
                //        break;
                //    case "cancel":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar1);
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
                //    case "acepta":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.aceptar2);
                //        break;
                //    case "cancel":
                //        objEfectos.MouseLeaveEfectoPE(btn, AdministracionChecadas.Properties.Resources.Cancelar2);
                //        break;
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
