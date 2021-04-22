using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class Instrucciones : Form
    {
        public Instrucciones()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "Portada.jpg";
            pictureBox2.ImageLocation = "Instrucciones.jpg";

        }

    }
}
