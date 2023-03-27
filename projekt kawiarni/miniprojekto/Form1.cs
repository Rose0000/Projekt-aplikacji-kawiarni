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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double rachunek = 0;
        public void addToList(string text)
        {
            richTextBox2.Text += text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "\t:-)";
            richTextBox2.Text += $"\nDo zapłaty: {rachunek} ";
            new Form2(rachunek).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kawa Latte 15 zł";
            double latte = 15;
            rachunek += latte;
            richTextBox2.Text += $"\nKawa Latte {latte} zł";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kawa Espresso 7 zł";
            double espresso = 7;
            rachunek += espresso;
            richTextBox2.Text += $"\nKawa Espresso {espresso} zł";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kawa Americano 15 zł";
            double americano = 15;
            rachunek += americano;
            richTextBox2.Text += $"\nKawa Americano {americano} zł";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kawa Cappuchino 17 zł";
            double cappuchino = 17;
            rachunek += cappuchino;
            richTextBox2.Text += $"\nKawa Cappuchino {cappuchino} zł";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Lemoniada 17 zł";
            double lemoniada = 17;
            rachunek += lemoniada;
            richTextBox2.Text += $"\nLemoniada {lemoniada} zł";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kawa Mocha 18 zł";
            double mocha = 18;
            rachunek += mocha;
            richTextBox2.Text += $"\nKawa Mocha {mocha} zł";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rachunek = 0;
            richTextBox1.Text = " ";
            richTextBox2.Text = "Rachunek: ";
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double napoj_roslinny = 4;
            rachunek += napoj_roslinny;
            richTextBox2.Text += $"\nNapój roślinny {napoj_roslinny} zł";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double cukier = 1;
            rachunek += cukier;
            richTextBox2.Text += $"\nCukier {cukier} zł";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double kubek = 2;
            rachunek += kubek;
            richTextBox2.Text += $"\nKubek na wynos {kubek} zł";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form3(this).Show();
        }
    }
}
