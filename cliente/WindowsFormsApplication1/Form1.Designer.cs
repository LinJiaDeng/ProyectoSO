namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.Conectar = new System.Windows.Forms.Button();
            this.enviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.NumeroCartasMano = new System.Windows.Forms.RadioButton();
            this.puntuaciontotal = new System.Windows.Forms.RadioButton();
            this.PuntuacionRonda = new System.Windows.Forms.RadioButton();
            this.desconectar = new System.Windows.Forms.Button();
            this.Registrarse = new System.Windows.Forms.RadioButton();
            this.iniciarsesion = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(157, 49);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(164, 20);
            this.nombre.TabIndex = 3;
            // 
            // Conectar
            // 
            this.Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conectar.Location = new System.Drawing.Point(208, 447);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(149, 53);
            this.Conectar.TabIndex = 4;
            this.Conectar.Text = "conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(38, 447);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(124, 53);
            this.enviar.TabIndex = 5;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña";
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(157, 88);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(164, 20);
            this.contraseña.TabIndex = 9;
            // 
            // NumeroCartasMano
            // 
            this.NumeroCartasMano.AutoSize = true;
            this.NumeroCartasMano.Location = new System.Drawing.Point(424, 160);
            this.NumeroCartasMano.Name = "NumeroCartasMano";
            this.NumeroCartasMano.Size = new System.Drawing.Size(164, 17);
            this.NumeroCartasMano.TabIndex = 7;
            this.NumeroCartasMano.TabStop = true;
            this.NumeroCartasMano.Text = "Número de cartas en la mano";
            this.NumeroCartasMano.UseVisualStyleBackColor = true;
            // 
            // puntuaciontotal
            // 
            this.puntuaciontotal.AutoSize = true;
            this.puntuaciontotal.Location = new System.Drawing.Point(424, 183);
            this.puntuaciontotal.Name = "puntuaciontotal";
            this.puntuaciontotal.Size = new System.Drawing.Size(196, 17);
            this.puntuaciontotal.TabIndex = 7;
            this.puntuaciontotal.TabStop = true;
            this.puntuaciontotal.Text = "Puntuación total al final de la partida";
            this.puntuaciontotal.UseVisualStyleBackColor = true;
            // 
            // PuntuacionRonda
            // 
            this.PuntuacionRonda.AutoSize = true;
            this.PuntuacionRonda.Location = new System.Drawing.Point(424, 137);
            this.PuntuacionRonda.Name = "PuntuacionRonda";
            this.PuntuacionRonda.Size = new System.Drawing.Size(130, 17);
            this.PuntuacionRonda.TabIndex = 8;
            this.PuntuacionRonda.TabStop = true;
            this.PuntuacionRonda.Text = "Puntos en cada ronda";
            this.PuntuacionRonda.UseVisualStyleBackColor = true;
            // 
            // desconectar
            // 
            this.desconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desconectar.Location = new System.Drawing.Point(394, 447);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(147, 53);
            this.desconectar.TabIndex = 10;
            this.desconectar.Text = "desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            // 
            // Registrarse
            // 
            this.Registrarse.AutoSize = true;
            this.Registrarse.Location = new System.Drawing.Point(157, 148);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(153, 17);
            this.Registrarse.TabIndex = 11;
            this.Registrarse.TabStop = true;
            this.Registrarse.Text = "Selecciona para registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            // 
            // iniciarsesion
            // 
            this.iniciarsesion.AutoSize = true;
            this.iniciarsesion.Location = new System.Drawing.Point(157, 183);
            this.iniciarsesion.Name = "iniciarsesion";
            this.iniciarsesion.Size = new System.Drawing.Size(168, 17);
            this.iniciarsesion.TabIndex = 12;
            this.iniciarsesion.TabStop = true;
            this.iniciarsesion.Text = "Selecciona para Iniciar Sesión";
            this.iniciarsesion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 563);
            this.Controls.Add(this.iniciarsesion);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.puntuaciontotal);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.NumeroCartasMano);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.PuntuacionRonda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.RadioButton NumeroCartasMano;
        private System.Windows.Forms.RadioButton PuntuacionRonda;
        private System.Windows.Forms.RadioButton puntuaciontotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.RadioButton Registrarse;
        private System.Windows.Forms.RadioButton iniciarsesion;
    }
}

