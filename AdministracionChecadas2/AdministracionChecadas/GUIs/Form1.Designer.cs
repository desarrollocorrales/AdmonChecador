namespace AdministracionChecadas.GUIs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ecpMenu = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.peUser = new DevExpress.XtraEditors.PictureEdit();
            this.peOcultaMenu = new DevExpress.XtraEditors.PictureEdit();
            this.peSalir = new DevExpress.XtraEditors.PictureEdit();
            this.peRestart = new DevExpress.XtraEditors.PictureEdit();
            this.peDeleteLog = new DevExpress.XtraEditors.PictureEdit();
            this.peSyncTime = new DevExpress.XtraEditors.PictureEdit();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.peCancelar = new DevExpress.XtraEditors.PictureEdit();
            this.pnUser = new System.Windows.Forms.Panel();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.cbPrivilege = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnbASU = new System.Windows.Forms.Panel();
            this.peAceptarSet = new DevExpress.XtraEditors.PictureEdit();
            this.pnAGU = new System.Windows.Forms.Panel();
            this.peAceptarGet = new DevExpress.XtraEditors.PictureEdit();
            this.peGetUser = new DevExpress.XtraEditors.PictureEdit();
            this.peSetUser = new DevExpress.XtraEditors.PictureEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCardnumber = new System.Windows.Forms.TextBox();
            this.pnSyncTime = new System.Windows.Forms.Panel();
            this.dtpTiempo = new System.Windows.Forms.DateTimePicker();
            this.lblSetTime = new System.Windows.Forms.Label();
            this.peSetTime = new DevExpress.XtraEditors.PictureEdit();
            this.lblGetTime = new System.Windows.Forms.Label();
            this.peGTime = new DevExpress.XtraEditors.PictureEdit();
            this.lbSyncTime = new System.Windows.Forms.Label();
            this.peSync = new DevExpress.XtraEditors.PictureEdit();
            this.pnReinicio = new System.Windows.Forms.Panel();
            this.peBorrarTodo = new DevExpress.XtraEditors.PictureEdit();
            this.peOff = new DevExpress.XtraEditors.PictureEdit();
            this.peReiniciar = new DevExpress.XtraEditors.PictureEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMsj = new System.Windows.Forms.TextBox();
            this.ecpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peOcultaMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSalir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peRestart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peDeleteLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSyncTime.Properties)).BeginInit();
            this.pnContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelar.Properties)).BeginInit();
            this.pnUser.SuspendLayout();
            this.pnDatos.SuspendLayout();
            this.pnbASU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peAceptarSet.Properties)).BeginInit();
            this.pnAGU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peAceptarGet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peGetUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSetUser.Properties)).BeginInit();
            this.pnSyncTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peSetTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peGTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSync.Properties)).BeginInit();
            this.pnReinicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peBorrarTodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peOff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peReiniciar.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ecpMenu
            // 
            this.ecpMenu.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.ecpMenu.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.MagicArrow;
            this.ecpMenu.Controls.Add(this.peUser);
            this.ecpMenu.Controls.Add(this.peOcultaMenu);
            this.ecpMenu.Controls.Add(this.peSalir);
            this.ecpMenu.Controls.Add(this.peRestart);
            this.ecpMenu.Controls.Add(this.peDeleteLog);
            this.ecpMenu.Controls.Add(this.peSyncTime);
            this.ecpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ecpMenu.ExpandedHeight = 250;
            this.ecpMenu.IsExpanded = true;
            this.ecpMenu.Location = new System.Drawing.Point(0, 0);
            this.ecpMenu.Name = "ecpMenu";
            this.ecpMenu.Size = new System.Drawing.Size(913, 250);
            this.ecpMenu.TabIndex = 6;
            this.ecpMenu.Text = "Menú";
            this.ecpMenu.UseAnimation = true;
            // 
            // peUser
            // 
            this.peUser.EditValue = global::AdministracionChecadas.Properties.Resources.user1;
            this.peUser.Location = new System.Drawing.Point(684, 54);
            this.peUser.Name = "peUser";
            this.peUser.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.peUser.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.peUser.Properties.Appearance.Options.UseBackColor = true;
            this.peUser.Properties.Appearance.Options.UseForeColor = true;
            this.peUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peUser.Properties.ZoomAccelerationFactor = 1D;
            this.peUser.Properties.ZoomPercent = 21D;
            this.peUser.Size = new System.Drawing.Size(179, 174);
            this.peUser.TabIndex = 12;
            this.peUser.Tag = "user";
            this.peUser.ToolTip = "Usuarios";
            // 
            // peOcultaMenu
            // 
            this.peOcultaMenu.EditValue = ((object)(resources.GetObject("peOcultaMenu.EditValue")));
            this.peOcultaMenu.Location = new System.Drawing.Point(888, 43);
            this.peOcultaMenu.Name = "peOcultaMenu";
            this.peOcultaMenu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.peOcultaMenu.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.peOcultaMenu.Properties.Appearance.Options.UseBackColor = true;
            this.peOcultaMenu.Properties.Appearance.Options.UseForeColor = true;
            this.peOcultaMenu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peOcultaMenu.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peOcultaMenu.Properties.ZoomAccelerationFactor = 1D;
            this.peOcultaMenu.Size = new System.Drawing.Size(68, 43);
            this.peOcultaMenu.TabIndex = 11;
            this.peOcultaMenu.Tag = "minimiza";
            this.peOcultaMenu.ToolTip = "Ocultar";
            // 
            // peSalir
            // 
            this.peSalir.EditValue = ((object)(resources.GetObject("peSalir.EditValue")));
            this.peSalir.Location = new System.Drawing.Point(888, 92);
            this.peSalir.Name = "peSalir";
            this.peSalir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.peSalir.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.peSalir.Properties.Appearance.Options.UseBackColor = true;
            this.peSalir.Properties.Appearance.Options.UseForeColor = true;
            this.peSalir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peSalir.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peSalir.Properties.ZoomAccelerationFactor = 1D;
            this.peSalir.Size = new System.Drawing.Size(68, 43);
            this.peSalir.TabIndex = 10;
            this.peSalir.Tag = "cancel";
            this.peSalir.ToolTip = "Cancelar";
            // 
            // peRestart
            // 
            this.peRestart.EditValue = ((object)(resources.GetObject("peRestart.EditValue")));
            this.peRestart.Location = new System.Drawing.Point(468, 54);
            this.peRestart.Name = "peRestart";
            this.peRestart.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.peRestart.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.peRestart.Properties.Appearance.Options.UseBackColor = true;
            this.peRestart.Properties.Appearance.Options.UseForeColor = true;
            this.peRestart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peRestart.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peRestart.Properties.ZoomAccelerationFactor = 1D;
            this.peRestart.Properties.ZoomPercent = 21D;
            this.peRestart.Size = new System.Drawing.Size(179, 174);
            this.peRestart.TabIndex = 4;
            this.peRestart.Tag = "reinicio";
            this.peRestart.ToolTip = "Control";
            // 
            // peDeleteLog
            // 
            this.peDeleteLog.EditValue = global::AdministracionChecadas.Properties.Resources.checadas1;
            this.peDeleteLog.Location = new System.Drawing.Point(245, 54);
            this.peDeleteLog.Name = "peDeleteLog";
            this.peDeleteLog.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.peDeleteLog.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.peDeleteLog.Properties.Appearance.Options.UseBackColor = true;
            this.peDeleteLog.Properties.Appearance.Options.UseForeColor = true;
            this.peDeleteLog.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peDeleteLog.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peDeleteLog.Properties.ZoomAccelerationFactor = 1D;
            this.peDeleteLog.Properties.ZoomPercent = 21D;
            this.peDeleteLog.Size = new System.Drawing.Size(179, 174);
            this.peDeleteLog.TabIndex = 3;
            this.peDeleteLog.Tag = "borra";
            this.peDeleteLog.ToolTip = "Eliminar Checadas";
            // 
            // peSyncTime
            // 
            this.peSyncTime.EditValue = ((object)(resources.GetObject("peSyncTime.EditValue")));
            this.peSyncTime.Location = new System.Drawing.Point(16, 54);
            this.peSyncTime.Name = "peSyncTime";
            this.peSyncTime.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.peSyncTime.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.peSyncTime.Properties.Appearance.Options.UseBackColor = true;
            this.peSyncTime.Properties.Appearance.Options.UseForeColor = true;
            this.peSyncTime.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peSyncTime.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peSyncTime.Properties.ZoomAccelerationFactor = 1D;
            this.peSyncTime.Properties.ZoomPercent = 21D;
            this.peSyncTime.Size = new System.Drawing.Size(179, 174);
            this.peSyncTime.TabIndex = 2;
            this.peSyncTime.Tag = "time";
            this.peSyncTime.ToolTip = "Tiempos";
            // 
            // pnContenedor
            // 
            this.pnContenedor.Controls.Add(this.textBox1);
            this.pnContenedor.Controls.Add(this.peCancelar);
            this.pnContenedor.Controls.Add(this.pnUser);
            this.pnContenedor.Controls.Add(this.pnSyncTime);
            this.pnContenedor.Controls.Add(this.pnReinicio);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContenedor.Location = new System.Drawing.Point(0, 250);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(913, 256);
            this.pnContenedor.TabIndex = 7;
            this.pnContenedor.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(888, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // peCancelar
            // 
            this.peCancelar.EditValue = ((object)(resources.GetObject("peCancelar.EditValue")));
            this.peCancelar.Location = new System.Drawing.Point(879, 8);
            this.peCancelar.Name = "peCancelar";
            this.peCancelar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCancelar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCancelar.Properties.ZoomAccelerationFactor = 1D;
            this.peCancelar.Size = new System.Drawing.Size(68, 43);
            this.peCancelar.TabIndex = 10;
            this.peCancelar.Tag = "inicio";
            this.peCancelar.ToolTip = "Cancelar";
            // 
            // pnUser
            // 
            this.pnUser.Controls.Add(this.pnDatos);
            this.pnUser.Controls.Add(this.pnbASU);
            this.pnUser.Controls.Add(this.pnAGU);
            this.pnUser.Controls.Add(this.peGetUser);
            this.pnUser.Controls.Add(this.peSetUser);
            this.pnUser.Controls.Add(this.label6);
            this.pnUser.Controls.Add(this.txtCardnumber);
            this.pnUser.Location = new System.Drawing.Point(7, 3);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(857, 245);
            this.pnUser.TabIndex = 8;
            this.pnUser.Visible = false;
            // 
            // pnDatos
            // 
            this.pnDatos.Controls.Add(this.txtUserID);
            this.pnDatos.Controls.Add(this.cbPrivilege);
            this.pnDatos.Controls.Add(this.txtPassword);
            this.pnDatos.Controls.Add(this.txtName);
            this.pnDatos.Controls.Add(this.label2);
            this.pnDatos.Controls.Add(this.label3);
            this.pnDatos.Controls.Add(this.label4);
            this.pnDatos.Controls.Add(this.label5);
            this.pnDatos.Location = new System.Drawing.Point(40, 47);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(600, 124);
            this.pnDatos.TabIndex = 92;
            this.pnDatos.Visible = false;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(95, 29);
            this.txtUserID.MaxLength = 24;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(142, 20);
            this.txtUserID.TabIndex = 69;
            // 
            // cbPrivilege
            // 
            this.cbPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrivilege.FormattingEnabled = true;
            this.cbPrivilege.Items.AddRange(new object[] {
            "0-Normal",
            "1-Enroll",
            "2-Admin",
            "3-Super Admin",
            "4-User Defined Role3",
            "5-Undefine"});
            this.cbPrivilege.Location = new System.Drawing.Point(97, 74);
            this.cbPrivilege.Name = "cbPrivilege";
            this.cbPrivilege.Size = new System.Drawing.Size(142, 21);
            this.cbPrivilege.TabIndex = 72;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(388, 79);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 20);
            this.txtPassword.TabIndex = 71;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(388, 29);
            this.txtName.MaxLength = 24;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 20);
            this.txtName.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(32, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(279, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 80;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(8, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 81;
            this.label4.Text = "Privilegio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.Location = new System.Drawing.Point(255, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 82;
            this.label5.Text = "Contraseña";
            // 
            // pnbASU
            // 
            this.pnbASU.Controls.Add(this.peAceptarSet);
            this.pnbASU.Location = new System.Drawing.Point(751, 186);
            this.pnbASU.Name = "pnbASU";
            this.pnbASU.Size = new System.Drawing.Size(84, 46);
            this.pnbASU.TabIndex = 91;
            this.pnbASU.Visible = false;
            // 
            // peAceptarSet
            // 
            this.peAceptarSet.EditValue = ((object)(resources.GetObject("peAceptarSet.EditValue")));
            this.peAceptarSet.Location = new System.Drawing.Point(13, 2);
            this.peAceptarSet.Name = "peAceptarSet";
            this.peAceptarSet.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peAceptarSet.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAceptarSet.Properties.ZoomAccelerationFactor = 1D;
            this.peAceptarSet.Size = new System.Drawing.Size(68, 43);
            this.peAceptarSet.TabIndex = 89;
            this.peAceptarSet.Tag = "acepta";
            this.peAceptarSet.ToolTip = "Aceptar";
            // 
            // pnAGU
            // 
            this.pnAGU.Controls.Add(this.peAceptarGet);
            this.pnAGU.Location = new System.Drawing.Point(751, 134);
            this.pnAGU.Name = "pnAGU";
            this.pnAGU.Size = new System.Drawing.Size(84, 46);
            this.pnAGU.TabIndex = 90;
            this.pnAGU.Visible = false;
            // 
            // peAceptarGet
            // 
            this.peAceptarGet.EditValue = ((object)(resources.GetObject("peAceptarGet.EditValue")));
            this.peAceptarGet.Location = new System.Drawing.Point(15, 1);
            this.peAceptarGet.Name = "peAceptarGet";
            this.peAceptarGet.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peAceptarGet.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAceptarGet.Properties.ZoomAccelerationFactor = 1D;
            this.peAceptarGet.Size = new System.Drawing.Size(68, 43);
            this.peAceptarGet.TabIndex = 89;
            this.peAceptarGet.Tag = "acepta";
            this.peAceptarGet.ToolTip = "Aceptar";
            // 
            // peGetUser
            // 
            this.peGetUser.EditValue = global::AdministracionChecadas.Properties.Resources.GetUser1;
            this.peGetUser.Location = new System.Drawing.Point(767, 5);
            this.peGetUser.Name = "peGetUser";
            this.peGetUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peGetUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peGetUser.Properties.ZoomAccelerationFactor = 1D;
            this.peGetUser.Size = new System.Drawing.Size(68, 43);
            this.peGetUser.TabIndex = 85;
            this.peGetUser.Tag = "getuser";
            this.peGetUser.ToolTip = "Editar Usuario";
            // 
            // peSetUser
            // 
            this.peSetUser.EditValue = global::AdministracionChecadas.Properties.Resources.setuser1;
            this.peSetUser.Location = new System.Drawing.Point(667, 5);
            this.peSetUser.Name = "peSetUser";
            this.peSetUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peSetUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peSetUser.Properties.ZoomAccelerationFactor = 1D;
            this.peSetUser.Size = new System.Drawing.Size(68, 43);
            this.peSetUser.TabIndex = 84;
            this.peSetUser.Tag = "setuser";
            this.peSetUser.ToolTip = "Agregar Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 83;
            this.label6.Text = "No. Tarjeta";
            this.label6.Visible = false;
            // 
            // txtCardnumber
            // 
            this.txtCardnumber.Location = new System.Drawing.Point(130, 200);
            this.txtCardnumber.MaxLength = 24;
            this.txtCardnumber.Name = "txtCardnumber";
            this.txtCardnumber.Size = new System.Drawing.Size(114, 20);
            this.txtCardnumber.TabIndex = 73;
            this.txtCardnumber.Visible = false;
            // 
            // pnSyncTime
            // 
            this.pnSyncTime.Controls.Add(this.dtpTiempo);
            this.pnSyncTime.Controls.Add(this.lblSetTime);
            this.pnSyncTime.Controls.Add(this.peSetTime);
            this.pnSyncTime.Controls.Add(this.lblGetTime);
            this.pnSyncTime.Controls.Add(this.peGTime);
            this.pnSyncTime.Controls.Add(this.lbSyncTime);
            this.pnSyncTime.Controls.Add(this.peSync);
            this.pnSyncTime.Location = new System.Drawing.Point(3, 4);
            this.pnSyncTime.Name = "pnSyncTime";
            this.pnSyncTime.Size = new System.Drawing.Size(857, 245);
            this.pnSyncTime.TabIndex = 0;
            this.pnSyncTime.Visible = false;
            // 
            // dtpTiempo
            // 
            this.dtpTiempo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTiempo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTiempo.Location = new System.Drawing.Point(127, 188);
            this.dtpTiempo.Name = "dtpTiempo";
            this.dtpTiempo.Size = new System.Drawing.Size(137, 20);
            this.dtpTiempo.TabIndex = 13;
            // 
            // lblSetTime
            // 
            this.lblSetTime.AutoSize = true;
            this.lblSetTime.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblSetTime.Location = new System.Drawing.Point(270, 185);
            this.lblSetTime.Name = "lblSetTime";
            this.lblSetTime.Size = new System.Drawing.Size(0, 23);
            this.lblSetTime.TabIndex = 12;
            // 
            // peSetTime
            // 
            this.peSetTime.EditValue = global::AdministracionChecadas.Properties.Resources.SetTime1;
            this.peSetTime.Location = new System.Drawing.Point(39, 176);
            this.peSetTime.Name = "peSetTime";
            this.peSetTime.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peSetTime.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peSetTime.Properties.ZoomAccelerationFactor = 1D;
            this.peSetTime.Size = new System.Drawing.Size(68, 43);
            this.peSetTime.TabIndex = 11;
            this.peSetTime.Tag = "SetTime";
            this.peSetTime.ToolTip = "Establecer tiempo ";
            // 
            // lblGetTime
            // 
            this.lblGetTime.AutoSize = true;
            this.lblGetTime.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblGetTime.Location = new System.Drawing.Point(123, 22);
            this.lblGetTime.Name = "lblGetTime";
            this.lblGetTime.Size = new System.Drawing.Size(0, 23);
            this.lblGetTime.TabIndex = 10;
            // 
            // peGTime
            // 
            this.peGTime.EditValue = global::AdministracionChecadas.Properties.Resources.getTime1;
            this.peGTime.Location = new System.Drawing.Point(39, 12);
            this.peGTime.Name = "peGTime";
            this.peGTime.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peGTime.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peGTime.Properties.ZoomAccelerationFactor = 1D;
            this.peGTime.Size = new System.Drawing.Size(68, 43);
            this.peGTime.TabIndex = 9;
            this.peGTime.Tag = "GetTime";
            this.peGTime.ToolTip = "Tiempo Checador";
            // 
            // lbSyncTime
            // 
            this.lbSyncTime.AutoSize = true;
            this.lbSyncTime.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbSyncTime.Location = new System.Drawing.Point(123, 100);
            this.lbSyncTime.Name = "lbSyncTime";
            this.lbSyncTime.Size = new System.Drawing.Size(0, 23);
            this.lbSyncTime.TabIndex = 8;
            // 
            // peSync
            // 
            this.peSync.EditValue = global::AdministracionChecadas.Properties.Resources.sync1;
            this.peSync.Location = new System.Drawing.Point(39, 90);
            this.peSync.Name = "peSync";
            this.peSync.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peSync.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peSync.Properties.ZoomAccelerationFactor = 1D;
            this.peSync.Size = new System.Drawing.Size(68, 43);
            this.peSync.TabIndex = 7;
            this.peSync.Tag = "sync";
            this.peSync.ToolTip = "Sincronizar tiempo ";
            // 
            // pnReinicio
            // 
            this.pnReinicio.Controls.Add(this.peBorrarTodo);
            this.pnReinicio.Controls.Add(this.peOff);
            this.pnReinicio.Controls.Add(this.peReiniciar);
            this.pnReinicio.Location = new System.Drawing.Point(5, 3);
            this.pnReinicio.Name = "pnReinicio";
            this.pnReinicio.Size = new System.Drawing.Size(857, 245);
            this.pnReinicio.TabIndex = 7;
            this.pnReinicio.Visible = false;
            // 
            // peBorrarTodo
            // 
            this.peBorrarTodo.EditValue = global::AdministracionChecadas.Properties.Resources.btodo1;
            this.peBorrarTodo.Location = new System.Drawing.Point(667, 91);
            this.peBorrarTodo.Name = "peBorrarTodo";
            this.peBorrarTodo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peBorrarTodo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peBorrarTodo.Properties.ZoomAccelerationFactor = 1D;
            this.peBorrarTodo.Size = new System.Drawing.Size(68, 43);
            this.peBorrarTodo.TabIndex = 3;
            this.peBorrarTodo.Tag = "clear";
            this.peBorrarTodo.ToolTip = "Borrar Todo";
            // 
            // peOff
            // 
            this.peOff.EditValue = global::AdministracionChecadas.Properties.Resources.apagar1;
            this.peOff.Location = new System.Drawing.Point(389, 91);
            this.peOff.Name = "peOff";
            this.peOff.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peOff.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peOff.Properties.ZoomAccelerationFactor = 1D;
            this.peOff.Size = new System.Drawing.Size(68, 43);
            this.peOff.TabIndex = 2;
            this.peOff.Tag = "off";
            this.peOff.ToolTip = "Apagar Checador";
            // 
            // peReiniciar
            // 
            this.peReiniciar.EditValue = global::AdministracionChecadas.Properties.Resources.Reinicio11;
            this.peReiniciar.Location = new System.Drawing.Point(79, 91);
            this.peReiniciar.Name = "peReiniciar";
            this.peReiniciar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peReiniciar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peReiniciar.Properties.ZoomAccelerationFactor = 1D;
            this.peReiniciar.Size = new System.Drawing.Size(68, 43);
            this.peReiniciar.TabIndex = 1;
            this.peReiniciar.Tag = "reinicia";
            this.peReiniciar.ToolTip = "Reiniciar Checador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMsj);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 506);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 106);
            this.groupBox1.TabIndex = 8;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 643);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.ecpMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ecpMenu.ResumeLayout(false);
            this.ecpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peOcultaMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSalir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peRestart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peDeleteLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSyncTime.Properties)).EndInit();
            this.pnContenedor.ResumeLayout(false);
            this.pnContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelar.Properties)).EndInit();
            this.pnUser.ResumeLayout(false);
            this.pnUser.PerformLayout();
            this.pnDatos.ResumeLayout(false);
            this.pnDatos.PerformLayout();
            this.pnbASU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peAceptarSet.Properties)).EndInit();
            this.pnAGU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peAceptarGet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peGetUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSetUser.Properties)).EndInit();
            this.pnSyncTime.ResumeLayout(false);
            this.pnSyncTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peSetTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peGTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSync.Properties)).EndInit();
            this.pnReinicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peBorrarTodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peOff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peReiniciar.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel ecpMenu;
        private DevExpress.XtraEditors.PictureEdit peUser;
        private DevExpress.XtraEditors.PictureEdit peOcultaMenu;
        private DevExpress.XtraEditors.PictureEdit peSalir;
        private DevExpress.XtraEditors.PictureEdit peRestart;
        private DevExpress.XtraEditors.PictureEdit peDeleteLog;
        private DevExpress.XtraEditors.PictureEdit peSyncTime;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.PictureEdit peCancelar;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Panel pnDatos;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.ComboBox cbPrivilege;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnbASU;
        private DevExpress.XtraEditors.PictureEdit peAceptarSet;
        private System.Windows.Forms.Panel pnAGU;
        private DevExpress.XtraEditors.PictureEdit peAceptarGet;
        private DevExpress.XtraEditors.PictureEdit peGetUser;
        private DevExpress.XtraEditors.PictureEdit peSetUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCardnumber;
        private System.Windows.Forms.Panel pnSyncTime;
        private System.Windows.Forms.DateTimePicker dtpTiempo;
        private System.Windows.Forms.Label lblSetTime;
        private DevExpress.XtraEditors.PictureEdit peSetTime;
        private System.Windows.Forms.Label lblGetTime;
        private DevExpress.XtraEditors.PictureEdit peGTime;
        private System.Windows.Forms.Label lbSyncTime;
        private DevExpress.XtraEditors.PictureEdit peSync;
        private System.Windows.Forms.Panel pnReinicio;
        private DevExpress.XtraEditors.PictureEdit peBorrarTodo;
        private DevExpress.XtraEditors.PictureEdit peOff;
        private DevExpress.XtraEditors.PictureEdit peReiniciar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMsj;

    }
}