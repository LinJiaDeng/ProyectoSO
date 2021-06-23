
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugar));
            this.Barajar = new FontAwesome.Sharp.IconButton();
            this.Carta4 = new System.Windows.Forms.PictureBox();
            this.Carta1 = new System.Windows.Forms.PictureBox();
            this.Carta2 = new System.Windows.Forms.PictureBox();
            this.Carta3 = new System.Windows.Forms.PictureBox();
            this.Carta5 = new System.Windows.Forms.PictureBox();
            this.Carta6 = new System.Windows.Forms.PictureBox();
            this.Repartir = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Carta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Barajar
            // 
            this.Barajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barajar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barajar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Barajar.IconColor = System.Drawing.Color.Black;
            this.Barajar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Barajar.Location = new System.Drawing.Point(601, 39);
            this.Barajar.Name = "Barajar";
            this.Barajar.Size = new System.Drawing.Size(188, 66);
            this.Barajar.TabIndex = 0;
            this.Barajar.Text = "BARAJAR";
            this.Barajar.UseVisualStyleBackColor = true;
            this.Barajar.Click += new System.EventHandler(this.Barajar_Click);
            // 
            // Carta4
            // 
            this.Carta4.Location = new System.Drawing.Point(591, 111);
            this.Carta4.Name = "Carta4";
            this.Carta4.Size = new System.Drawing.Size(116, 198);
            this.Carta4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Carta4.TabIndex = 1;
            this.Carta4.TabStop = false;
            // 
            // Carta1
            // 
            this.Carta1.BackColor = System.Drawing.Color.Transparent;
            this.Carta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Carta1.Location = new System.Drawing.Point(837, 315);
            this.Carta1.Name = "Carta1";
            this.Carta1.Size = new System.Drawing.Size(116, 198);
            this.Carta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Carta1.TabIndex = 2;
            this.Carta1.TabStop = false;
            // 
            // Carta2
            // 
            this.Carta2.Location = new System.Drawing.Point(713, 315);
            this.Carta2.Name = "Carta2";
            this.Carta2.Size = new System.Drawing.Size(116, 198);
            this.Carta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Carta2.TabIndex = 3;
            this.Carta2.TabStop = false;
            // 
            // Carta3
            // 
            this.Carta3.Location = new System.Drawing.Point(591, 315);
            this.Carta3.Name = "Carta3";
            this.Carta3.Size = new System.Drawing.Size(116, 198);
            this.Carta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Carta3.TabIndex = 4;
            this.Carta3.TabStop = false;
            // 
            // Carta5
            // 
            this.Carta5.Location = new System.Drawing.Point(713, 111);
            this.Carta5.Name = "Carta5";
            this.Carta5.Size = new System.Drawing.Size(116, 198);
            this.Carta5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Carta5.TabIndex = 5;
            this.Carta5.TabStop = false;
            // 
            // Carta6
            // 
            this.Carta6.Location = new System.Drawing.Point(837, 111);
            this.Carta6.Name = "Carta6";
            this.Carta6.Size = new System.Drawing.Size(116, 198);
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
            this.Repartir.Location = new System.Drawing.Point(837, 58);
            this.Repartir.Name = "Repartir";
            this.Repartir.Size = new System.Drawing.Size(138, 47);
            this.Repartir.TabIndex = 7;
            this.Repartir.Text = "REPARTIR";
            this.Repartir.UseVisualStyleBackColor = true;
            this.Repartir.Click += new System.EventHandler(this.Repartir_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Crimson;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(40, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 72);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Aquí tienes un resumen de las instrucciones, click a la derecha si quieres ver la" +
    "s instrucciones detalladas. Y a la derecha tienes un ejemplo de mano que te podr" +
    "ía tocar.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Crimson;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(616, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 21);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Simulación de lo que te podría tocar en una mano!";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(352, 39);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(212, 66);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.Text = "INSTRUCCIONES DETALLADAS";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(282, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 393);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1006, 579);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Repartir);
            this.Controls.Add(this.Carta6);
            this.Controls.Add(this.Carta5);
            this.Controls.Add(this.Carta3);
            this.Controls.Add(this.Carta2);
            this.Controls.Add(this.Carta1);
            this.Controls.Add(this.Carta4);
            this.Controls.Add(this.Barajar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Jugar";
            this.Text = "Jugar";
            this.Load += new System.EventHandler(this.Jugar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Carta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}