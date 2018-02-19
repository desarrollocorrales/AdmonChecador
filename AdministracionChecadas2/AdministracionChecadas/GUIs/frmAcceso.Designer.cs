namespace AdministracionChecadas.GUIs
{
    partial class frmAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.peCancelarNC = new DevExpress.XtraEditors.PictureEdit();
            this.peAceptarNC = new DevExpress.XtraEditors.PictureEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPCancelar = new System.Windows.Forms.Button();
            this.btnPAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPCveAnt = new System.Windows.Forms.TextBox();
            this.tbPConfirmCve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPCveNueva = new System.Windows.Forms.TextBox();
            this.btnCambCve = new System.Windows.Forms.Button();
            this.tbAccess = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnbotones = new System.Windows.Forms.Panel();
            this.peCambiarC = new DevExpress.XtraEditors.PictureEdit();
            this.peCancelar = new DevExpress.XtraEditors.PictureEdit();
            this.peAceptar = new DevExpress.XtraEditors.PictureEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.btnOcultar = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelarNC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAceptarNC.Properties)).BeginInit();
            this.pnbotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peCambiarC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAceptar.Properties)).BeginInit();
            this.tsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.peCancelarNC);
            this.panel1.Controls.Add(this.peAceptarNC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPCancelar);
            this.panel1.Controls.Add(this.btnPAceptar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPCveAnt);
            this.panel1.Controls.Add(this.tbPConfirmCve);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbPCveNueva);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(13, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 313);
            this.panel1.TabIndex = 25;
            // 
            // peCancelarNC
            // 
            this.peCancelarNC.EditValue = global::AdministracionChecadas.Properties.Resources.Cancelar2;
            this.peCancelarNC.Location = new System.Drawing.Point(189, 251);
            this.peCancelarNC.Name = "peCancelarNC";
            this.peCancelarNC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCancelarNC.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCancelarNC.Properties.ZoomAccelerationFactor = 1D;
            this.peCancelarNC.Size = new System.Drawing.Size(68, 43);
            this.peCancelarNC.TabIndex = 14;
            this.peCancelarNC.Tag = "cancelc";
            this.peCancelarNC.ToolTip = "Cancelar";
            this.peCancelarNC.Click += new System.EventHandler(this.peCancelarNC_Click);
            // 
            // peAceptarNC
            // 
            this.peAceptarNC.EditValue = global::AdministracionChecadas.Properties.Resources.aceptar2;
            this.peAceptarNC.Location = new System.Drawing.Point(21, 251);
            this.peAceptarNC.Name = "peAceptarNC";
            this.peAceptarNC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peAceptarNC.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAceptarNC.Properties.ZoomAccelerationFactor = 1D;
            this.peAceptarNC.Size = new System.Drawing.Size(68, 43);
            this.peAceptarNC.TabIndex = 13;
            this.peAceptarNC.Tag = "aceptac";
            this.peAceptarNC.ToolTip = "Aceptar";
            this.peAceptarNC.Click += new System.EventHandler(this.peAceptarNC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(51, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cambiar Clave";
            // 
            // btnPCancelar
            // 
            this.btnPCancelar.Location = new System.Drawing.Point(248, 256);
            this.btnPCancelar.Name = "btnPCancelar";
            this.btnPCancelar.Size = new System.Drawing.Size(17, 38);
            this.btnPCancelar.TabIndex = 12;
            this.btnPCancelar.Text = "Cancelar";
            this.btnPCancelar.UseVisualStyleBackColor = true;
            this.btnPCancelar.Visible = false;
            // 
            // btnPAceptar
            // 
            this.btnPAceptar.Location = new System.Drawing.Point(11, 256);
            this.btnPAceptar.Name = "btnPAceptar";
            this.btnPAceptar.Size = new System.Drawing.Size(19, 38);
            this.btnPAceptar.TabIndex = 11;
            this.btnPAceptar.Text = "Aceptar";
            this.btnPAceptar.UseVisualStyleBackColor = true;
            this.btnPAceptar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clave anterior";
            // 
            // tbPCveAnt
            // 
            this.tbPCveAnt.Location = new System.Drawing.Point(11, 78);
            this.tbPCveAnt.Name = "tbPCveAnt";
            this.tbPCveAnt.PasswordChar = '*';
            this.tbPCveAnt.Size = new System.Drawing.Size(251, 20);
            this.tbPCveAnt.TabIndex = 6;
            // 
            // tbPConfirmCve
            // 
            this.tbPConfirmCve.Location = new System.Drawing.Point(11, 217);
            this.tbPConfirmCve.Name = "tbPConfirmCve";
            this.tbPConfirmCve.PasswordChar = '*';
            this.tbPConfirmCve.Size = new System.Drawing.Size(251, 20);
            this.tbPConfirmCve.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clave nueva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirmar Clave";
            // 
            // tbPCveNueva
            // 
            this.tbPCveNueva.Location = new System.Drawing.Point(11, 146);
            this.tbPCveNueva.Name = "tbPCveNueva";
            this.tbPCveNueva.PasswordChar = '*';
            this.tbPCveNueva.Size = new System.Drawing.Size(251, 20);
            this.tbPCveNueva.TabIndex = 8;
            // 
            // btnCambCve
            // 
            this.btnCambCve.Location = new System.Drawing.Point(286, 129);
            this.btnCambCve.Name = "btnCambCve";
            this.btnCambCve.Size = new System.Drawing.Size(86, 38);
            this.btnCambCve.TabIndex = 24;
            this.btnCambCve.Text = "Cambiar Clave";
            this.btnCambCve.UseVisualStyleBackColor = true;
            this.btnCambCve.Visible = false;
            // 
            // tbAccess
            // 
            this.tbAccess.Location = new System.Drawing.Point(13, 100);
            this.tbAccess.Name = "tbAccess";
            this.tbAccess.PasswordChar = '*';
            this.tbAccess.Size = new System.Drawing.Size(272, 20);
            this.tbAccess.TabIndex = 23;
            this.tbAccess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAccess_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(333, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(39, 38);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Introduzca la clave de acceso";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(286, 85);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(41, 38);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            // 
            // pnbotones
            // 
            this.pnbotones.Controls.Add(this.peCambiarC);
            this.pnbotones.Controls.Add(this.peCancelar);
            this.pnbotones.Controls.Add(this.peAceptar);
            this.pnbotones.Location = new System.Drawing.Point(13, 125);
            this.pnbotones.Name = "pnbotones";
            this.pnbotones.Size = new System.Drawing.Size(272, 106);
            this.pnbotones.TabIndex = 26;
            // 
            // peCambiarC
            // 
            this.peCambiarC.EditValue = global::AdministracionChecadas.Properties.Resources.Actualizar2;
            this.peCambiarC.Location = new System.Drawing.Point(102, 53);
            this.peCambiarC.Name = "peCambiarC";
            this.peCambiarC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCambiarC.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCambiarC.Properties.ZoomAccelerationFactor = 1D;
            this.peCambiarC.Size = new System.Drawing.Size(68, 43);
            this.peCambiarC.TabIndex = 5;
            this.peCambiarC.Tag = "cambia";
            this.peCambiarC.ToolTip = "Cambiar Contraseña";
            this.peCambiarC.Click += new System.EventHandler(this.peCambiarC_Click);
            // 
            // peCancelar
            // 
            this.peCancelar.EditValue = global::AdministracionChecadas.Properties.Resources.Cancelar2;
            this.peCancelar.Location = new System.Drawing.Point(185, 8);
            this.peCancelar.Name = "peCancelar";
            this.peCancelar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCancelar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCancelar.Properties.ZoomAccelerationFactor = 1D;
            this.peCancelar.Size = new System.Drawing.Size(68, 43);
            this.peCancelar.TabIndex = 4;
            this.peCancelar.Tag = "cancel";
            this.peCancelar.ToolTip = "Cancelar";
            this.peCancelar.Click += new System.EventHandler(this.peCancelar_Click);
            // 
            // peAceptar
            // 
            this.peAceptar.EditValue = global::AdministracionChecadas.Properties.Resources.aceptar2;
            this.peAceptar.Location = new System.Drawing.Point(19, 8);
            this.peAceptar.Name = "peAceptar";
            this.peAceptar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peAceptar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAceptar.Properties.ZoomAccelerationFactor = 1D;
            this.peAceptar.Size = new System.Drawing.Size(68, 43);
            this.peAceptar.TabIndex = 3;
            this.peAceptar.Tag = "acepta";
            this.peAceptar.ToolTip = "Aceptar";
            this.peAceptar.Click += new System.EventHandler(this.peAceptar_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 35);
            this.label6.TabIndex = 28;
            this.label6.Text = "Acceso";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsControl
            // 
            this.tsControl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOcultar});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsControl.Size = new System.Drawing.Size(289, 40);
            this.tsControl.TabIndex = 27;
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
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(289, 550);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tsControl);
            this.Controls.Add(this.pnbotones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCambCve);
            this.Controls.Add(this.tbAccess);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelarNC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAceptarNC.Properties)).EndInit();
            this.pnbotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peCambiarC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAceptar.Properties)).EndInit();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPCancelar;
        private System.Windows.Forms.Button btnPAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPCveAnt;
        private System.Windows.Forms.TextBox tbPConfirmCve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPCveNueva;
        private System.Windows.Forms.Button btnCambCve;
        private System.Windows.Forms.TextBox tbAccess;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnbotones;
        private DevExpress.XtraEditors.PictureEdit peCancelar;
        private DevExpress.XtraEditors.PictureEdit peAceptar;
        private DevExpress.XtraEditors.PictureEdit peCancelarNC;
        private DevExpress.XtraEditors.PictureEdit peAceptarNC;
        private DevExpress.XtraEditors.PictureEdit peCambiarC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton btnOcultar;
    }
}