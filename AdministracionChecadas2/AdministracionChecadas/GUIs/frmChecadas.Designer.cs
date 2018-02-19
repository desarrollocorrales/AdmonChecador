namespace AdministracionChecadas.GUIs
{
    partial class frmChecadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChecadas));
            this.lbChecador = new System.Windows.Forms.Label();
            this.tbResultados = new System.Windows.Forms.TextBox();
            this.peMinimiza = new DevExpress.XtraEditors.PictureEdit();
            this.peCancelar = new DevExpress.XtraEditors.PictureEdit();
            this.peAceptar = new DevExpress.XtraEditors.PictureEdit();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.btnOcultar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peMinimiza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAceptar.Properties)).BeginInit();
            this.tsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbChecador
            // 
            this.lbChecador.AutoSize = true;
            this.lbChecador.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbChecador.Location = new System.Drawing.Point(346, 79);
            this.lbChecador.Name = "lbChecador";
            this.lbChecador.Size = new System.Drawing.Size(96, 23);
            this.lbChecador.TabIndex = 3;
            this.lbChecador.Text = "Checador:";
            // 
            // tbResultados
            // 
            this.tbResultados.BackColor = System.Drawing.Color.White;
            this.tbResultados.Font = new System.Drawing.Font("Consolas", 12F);
            this.tbResultados.Location = new System.Drawing.Point(12, 148);
            this.tbResultados.Multiline = true;
            this.tbResultados.Name = "tbResultados";
            this.tbResultados.ReadOnly = true;
            this.tbResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultados.Size = new System.Drawing.Size(971, 473);
            this.tbResultados.TabIndex = 7;
            // 
            // peMinimiza
            // 
            this.peMinimiza.EditValue = ((object)(resources.GetObject("peMinimiza.EditValue")));
            this.peMinimiza.Enabled = false;
            this.peMinimiza.Location = new System.Drawing.Point(62, 94);
            this.peMinimiza.Name = "peMinimiza";
            this.peMinimiza.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peMinimiza.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peMinimiza.Properties.ZoomAccelerationFactor = 1D;
            this.peMinimiza.Size = new System.Drawing.Size(36, 30);
            this.peMinimiza.TabIndex = 9;
            this.peMinimiza.Tag = "minimiza";
            this.peMinimiza.ToolTip = "Ocultar";
            this.peMinimiza.Visible = false;
            this.peMinimiza.Click += new System.EventHandler(this.peMinimiza_Click);
            // 
            // peCancelar
            // 
            this.peCancelar.EditValue = ((object)(resources.GetObject("peCancelar.EditValue")));
            this.peCancelar.Enabled = false;
            this.peCancelar.Location = new System.Drawing.Point(12, 94);
            this.peCancelar.Name = "peCancelar";
            this.peCancelar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCancelar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCancelar.Properties.ZoomAccelerationFactor = 1D;
            this.peCancelar.Size = new System.Drawing.Size(35, 30);
            this.peCancelar.TabIndex = 8;
            this.peCancelar.Tag = "cancel";
            this.peCancelar.ToolTip = "Cancelar";
            this.peCancelar.Visible = false;
            this.peCancelar.Click += new System.EventHandler(this.peCancelar_Click);
            // 
            // peAceptar
            // 
            this.peAceptar.EditValue = ((object)(resources.GetObject("peAceptar.EditValue")));
            this.peAceptar.Location = new System.Drawing.Point(882, 78);
            this.peAceptar.Name = "peAceptar";
            this.peAceptar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peAceptar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAceptar.Properties.ZoomAccelerationFactor = 1D;
            this.peAceptar.Size = new System.Drawing.Size(101, 64);
            this.peAceptar.TabIndex = 6;
            this.peAceptar.Tag = "checadas";
            this.peAceptar.ToolTip = "Descargar Checadas";
            this.peAceptar.Click += new System.EventHandler(this.peAceptar_Click);
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
            this.tsControl.Size = new System.Drawing.Size(1011, 40);
            this.tsControl.TabIndex = 10;
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
            this.btnOcultar.Click += new System.EventHandler(this.peMinimiza_Click);
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
            this.btnSalir.Click += new System.EventHandler(this.peCancelar_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1011, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descargar Registros del Checador";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChecadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1011, 645);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsControl);
            this.Controls.Add(this.peMinimiza);
            this.Controls.Add(this.peCancelar);
            this.Controls.Add(this.tbResultados);
            this.Controls.Add(this.peAceptar);
            this.Controls.Add(this.lbChecador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1011, 645);
            this.MinimumSize = new System.Drawing.Size(1011, 645);
            this.Name = "frmChecadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checadas";
            this.Load += new System.EventHandler(this.frmChecadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peMinimiza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAceptar.Properties)).EndInit();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChecador;
        private DevExpress.XtraEditors.PictureEdit peAceptar;
        private System.Windows.Forms.TextBox tbResultados;
        private DevExpress.XtraEditors.PictureEdit peCancelar;
        private DevExpress.XtraEditors.PictureEdit peMinimiza;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton btnOcultar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label label2;
    }
}