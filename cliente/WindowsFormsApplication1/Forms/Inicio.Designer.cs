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
            this.components = new System.ComponentModel.Container();
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
            this.Minimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.ListaConectados = new System.Windows.Forms.DataGridView();
            this.desconectar = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectados)).BeginInit();
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
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(225, 615);
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
            this.btnCréditos.Location = new System.Drawing.Point(0, 448);
            this.btnCréditos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCréditos.Name = "btnCréditos";
            this.btnCréditos.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnCréditos.Size = new System.Drawing.Size(225, 73);
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
            this.btnInstrucciones.Location = new System.Drawing.Point(0, 375);
            this.btnInstrucciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnInstrucciones.Size = new System.Drawing.Size(225, 73);
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
            this.btnJugar.Location = new System.Drawing.Point(0, 302);
            this.btnJugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnJugar.Size = new System.Drawing.Size(225, 73);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "Jugar";
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
            this.btnPerfil.Location = new System.Drawing.Point(0, 229);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnPerfil.Size = new System.Drawing.Size(225, 73);
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
            this.btnIniciarSesión.Location = new System.Drawing.Point(0, 156);
            this.btnIniciarSesión.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarSesión.Name = "btnIniciarSesión";
            this.btnIniciarSesión.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnIniciarSesión.Size = new System.Drawing.Size(225, 73);
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
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 156);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::WindowsFormsApplication1.Properties.Resources.sushi_go_logo;
            this.btnHome.Location = new System.Drawing.Point(3, 2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(219, 148);
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
            this.panelTitleBar.Location = new System.Drawing.Point(225, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1164, 100);
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
            this.Windowed.Location = new System.Drawing.Point(1068, 12);
            this.Windowed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Windowed.Name = "Windowed";
            this.Windowed.Size = new System.Drawing.Size(39, 25);
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
            this.Minimize.Location = new System.Drawing.Point(1023, 12);
            this.Minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(39, 25);
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
            this.btnExit.Location = new System.Drawing.Point(1113, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 25);
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
            this.lblTitleChildForm.Location = new System.Drawing.Point(97, 41);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(333, 41);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 56;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(35, 32);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(56, 57);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.DarkRed;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(225, 100);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1164, 10);
            this.panelShadow.TabIndex = 16;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Crimson;
            this.panelDesktop.Controls.Add(this.ListaConectados);
            this.panelDesktop.Controls.Add(this.desconectar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(225, 110);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1164, 505);
            this.panelDesktop.TabIndex = 17;
            // 
            // ListaConectados
            // 
            this.ListaConectados.BackgroundColor = System.Drawing.Color.White;
            this.ListaConectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaConectados.Location = new System.Drawing.Point(747, 28);
            this.ListaConectados.Name = "ListaConectados";
            this.ListaConectados.ReadOnly = true;
            this.ListaConectados.RowHeadersWidth = 51;
            this.ListaConectados.RowTemplate.Height = 24;
            this.ListaConectados.Size = new System.Drawing.Size(384, 266);
            this.ListaConectados.TabIndex = 23;
            // 
            // desconectar
            // 
            this.desconectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.desconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desconectar.Location = new System.Drawing.Point(979, 410);
            this.desconectar.Margin = new System.Windows.Forms.Padding(4);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(173, 82);
            this.desconectar.TabIndex = 22;
            this.desconectar.Text = "desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 615);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectados)).EndInit();
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
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.DataGridView ListaConectados;
    }
}

