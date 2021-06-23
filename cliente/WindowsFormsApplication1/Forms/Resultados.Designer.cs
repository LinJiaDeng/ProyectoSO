namespace WindowsFormsApplication1.Forms
{
    partial class Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            this.j1Lbl = new System.Windows.Forms.Label();
            this.j2Lbl = new System.Windows.Forms.Label();
            this.j3Lbl = new System.Windows.Forms.Label();
            this.j4Lbl = new System.Windows.Forms.Label();
            this.j5Lbl = new System.Windows.Forms.Label();
            this.podio = new System.Windows.Forms.PictureBox();
            this.ganadorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.podio)).BeginInit();
            this.SuspendLayout();
            // 
            // j1Lbl
            // 
            this.j1Lbl.AutoSize = true;
            this.j1Lbl.BackColor = System.Drawing.Color.White;
            this.j1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j1Lbl.Location = new System.Drawing.Point(12, 21);
            this.j1Lbl.Name = "j1Lbl";
            this.j1Lbl.Size = new System.Drawing.Size(51, 20);
            this.j1Lbl.TabIndex = 0;
            this.j1Lbl.Text = "label1";
            // 
            // j2Lbl
            // 
            this.j2Lbl.AutoSize = true;
            this.j2Lbl.BackColor = System.Drawing.Color.White;
            this.j2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j2Lbl.Location = new System.Drawing.Point(12, 51);
            this.j2Lbl.Name = "j2Lbl";
            this.j2Lbl.Size = new System.Drawing.Size(51, 20);
            this.j2Lbl.TabIndex = 1;
            this.j2Lbl.Text = "label2";
            // 
            // j3Lbl
            // 
            this.j3Lbl.AutoSize = true;
            this.j3Lbl.BackColor = System.Drawing.Color.White;
            this.j3Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j3Lbl.Location = new System.Drawing.Point(12, 83);
            this.j3Lbl.Name = "j3Lbl";
            this.j3Lbl.Size = new System.Drawing.Size(51, 20);
            this.j3Lbl.TabIndex = 2;
            this.j3Lbl.Text = "label3";
            this.j3Lbl.Visible = false;
            // 
            // j4Lbl
            // 
            this.j4Lbl.AutoSize = true;
            this.j4Lbl.BackColor = System.Drawing.Color.White;
            this.j4Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j4Lbl.Location = new System.Drawing.Point(12, 116);
            this.j4Lbl.Name = "j4Lbl";
            this.j4Lbl.Size = new System.Drawing.Size(51, 20);
            this.j4Lbl.TabIndex = 3;
            this.j4Lbl.Text = "label4";
            this.j4Lbl.Visible = false;
            // 
            // j5Lbl
            // 
            this.j5Lbl.AutoSize = true;
            this.j5Lbl.BackColor = System.Drawing.Color.White;
            this.j5Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j5Lbl.Location = new System.Drawing.Point(12, 147);
            this.j5Lbl.Name = "j5Lbl";
            this.j5Lbl.Size = new System.Drawing.Size(51, 20);
            this.j5Lbl.TabIndex = 4;
            this.j5Lbl.Text = "label5";
            this.j5Lbl.Visible = false;
            // 
            // podio
            // 
            this.podio.BackColor = System.Drawing.Color.Transparent;
            this.podio.Image = ((System.Drawing.Image)(resources.GetObject("podio.Image")));
            this.podio.Location = new System.Drawing.Point(172, 220);
            this.podio.Name = "podio";
            this.podio.Size = new System.Drawing.Size(160, 97);
            this.podio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.podio.TabIndex = 6;
            this.podio.TabStop = false;
            // 
            // ganadorLbl
            // 
            this.ganadorLbl.AutoSize = true;
            this.ganadorLbl.BackColor = System.Drawing.Color.Goldenrod;
            this.ganadorLbl.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ganadorLbl.Location = new System.Drawing.Point(215, 220);
            this.ganadorLbl.Name = "ganadorLbl";
            this.ganadorLbl.Size = new System.Drawing.Size(71, 16);
            this.ganadorLbl.TabIndex = 7;
            this.ganadorLbl.Text = "ganador";
            this.ganadorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(439, 329);
            this.Controls.Add(this.ganadorLbl);
            this.Controls.Add(this.podio);
            this.Controls.Add(this.j5Lbl);
            this.Controls.Add(this.j4Lbl);
            this.Controls.Add(this.j3Lbl);
            this.Controls.Add(this.j2Lbl);
            this.Controls.Add(this.j1Lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.podio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label j1Lbl;
        private System.Windows.Forms.Label j2Lbl;
        private System.Windows.Forms.Label j3Lbl;
        private System.Windows.Forms.Label j4Lbl;
        private System.Windows.Forms.Label j5Lbl;
        private System.Windows.Forms.PictureBox podio;
        private System.Windows.Forms.Label ganadorLbl;
    }
}