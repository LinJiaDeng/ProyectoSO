
namespace WindowsFormsApplication1
{
    partial class Invitacion
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
            this.aceptarbtn = new System.Windows.Forms.Button();
            this.rechazarbtn = new System.Windows.Forms.Button();
            this.lblinvitacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aceptarbtn
            // 
            this.aceptarbtn.Location = new System.Drawing.Point(45, 91);
            this.aceptarbtn.Name = "aceptarbtn";
            this.aceptarbtn.Size = new System.Drawing.Size(85, 27);
            this.aceptarbtn.TabIndex = 0;
            this.aceptarbtn.Text = "Aceptar";
            this.aceptarbtn.UseVisualStyleBackColor = true;
            this.aceptarbtn.Click += new System.EventHandler(this.aceptarbtn_Click);
            // 
            // rechazarbtn
            // 
            this.rechazarbtn.Location = new System.Drawing.Point(169, 91);
            this.rechazarbtn.Name = "rechazarbtn";
            this.rechazarbtn.Size = new System.Drawing.Size(85, 27);
            this.rechazarbtn.TabIndex = 1;
            this.rechazarbtn.Text = "Rechazar";
            this.rechazarbtn.UseVisualStyleBackColor = true;
            this.rechazarbtn.Click += new System.EventHandler(this.rechazarbtn_Click);
            // 
            // lblinvitacion
            // 
            this.lblinvitacion.AutoSize = true;
            this.lblinvitacion.Location = new System.Drawing.Point(42, 36);
            this.lblinvitacion.Name = "lblinvitacion";
            this.lblinvitacion.Size = new System.Drawing.Size(0, 17);
            this.lblinvitacion.TabIndex = 2;
            // 
            // Invitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 133);
            this.Controls.Add(this.lblinvitacion);
            this.Controls.Add(this.rechazarbtn);
            this.Controls.Add(this.aceptarbtn);
            this.Name = "Invitacion";
            this.Text = "Invitacion";
            this.Load += new System.EventHandler(this.Invitacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptarbtn;
        private System.Windows.Forms.Button rechazarbtn;
        private System.Windows.Forms.Label lblinvitacion;
    }
}