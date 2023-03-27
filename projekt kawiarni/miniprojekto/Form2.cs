using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniprojekto
{
    public partial class Form2 : Form
    {
        double kwotaDoZaplaty;
        public Form2(double kwotaDoZaplaty)
        {
            InitializeComponent();
            progressBar1.Visible = false;
            this.kwotaDoZaplaty = kwotaDoZaplaty;
            this.label1.Text = String.Format("Kwota do zaplaty: {0}", kwotaDoZaplaty);
            this.kwotaDoZaplaty = kwotaDoZaplaty;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            for (int i = 0; i < 100; i += 10)
            {
                progressBar1.Value = i;
                Thread.Sleep(200);
            }

            this.Close();
        }
    }
}
