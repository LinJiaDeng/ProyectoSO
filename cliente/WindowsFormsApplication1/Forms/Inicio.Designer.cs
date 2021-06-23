namespace WindowsFormsApplication1
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCréditos = new FontAwesome.Sharp.IconButton();
            this.btnInstrucciones = new FontAwesome.Sharp.IconButton();
            this.btnJugar = new FontAwesome.Sharp.IconButton();
            this.btnPerfil = new FontAwesome.Sharp.IconButton();
            this.btnIniciarSesión = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.Windowed = new FontAwesome.Sharp.IconButton();
            this.lblconexion = new System.Windows.Forms.Label();
            this.Minimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.peticion2Lbl = new System.Windows.Forms.Label();
            this.peticion1Lbl = new System.Windows.Forms.Label();
            this.darseDeBajaBtn = new System.Windows.Forms.Button();
            this.nombrePerfilLbl = new System.Windows.Forms.Label();
            this.invitarbtn = new System.Windows.Forms.Button();
            this.Desconectarbtn = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.ListaConectados = new System.Windows.Forms.DataGridView();
            this.Conectados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sushi = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sushi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.btnCréditos);
            this.panelMenu.Controls.Add(this.btnInstrucciones);
            this.panelMenu.Controls.Add(this.btnJugar);
            this.panelMenu.Controls.Add(this.btnPerfil);
            this.panelMenu.Controls.Add(this.btnIniciarSesión);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(169, 597);
            this.panelMenu.TabIndex = 14;
            // 
            // btnCréditos
            // 
            this.btnCréditos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCréditos.FlatAppearance.BorderSize = 0;
            this.btnCréditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCréditos.ForeColor = System.Drawing.Color.White;
            this.btnCréditos.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.btnCréditos.IconColor = System.Drawing.Color.White;
            this.btnCréditos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCréditos.IconSize = 45;
            this.btnCréditos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCréditos.Location = new System.Drawing.Point(0, 363);
            this.btnCréditos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCréditos.Name = "btnCréditos";
            this.btnCréditos.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnCréditos.Size = new System.Drawing.Size(169, 59);
            this.btnCréditos.TabIndex = 5;
            this.btnCréditos.Text = "Créditos";
            this.btnCréditos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCréditos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCréditos.UseVisualStyleBackColor = true;
            this.btnCréditos.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInstrucciones.FlatAppearance.BorderSize = 0;
            this.btnInstrucciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstrucciones.ForeColor = System.Drawing.Color.White;
            this.btnInstrucciones.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnInstrucciones.IconColor = System.Drawing.Color.White;
            this.btnInstrucciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInstrucciones.IconSize = 45;
            this.btnInstrucciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstrucciones.Location = new System.Drawing.Point(0, 304);
            this.btnInstrucciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnInstrucciones.Size = new System.Drawing.Size(169, 59);
            this.btnInstrucciones.TabIndex = 4;
            this.btnInstrucciones.Text = "Instrucciones";
            this.btnInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstrucciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInstrucciones.UseVisualStyleBackColor = true;
            this.btnInstrucciones.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJugar.FlatAppearance.BorderSize = 0;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.ForeColor = System.Drawing.Color.White;
            this.btnJugar.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnJugar.IconColor = System.Drawing.Color.White;
            this.btnJugar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJugar.IconSize = 45;
            this.btnJugar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugar.Location = new System.Drawing.Point(0, 245);
            this.btnJugar.Margin = new System.Windows.Forms.Padding(2);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnJugar.Size = new System.Drawing.Size(169, 59);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "Demo";
            this.btnJugar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnPerfil.IconColor = System.Drawing.Color.White;
            this.btnPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPerfil.IconSize = 45;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(0, 186);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnPerfil.Size = new System.Drawing.Size(169, 59);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnIniciarSesión
            // 
            this.btnIniciarSesión.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIniciarSesión.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesión.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesión.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnIniciarSesión.IconColor = System.Drawing.Color.White;
            this.btnIniciarSesión.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciarSesión.IconSize = 45;
            this.btnIniciarSesión.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesión.Location = new System.Drawing.Point(0, 127);
            this.btnIniciarSesión.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarSesión.Name = "btnIniciarSesión";
            this.btnIniciarSesión.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnIniciarSesión.Size = new System.Drawing.Size(169, 59);
            this.btnIniciarSesión.TabIndex = 1;
            this.btnIniciarSesión.Text = "Iniciar Sesión/  Registrarse";
            this.btnIniciarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesión.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciarSesión.UseVisualStyleBackColor = true;
            this.btnIniciarSesión.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(169, 127);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::WindowsFormsApplication1.Properties.Resources.sushi_go_logo;
            this.btnHome.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnHome.InitialImage")));
            this.btnHome.Location = new System.Drawing.Point(2, 2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(164, 120);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.Windowed);
            this.panelTitleBar.Controls.Add(this.lblconexion);
            this.panelTitleBar.Controls.Add(this.Minimize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(169, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1113, 81);
            this.panelTitleBar.TabIndex = 15;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // Windowed
            // 
            this.Windowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Windowed.BackColor = System.Drawing.Color.Black;
            this.Windowed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Windowed.ForeColor = System.Drawing.Color.White;
            this.Windowed.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.Windowed.IconColor = System.Drawing.Color.White;
            this.Windowed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Windowed.IconSize = 20;
            this.Windowed.Location = new System.Drawing.Point(1041, 10);
            this.Windowed.Margin = new System.Windows.Forms.Padding(2);
            this.Windowed.Name = "Windowed";
            this.Windowed.Size = new System.Drawing.Size(29, 20);
            this.Windowed.TabIndex = 4;
            this.Windowed.UseVisualStyleBackColor = false;
            this.Windowed.Click += new System.EventHandler(this.Windowed_Click);
            // 
            // lblconexion
            // 
            this.lblconexion.AutoSize = true;
            this.lblconexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconexion.ForeColor = System.Drawing.Color.Black;
            this.lblconexion.Location = new System.Drawing.Point(840, 26);
            this.lblconexion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblconexion.Name = "lblconexion";
            this.lblconexion.Size = new System.Drawing.Size(146, 31);
            this.lblconexion.TabIndex = 5;
            this.lblconexion.Text = "Conectado";
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Black;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Minimize.IconColor = System.Drawing.Color.White;
            this.Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimize.Location = new System.Drawing.Point(1007, 10);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(29, 20);
            this.Minimize.TabIndex = 3;
            this.Minimize.Text = "_";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(1075, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 20);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(73, 33);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(250, 33);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 42;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(26, 26);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(42, 46);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.DarkRed;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(169, 81);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(2);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1113, 8);
            this.panelShadow.TabIndex = 16;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Crimson;
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktop.Controls.Add(this.sushi);
            this.panelDesktop.Controls.Add(this.peticion2Lbl);
            this.panelDesktop.Controls.Add(this.peticion1Lbl);
            this.panelDesktop.Controls.Add(this.darseDeBajaBtn);
            this.panelDesktop.Controls.Add(this.nombrePerfilLbl);
            this.panelDesktop.Controls.Add(this.invitarbtn);
            this.panelDesktop.Controls.Add(this.Desconectarbtn);
            this.panelDesktop.Controls.Add(this.btnRegistrarse);
            this.panelDesktop.Controls.Add(this.btnIniciarSesion);
            this.panelDesktop.Controls.Add(this.lblContrasena);
            this.panelDesktop.Controls.Add(this.lblName);
            this.panelDesktop.Controls.Add(this.txtcontrasena);
            this.panelDesktop.Controls.Add(this.txtnombre);
            this.panelDesktop.Controls.Add(this.ListaConectados);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(169, 89);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1113, 508);
            this.panelDesktop.TabIndex = 26;
            // 
            // peticion2Lbl
            // 
            this.peticion2Lbl.AutoSize = true;
            this.peticion2Lbl.Font = new System.Drawing.Font("Agency FB", 38F, System.Drawing.FontStyle.Bold);
            this.peticion2Lbl.Location = new System.Drawing.Point(213, 168);
            this.peticion2Lbl.Name = "peticion2Lbl";
            this.peticion2Lbl.Size = new System.Drawing.Size(189, 62);
            this.peticion2Lbl.TabIndex = 39;
            this.peticion2Lbl.Text = "peticion2";
            this.peticion2Lbl.Visible = false;
            // 
            // peticion1Lbl
            // 
            this.peticion1Lbl.AutoSize = true;
            this.peticion1Lbl.Font = new System.Drawing.Font("Agency FB", 38F, System.Drawing.FontStyle.Bold);
            this.peticion1Lbl.Location = new System.Drawing.Point(213, 84);
            this.peticion1Lbl.Name = "peticion1Lbl";
            this.peticion1Lbl.Size = new System.Drawing.Size(165, 62);
            this.peticion1Lbl.TabIndex = 38;
            this.peticion1Lbl.Text = "peticion";
            this.peticion1Lbl.Visible = false;
            // 
            // darseDeBajaBtn
            // 
            this.darseDeBajaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.darseDeBajaBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.darseDeBajaBtn.Enabled = false;
            this.darseDeBajaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.darseDeBajaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darseDeBajaBtn.Location = new System.Drawing.Point(3, 247);
            this.darseDeBajaBtn.Name = "darseDeBajaBtn";
            this.darseDeBajaBtn.Size = new System.Drawing.Size(170, 66);
            this.darseDeBajaBtn.TabIndex = 37;
            this.darseDeBajaBtn.Text = "Darse de baja";
            this.darseDeBajaBtn.UseVisualStyleBackColor = false;
            this.darseDeBajaBtn.Visible = false;
            this.darseDeBajaBtn.Click += new System.EventHandler(this.darseDeBajaBtn_Click);
            // 
            // nombrePerfilLbl
            // 
            this.nombrePerfilLbl.AutoSize = true;
            this.nombrePerfilLbl.Enabled = false;
            this.nombrePerfilLbl.Font = new System.Drawing.Font("Agency FB", 38F, System.Drawing.FontStyle.Bold);
            this.nombrePerfilLbl.Location = new System.Drawing.Point(14, 2);
            this.nombrePerfilLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombrePerfilLbl.Name = "nombrePerfilLbl";
            this.nombrePerfilLbl.Size = new System.Drawing.Size(166, 62);
            this.nombrePerfilLbl.TabIndex = 36;
            this.nombrePerfilLbl.Text = "Nombre";
            this.nombrePerfilLbl.Visible = false;
            // 
            // invitarbtn
            // 
            this.invitarbtn.Enabled = false;
            this.invitarbtn.Location = new System.Drawing.Point(884, 462);
            this.invitarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.invitarbtn.Name = "invitarbtn";
            this.invitarbtn.Size = new System.Drawing.Size(107, 36);
            this.invitarbtn.TabIndex = 35;
            this.invitarbtn.Text = "Invitar";
            this.invitarbtn.UseVisualStyleBackColor = true;
            this.invitarbtn.Visible = false;
            this.invitarbtn.Click += new System.EventHandler(this.invitarbtn_Click);
            // 
            // Desconectarbtn
            // 
            this.Desconectarbtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Desconectarbtn.Enabled = false;
            this.Desconectarbtn.Location = new System.Drawing.Point(13, 462);
            this.Desconectarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Desconectarbtn.Name = "Desconectarbtn";
            this.Desconectarbtn.Size = new System.Drawing.Size(170, 37);
            this.Desconectarbtn.TabIndex = 30;
            this.Desconectarbtn.Text = "Desconectar";
            this.Desconectarbtn.UseVisualStyleBackColor = false;
            this.Desconectarbtn.Visible = false;
            this.Desconectarbtn.Click += new System.EventHandler(this.Desconectarbtn_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarse.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRegistrarse.Enabled = false;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(3, 202);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(170, 38);
            this.btnRegistrarse.TabIndex = 29;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Visible = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.PeachPuff;
            this.btnIniciarSesion.Enabled = false;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(3, 154);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(170, 40);
            this.btnIniciarSesion.TabIndex = 28;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Visible = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Enabled = false;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(16, 84);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(124, 25);
            this.lblContrasena.TabIndex = 27;
            this.lblContrasena.Text = "Contraseña";
            this.lblContrasena.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Enabled = false;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(16, 13);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 25);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Nombre";
            this.lblName.Visible = false;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Enabled = false;
            this.txtcontrasena.Location = new System.Drawing.Point(20, 110);
            this.txtcontrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(144, 20);
            this.txtcontrasena.TabIndex = 25;
            this.txtcontrasena.Visible = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(20, 39);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(144, 20);
            this.txtnombre.TabIndex = 24;
            this.txtnombre.Visible = false;
            // 
            // ListaConectados
            // 
            this.ListaConectados.AllowUserToAddRows = false;
            this.ListaConectados.AllowUserToDeleteRows = false;
            this.ListaConectados.AllowUserToResizeColumns = false;
            this.ListaConectados.AllowUserToResizeRows = false;
            this.ListaConectados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaConectados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListaConectados.BackgroundColor = System.Drawing.Color.LightGreen;
            this.ListaConectados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaConectados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ListaConectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaConectados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Conectados});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaConectados.DefaultCellStyle = dataGridViewCellStyle1;
            this.ListaConectados.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListaConectados.GridColor = System.Drawing.Color.Crimson;
            this.ListaConectados.Location = new System.Drawing.Point(1005, 0);
            this.ListaConectados.Margin = new System.Windows.Forms.Padding(2);
            this.ListaConectados.Name = "ListaConectados";
            this.ListaConectados.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaConectados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListaConectados.RowHeadersVisible = false;
            this.ListaConectados.RowHeadersWidth = 90;
            this.ListaConectados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListaConectados.RowTemplate.Height = 24;
            this.ListaConectados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ListaConectados.ShowCellErrors = false;
            this.ListaConectados.ShowCellToolTips = false;
            this.ListaConectados.ShowEditingIcon = false;
            this.ListaConectados.ShowRowErrors = false;
            this.ListaConectados.Size = new System.Drawing.Size(106, 506);
            this.ListaConectados.TabIndex = 23;
            this.ListaConectados.Visible = false;
            // 
            // Conectados
            // 
            this.Conectados.HeaderText = "Conectados";
            this.Conectados.MinimumWidth = 6;
            this.Conectados.Name = "Conectados";
            this.Conectados.ReadOnly = true;
            // 
            // sushi
            // 
            this.sushi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sushi.Image = ((System.Drawing.Image)(resources.GetObject("sushi.Image")));
            this.sushi.InitialImage = ((System.Drawing.Image)(resources.GetObject("sushi.InitialImage")));
            this.sushi.Location = new System.Drawing.Point(286, 13);
            this.sushi.Name = "sushi";
            this.sushi.Size = new System.Drawing.Size(496, 439);
            this.sushi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sushi.TabIndex = 40;
            this.sushi.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 597);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sushi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnCréditos;
        private FontAwesome.Sharp.IconButton btnInstrucciones;
        private FontAwesome.Sharp.IconButton btnJugar;
        private FontAwesome.Sharp.IconButton btnPerfil;
        private FontAwesome.Sharp.IconButton btnIniciarSesión;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton Windowed;
        private FontAwesome.Sharp.IconButton Minimize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.DataGridView ListaConectados;
        private System.Windows.Forms.Button Desconectarbtn;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtcontrasena;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblconexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conectados;
        private System.Windows.Forms.Button invitarbtn;
        private System.Windows.Forms.Label nombrePerfilLbl;
        private System.Windows.Forms.Button darseDeBajaBtn;
        private System.Windows.Forms.Label peticion1Lbl;
        private System.Windows.Forms.Label peticion2Lbl;
        private System.Windows.Forms.PictureBox sushi;
    }
}

