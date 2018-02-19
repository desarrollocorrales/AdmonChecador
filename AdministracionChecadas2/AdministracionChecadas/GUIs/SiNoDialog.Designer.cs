namespace AdministracionChecadas.GUIs
{
    partial class SiNoDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiNoDialog));
            this.peCancelar = new DevExpress.XtraEditors.PictureEdit();
            this.peAceptar = new DevExpress.XtraEditors.PictureEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMsj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAceptar.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // peCancelar
            // 
            this.peCancelar.EditValue = global::AdministracionChecadas.Properties.Resources.Cancelar2;
            this.peCancelar.Location = new System.Drawing.Point(198, 183);
            this.peCancelar.Name = "peCancelar";
            this.peCancelar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCancelar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCancelar.Properties.ZoomAccelerationFactor = 1D;
            this.peCancelar.Size = new System.Drawing.Size(68, 43);
            this.peCancelar.TabIndex = 6;
            this.peCancelar.Tag = "cancel";
            this.peCancelar.ToolTip = "Cancelar";
            this.peCancelar.Click += new System.EventHandler(this.peCancelar_Click);
            this.peCancelar.MouseLeave += new System.EventHandler(this.peAceptar_MouseLeave);
            this.peCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peAceptar_MouseMove);
            // 
            // peAceptar
            // 
            this.peAceptar.EditValue = global::AdministracionChecadas.Properties.Resources.aceptar2;
            this.peAceptar.Location = new System.Drawing.Point(46, 183);
            this.peAceptar.Name = "peAceptar";
            this.peAceptar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peAceptar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAceptar.Properties.ZoomAccelerationFactor = 1D;
            this.peAceptar.Size = new System.Drawing.Size(68, 43);
            this.peAceptar.TabIndex = 5;
            this.peAceptar.Tag = "acepta";
            this.peAceptar.ToolTip = "Aceptar";
            this.peAceptar.Click += new System.EventHandler(this.peAceptar_Click);
            this.peAceptar.MouseLeave += new System.EventHandler(this.peAceptar_MouseLeave);
            this.peAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peAceptar_MouseMove);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 35);
            this.label6.TabIndex = 30;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 35);
            this.label1.TabIndex = 31;
            this.label1.Text = "\"Atención\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMsj);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 106);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // txtMsj
            // 
            this.txtMsj.BackColor = System.Drawing.SystemColors.Window;
            this.txtMsj.Location = new System.Drawing.Point(4, 12);
            this.txtMsj.Multiline = true;
            this.txtMsj.Name = "txtMsj";
            this.txtMsj.ReadOnly = true;
            this.txtMsj.Size = new System.Drawing.Size(299, 78);
            this.txtMsj.TabIndex = 0;
            // 
            // SiNoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(307, 233);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.peCancelar);
            this.Controls.Add(this.peAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(307, 233);
            this.MinimumSize = new System.Drawing.Size(307, 233);
            this.Name = "SiNoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atención";
            this.Load += new System.EventHandler(this.SiNoDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peCancelar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAceptar.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit peCancelar;
        private DevExpress.XtraEditors.PictureEdit peAceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMsj;
    }
}