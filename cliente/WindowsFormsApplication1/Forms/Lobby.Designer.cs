
namespace WindowsFormsApplication1
{
    partial class Lobby
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enviarBtn = new System.Windows.Forms.Button();
            this.partidaIdLbl = new System.Windows.Forms.Label();
            this.chatLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 476);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 36);
            this.textBox1.TabIndex = 1;
            // 
            // enviarBtn
            // 
            this.enviarBtn.Location = new System.Drawing.Point(180, 476);
            this.enviarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.enviarBtn.Name = "enviarBtn";
            this.enviarBtn.Size = new System.Drawing.Size(51, 36);
            this.enviarBtn.TabIndex = 3;
            this.enviarBtn.Text = "Enviar";
            this.enviarBtn.UseVisualStyleBackColor = true;
            this.enviarBtn.Click += new System.EventHandler(this.enviarBtn_Click);
            // 
            // partidaIdLbl
            // 
            this.partidaIdLbl.AutoSize = true;
            this.partidaIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partidaIdLbl.Location = new System.Drawing.Point(385, 7);
            this.partidaIdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partidaIdLbl.Name = "partidaIdLbl";
            this.partidaIdLbl.Size = new System.Drawing.Size(80, 17);
            this.partidaIdLbl.TabIndex = 4;
            this.partidaIdLbl.Text = "ID Partida";
            // 
            // chatLbl
            // 
            this.chatLbl.Location = new System.Drawing.Point(3, 0);
            this.chatLbl.Name = "chatLbl";
            this.chatLbl.Size = new System.Drawing.Size(227, 474);
            this.chatLbl.TabIndex = 5;
            this.chatLbl.Text = "chat";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enviarBtn);
            this.panel1.Controls.Add(this.chatLbl);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(801, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 523);
            this.panel1.TabIndex = 6;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1034, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.partidaIdLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button enviarBtn;
        private System.Windows.Forms.Label partidaIdLbl;
        private System.Windows.Forms.Label chatLbl;
        private System.Windows.Forms.Panel panel1;
    }
}