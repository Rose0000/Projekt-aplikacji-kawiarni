using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniprojekto
{
    public partial class Form3 : Form
    {
        Form1 parentForm;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.Name = "Napiwek";
            parentForm = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double napiwek = 0.1 * parentForm.rachunek;
            parentForm.rachunek = parentForm.rachunek *= 1.1;
            parentForm.addToList($"\nNapiwek {napiwek} zł DZIĘKUJMEY ");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double napiwek = 0.3 * parentForm.rachunek;
            parentForm.rachunek = parentForm.rachunek *= 1.3;
            parentForm.addToList($"\nNapiwek {napiwek} zł DZIĘKUJMEY :)");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double napiwek = 0.5 * parentForm.rachunek;
            parentForm.rachunek = parentForm.rachunek *= 1.5;
            parentForm.addToList($"\nNapiwek {napiwek} zł DZIĘKUJMEY :)");
            this.Close();
        }
    }
}
