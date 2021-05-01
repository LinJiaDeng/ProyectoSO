
namespace WindowsFormsApplication1.Forms
{
    partial class Jugar
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
            this.Barajar = new FontAwesome.Sharp.IconButton();
            this.Carta4 = new System.Windows.Forms.PictureBox();
            this.Carta1 = new System.Windows.Forms.PictureBox();
            this.Carta2 = new System.Windows.Forms.PictureBox();
            this.Carta3 = new System.Windows.Forms.PictureBox();
            this.Carta5 = new System.Windows.Forms.PictureBox();
            this.Carta6 = new System.Windows.Forms.PictureBox();
            this.Repartir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Carta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta6)).BeginInit();
            this.SuspendLayout();
            // 
            // Barajar
            // 
            this.Barajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barajar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barajar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Barajar.IconColor = System.Drawing.Color.Black;
            this.Barajar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Barajar.Location = new System.Drawing.Point(277, 48);
            this.Barajar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Barajar.Name = "Barajar";
            this.Barajar.Size = new System.Drawing.Size(251, 81);
            this.Barajar.TabIndex = 0;
            this.Barajar.Text = "BARAJAR";
            this.Barajar.UseVisualStyleBackColor = true;
            this.Barajar.Click += new System.EventHandler(this.Barajar_Click);
            // 
            // Carta4
            // 
            this.Carta4.Location = new System.Drawing.Point(581, 229);
            this.Carta4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Carta4.Name = "Carta4";
            this.Carta4.Size = new System.Drawing.Size(171, 262);
            this.Carta4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Carta4.TabIndex = 1;
            this.Carta4.TabStop = false;
            // 
            // Carta1
            // 
            this.Carta1.BackColor = System.Drawing.Color.Transparent;
            this.Carta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Carta1.Location = new System.Drawing.Point(48, 229);
            this.Carta1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Carta1.Name = "Carta1";
            this.Carta1.Size = new System.Drawing.Size(171, 262);
            this.Carta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Carta1.TabIndex = 2;
            this.Carta1.TabStop = false;
            // 
            // Carta2
            // 
            this.Carta2.Location = new System.Drawing.Point(227, 229);
            this.Carta2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Carta2.Name = "Carta2";
            this.Carta2.Size = new System.Drawing.Size(171, 262);
            this.Carta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Carta2.TabIndex = 3;
            this.Carta2.TabStop = false;
            // 
            // Carta3
            // 
            this.Carta3.Location = new System.Drawing.Point(403, 229);
            this.Carta3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Carta3.Name = "Carta3";
            this.Carta3.Size = new System.Drawing.Size(171, 262);
            this.Carta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Carta3.TabIndex = 4;
            this.Carta3.TabStop = false;
            // 
            // Carta5
            // 
            this.Carta5.Location = new System.Drawing.Point(760, 229);
            this.Carta5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Carta5.Name = "Carta5";
            this.Carta5.Size = new System.Drawing.Size(171, 262);
            this.Carta5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Carta5.TabIndex = 5;
            this.Carta5.TabStop = false;
            // 
            // Carta6
            // 
            this.Carta6.Location = new System.Drawing.Point(939, 229);
            this.Carta6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Carta6.Name = "Carta6";
            this.Carta6.Size = new System.Drawing.Size(171, 262);
            this.Carta6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Carta6.TabIndex = 6;
            this.Carta6.TabStop = false;
            // 
            // Repartir
            // 
            this.Repartir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repartir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repartir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Repartir.IconColor = System.Drawing.Color.Black;
            this.Repartir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Repartir.Location = new System.Drawing.Point(568, 60);
            this.Repartir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Repartir.Name = "Repartir";
            this.Repartir.Size = new System.Drawing.Size(184, 58);
            this.Repartir.TabIndex = 7;
            this.Repartir.Text = "REPARTIR";
            this.Repartir.UseVisualStyleBackColor = true;
            this.Repartir.Click += new System.EventHandler(this.Repartir_Click);
            // 
            // Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1316, 690);
            this.Controls.Add(this.Repartir);
            this.Controls.Add(this.Carta6);
            this.Controls.Add(this.Carta5);
            this.Controls.Add(this.Carta3);
            this.Controls.Add(this.Carta2);
            this.Controls.Add(this.Carta1);
            this.Controls.Add(this.Carta4);
            this.Controls.Add(this.Barajar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Jugar";
            this.Text = "Jugar";
            this.Load += new System.EventHandler(this.Jugar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Carta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Barajar;
        private System.Windows.Forms.PictureBox Carta4;
        private System.Windows.Forms.PictureBox Carta1;
        private System.Windows.Forms.PictureBox Carta2;
        private System.Windows.Forms.PictureBox Carta3;
        private System.Windows.Forms.PictureBox Carta5;
        private System.Windows.Forms.PictureBox Carta6;
        private FontAwesome.Sharp.IconButton Repartir;
    }
}