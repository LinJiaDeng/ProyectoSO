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
            carta1.ImageLocation = "Nigiri1.jpg";
            carta2.ImageLocation = "Maki1.jpg";
            carta3.ImageLocation = "Tempura.jpg";
            carta4.ImageLocation = "Pudin.jpg";
            carta5.ImageLocation = "Wasabi.jpg";
            carta6.ImageLocation = "Gyoza.jpg";
            carta7.ImageLocation = "Sashimi.jpg";
            carta8.ImageLocation = "Tofu.jpg";
        }

    }
}
