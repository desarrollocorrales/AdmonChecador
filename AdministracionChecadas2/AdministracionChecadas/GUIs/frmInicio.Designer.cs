namespace AdministracionChecadas.GUIs
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.btnOcultar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.peAdmin = new DevExpress.XtraEditors.PictureEdit();
            this.peDescarga = new DevExpress.XtraEditors.PictureEdit();
            this.peConfiguracion = new DevExpress.XtraEditors.PictureEdit();
            this.peSalir = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.tsControl.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peDescarga.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peConfiguracion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSalir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(741, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Copyright ©  2018 Version 1.1";
            // 
            // tsControl
            // 
            this.tsControl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOcultar,
            this.btnSalir});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsControl.Size = new System.Drawing.Size(931, 40);
            this.tsControl.TabIndex = 7;
            this.tsControl.Text = "toolStrip1";
            // 
            // btnOcultar
            // 
            this.btnOcultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOcultar.Image = ((System.Drawing.Image)(resources.GetObject("btnOcultar.Image")));
            this.btnOcultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOcultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(50, 37);
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.Click += new System.EventHandler(this.pictureEdit2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 37);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.peSalir_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(931, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bienvenido al Administrador de Checadores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.MagicArrow;
            this.expandCollapsePanel1.Controls.Add(this.peAdmin);
            this.expandCollapsePanel1.Controls.Add(this.peDescarga);
            this.expandCollapsePanel1.Controls.Add(this.peConfiguracion);
            this.expandCollapsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandCollapsePanel1.ExpandedHeight = 0;
            this.expandCollapsePanel1.IsExpanded = true;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(0, 75);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(931, 242);
            this.expandCollapsePanel1.TabIndex = 9;
            this.expandCollapsePanel1.Text = "Menú Inicio";
            this.expandCollapsePanel1.UseAnimation = true;
            // 
            // peAdmin
            // 
            this.peAdmin.EditValue = ((object)(resources.GetObject("peAdmin.EditValue")));
            this.peAdmin.Location = new System.Drawing.Point(687, 44);
            this.peAdmin.Name = "peAdmin";
            this.peAdmin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.peAdmin.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAdmin.Properties.ZoomAccelerationFactor = 1D;
            this.peAdmin.Properties.ZoomPercent = 20D;
            this.peAdmin.Size = new System.Drawing.Size(179, 174);
            this.peAdmin.TabIndex = 3;
            this.peAdmin.Tag = "admin";
            this.peAdmin.Click += new System.EventHandler(this.peAdmin_Click);
            // 
            // peDescarga
            // 
            this.peDescarga.EditValue = ((object)(resources.GetObject("peDescarga.EditValue")));
            this.peDescarga.Location = new System.Drawing.Point(364, 44);
            this.peDescarga.Name = "peDescarga";
            this.peDescarga.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.peDescarga.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peDescarga.Properties.ZoomAccelerationFactor = 1D;
            this.peDescarga.Properties.ZoomPercent = 20D;
            this.peDescarga.Size = new System.Drawing.Size(179, 174);
            this.peDescarga.TabIndex = 2;
            this.peDescarga.Tag = "descarga";
            this.peDescarga.Click += new System.EventHandler(this.peDescarga_Click);
            // 
            // peConfiguracion
            // 
            this.peConfiguracion.EditValue = ((object)(resources.GetObject("peConfiguracion.EditValue")));
            this.peConfiguracion.Location = new System.Drawing.Point(35, 44);
            this.peConfiguracion.Name = "peConfiguracion";
            this.peConfiguracion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.peConfiguracion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peConfiguracion.Properties.ZoomAccelerationFactor = 1D;
            this.peConfiguracion.Properties.ZoomPercent = 20D;
            this.peConfiguracion.Size = new System.Drawing.Size(179, 174);
            this.peConfiguracion.TabIndex = 1;
            this.peConfiguracion.Tag = "configura";
            this.peConfiguracion.Click += new System.EventHandler(this.peConfiguracion_Click);
            // 
            // peSalir
            // 
            this.peSalir.EditValue = global::AdministracionChecadas.Properties.Resources.salir1;
            this.peSalir.Enabled = false;
            this.peSalir.Location = new System.Drawing.Point(62, 363);
            this.peSalir.Name = "peSalir";
            this.peSalir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peSalir.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peSalir.Properties.ZoomAccelerationFactor = 1D;
            this.peSalir.Properties.ZoomPercent = 50D;
            this.peSalir.Size = new System.Drawing.Size(46, 33);
            this.peSalir.TabIndex = 5;
            this.peSalir.Tag = "salir";
            this.peSalir.ToolTip = "Salir";
            this.peSalir.Visible = false;
            this.peSalir.Click += new System.EventHandler(this.peSalir_Click);
            this.peSalir.MouseLeave += new System.EventHandler(this.peConfiguracion_MouseLeave);
            this.peSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peConfiguracion_MouseMove);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::AdministracionChecadas.Properties.Resources.oculta11;
            this.pictureEdit2.Enabled = false;
            this.pictureEdit2.Location = new System.Drawing.Point(9, 364);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit2.Properties.ZoomPercent = 40D;
            this.pictureEdit2.Size = new System.Drawing.Size(47, 33);
            this.pictureEdit2.TabIndex = 4;
            this.pictureEdit2.Tag = "mini";
            this.pictureEdit2.ToolTip = "Ocultar";
            this.pictureEdit2.Visible = false;
            this.pictureEdit2.Click += new System.EventHandler(this.pictureEdit2_Click);
            this.pictureEdit2.MouseLeave += new System.EventHandler(this.peConfiguracion_MouseLeave);
            this.pictureEdit2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peConfiguracion_MouseMove);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(931, 399);
            this.ControlBox = false;
            this.Controls.Add(this.expandCollapsePanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsControl);
            this.Controls.Add(this.peSalir);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(931, 399);
            this.MinimumSize = new System.Drawing.Size(931, 399);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "descarga";
            this.Text = "Bienvenido al Administrador de Checadores";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.expandCollapsePanel1.ResumeLayout(false);
            this.expandCollapsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peDescarga.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peConfiguracion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSalir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.PictureEdit peSalir;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton btnOcultar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label label2;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
        private DevExpress.XtraEditors.PictureEdit peAdmin;
        private DevExpress.XtraEditors.PictureEdit peDescarga;
        private DevExpress.XtraEditors.PictureEdit peConfiguracion;
    }
}