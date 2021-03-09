using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roasting_Steganography
{
    public partial class Splash : Form
    {
        int progress = 0;
        public Splash()
        {
            InitializeComponent();
            ProgressBar1.ForeColor = Color.Blue;
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 50;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.ForeColor = Color.Blue;
            progress += 5;
            if (progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
            ProgressBar1.Value = progress;
        }
    }
}