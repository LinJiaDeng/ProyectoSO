
namespace WindowsFormsApplication1.Forms
{
    partial class Perfil
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
            this.puntuaciontotal = new System.Windows.Forms.RadioButton();
            this.NumeroCartasMano = new System.Windows.Forms.RadioButton();
            this.PuntuacionRonda = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // puntuaciontotal
            // 
            this.puntuaciontotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.puntuaciontotal.AutoSize = true;
            this.puntuaciontotal.Location = new System.Drawing.Point(49, 121);
            this.puntuaciontotal.Margin = new System.Windows.Forms.Padding(4);
            this.puntuaciontotal.Name = "puntuaciontotal";
            this.puntuaciontotal.Size = new System.Drawing.Size(259, 21);
            this.puntuaciontotal.TabIndex = 21;
            this.puntuaciontotal.TabStop = true;
            this.puntuaciontotal.Text = "Puntuación total al final de la partida";
            this.puntuaciontotal.UseVisualStyleBackColor = true;
            // 
            // NumeroCartasMano
            // 
            this.NumeroCartasMano.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumeroCartasMano.AutoSize = true;
            this.NumeroCartasMano.Location = new System.Drawing.Point(50, 84);
            this.NumeroCartasMano.Margin = new System.Windows.Forms.Padding(4);
            this.NumeroCartasMano.Name = "NumeroCartasMano";
            this.NumeroCartasMano.Size = new System.Drawing.Size(216, 21);
            this.NumeroCartasMano.TabIndex = 22;
            this.NumeroCartasMano.TabStop = true;
            this.NumeroCartasMano.Text = "Número de cartas en la mano";
            this.NumeroCartasMano.UseVisualStyleBackColor = true;
            // 
            // PuntuacionRonda
            // 
            this.PuntuacionRonda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PuntuacionRonda.AutoSize = true;
            this.PuntuacionRonda.Location = new System.Drawing.Point(50, 55);
            this.PuntuacionRonda.Margin = new System.Windows.Forms.Padding(4);
            this.PuntuacionRonda.Name = "PuntuacionRonda";
            this.PuntuacionRonda.Size = new System.Drawing.Size(169, 21);
            this.PuntuacionRonda.TabIndex = 23;
            this.PuntuacionRonda.TabStop = true;
            this.PuntuacionRonda.Text = "Puntos en cada ronda";
            this.PuntuacionRonda.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Location = new System.Drawing.Point(49, 313);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(186, 70);
            this.btnEnviar.TabIndex = 24;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.puntuaciontotal);
            this.Controls.Add(this.NumeroCartasMano);
            this.Controls.Add(this.PuntuacionRonda);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton puntuaciontotal;
        private System.Windows.Forms.RadioButton NumeroCartasMano;
        private System.Windows.Forms.RadioButton PuntuacionRonda;
        private System.Windows.Forms.Button btnEnviar;
    }
}