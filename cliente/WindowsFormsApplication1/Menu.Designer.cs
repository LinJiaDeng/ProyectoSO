namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCréditos = new FontAwesome.Sharp.IconButton();
            this.btnInstrucciones = new FontAwesome.Sharp.IconButton();
            this.btnJugar = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarse = new FontAwesome.Sharp.IconButton();
            this.btnIniciarSesión = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.Windowed = new FontAwesome.Sharp.IconButton();
            this.Minimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iniciarsesion = new System.Windows.Forms.RadioButton();
            this.Registrarse = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.puntuaciontotal = new System.Windows.Forms.RadioButton();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.NumeroCartasMano = new System.Windows.Forms.RadioButton();
            this.enviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PuntuacionRonda = new System.Windows.Forms.RadioButton();
            this.nombre = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.btnCréditos);
            this.panelMenu.Controls.Add(this.btnInstrucciones);
            this.panelMenu.Controls.Add(this.btnJugar);
            this.panelMenu.Controls.Add(this.btnRegistrarse);
            this.panelMenu.Controls.Add(this.btnIniciarSesión);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(169, 500);
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
            this.btnJugar.Text = "Jugar";
            this.btnJugar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnRegistrarse.IconColor = System.Drawing.Color.White;
            this.btnRegistrarse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarse.IconSize = 45;
            this.btnRegistrarse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarse.Location = new System.Drawing.Point(0, 186);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnRegistrarse.Size = new System.Drawing.Size(169, 59);
            this.btnRegistrarse.TabIndex = 2;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnIniciarSesión
            // 
            this.btnIniciarSesión.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIniciarSesión.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesión.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesión.IconChar = FontAwesome.Sharp.IconChar.UserNinja;
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
            this.btnIniciarSesión.Text = "Iniciar Sesión";
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
            this.panelTitleBar.Controls.Add(this.Minimize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(169, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(873, 81);
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
            this.Windowed.Location = new System.Drawing.Point(801, 10);
            this.Windowed.Margin = new System.Windows.Forms.Padding(2);
            this.Windowed.Name = "Windowed";
            this.Windowed.Size = new System.Drawing.Size(29, 20);
            this.Windowed.TabIndex = 4;
            this.Windowed.UseVisualStyleBackColor = false;
            this.Windowed.Click += new System.EventHandler(this.Windowed_Click);
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
            this.Minimize.Location = new System.Drawing.Point(767, 10);
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
            this.btnExit.Location = new System.Drawing.Point(835, 9);
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
            this.lblTitleChildForm.Text = "Home";
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
            this.panelShadow.Size = new System.Drawing.Size(873, 8);
            this.panelShadow.TabIndex = 16;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Crimson;
            this.panelDesktop.Controls.Add(this.iniciarsesion);
            this.panelDesktop.Controls.Add(this.Registrarse);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.puntuaciontotal);
            this.panelDesktop.Controls.Add(this.contrasena);
            this.panelDesktop.Controls.Add(this.NumeroCartasMano);
            this.panelDesktop.Controls.Add(this.enviar);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.PuntuacionRonda);
            this.panelDesktop.Controls.Add(this.nombre);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(169, 89);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(873, 411);
            this.panelDesktop.TabIndex = 17;
            // 
            // iniciarsesion
            // 
            this.iniciarsesion.AutoSize = true;
            this.iniciarsesion.Location = new System.Drawing.Point(45, 141);
            this.iniciarsesion.Name = "iniciarsesion";
            this.iniciarsesion.Size = new System.Drawing.Size(86, 17);
            this.iniciarsesion.TabIndex = 24;
            this.iniciarsesion.TabStop = true;
            this.iniciarsesion.Text = "Iniciar sesion";
            this.iniciarsesion.UseVisualStyleBackColor = true;
            // 
            // Registrarse
            // 
            this.Registrarse.AutoSize = true;
            this.Registrarse.Location = new System.Drawing.Point(45, 118);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(153, 17);
            this.Registrarse.TabIndex = 23;
            this.Registrarse.TabStop = true;
            this.Registrarse.Text = "Selecciona para registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contraseña";
            // 
            // puntuaciontotal
            // 
            this.puntuaciontotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.puntuaciontotal.AutoSize = true;
            this.puntuaciontotal.Location = new System.Drawing.Point(501, 97);
            this.puntuaciontotal.Name = "puntuaciontotal";
            this.puntuaciontotal.Size = new System.Drawing.Size(196, 17);
            this.puntuaciontotal.TabIndex = 17;
            this.puntuaciontotal.TabStop = true;
            this.puntuaciontotal.Text = "Puntuación total al final de la partida";
            this.puntuaciontotal.UseVisualStyleBackColor = true;
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(109, 79);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(171, 20);
            this.contrasena.TabIndex = 21;
            // 
            // NumeroCartasMano
            // 
            this.NumeroCartasMano.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumeroCartasMano.AutoSize = true;
            this.NumeroCartasMano.Location = new System.Drawing.Point(501, 67);
            this.NumeroCartasMano.Name = "NumeroCartasMano";
            this.NumeroCartasMano.Size = new System.Drawing.Size(164, 17);
            this.NumeroCartasMano.TabIndex = 18;
            this.NumeroCartasMano.TabStop = true;
            this.NumeroCartasMano.Text = "Número de cartas en la mano";
            this.NumeroCartasMano.UseVisualStyleBackColor = true;
            // 
            // enviar
            // 
            this.enviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enviar.Location = new System.Drawing.Point(78, 332);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(104, 67);
            this.enviar.TabIndex = 16;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // PuntuacionRonda
            // 
            this.PuntuacionRonda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PuntuacionRonda.AutoSize = true;
            this.PuntuacionRonda.Location = new System.Drawing.Point(500, 43);
            this.PuntuacionRonda.Name = "PuntuacionRonda";
            this.PuntuacionRonda.Size = new System.Drawing.Size(130, 17);
            this.PuntuacionRonda.TabIndex = 20;
            this.PuntuacionRonda.TabStop = true;
            this.PuntuacionRonda.Text = "Puntos en cada ronda";
            this.PuntuacionRonda.UseVisualStyleBackColor = true;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(128, 42);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(164, 20);
            this.nombre.TabIndex = 14;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 500);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnCréditos;
        private FontAwesome.Sharp.IconButton btnInstrucciones;
        private FontAwesome.Sharp.IconButton btnJugar;
        private FontAwesome.Sharp.IconButton btnRegistrarse;
        private FontAwesome.Sharp.IconButton btnIniciarSesión;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.RadioButton iniciarsesion;
        private System.Windows.Forms.RadioButton Registrarse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton puntuaciontotal;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.RadioButton NumeroCartasMano;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton PuntuacionRonda;
        private System.Windows.Forms.TextBox nombre;
        private FontAwesome.Sharp.IconButton Windowed;
        private FontAwesome.Sharp.IconButton Minimize;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}

