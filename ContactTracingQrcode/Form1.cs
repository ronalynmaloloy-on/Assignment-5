using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracingQrcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw dr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = dr.Draw(textBox1.Text + "\n " + textBox2.Text + "\n " + textBox3.Text + "\n " + textBox4.Text + "\n " + textBox5.Text + "\n " + textBox6.Text + "\n " + textBox7.Text + "\n " + textBox8.Text, 1100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
            pictureBox1.Image.Save(dlg.FileName);
            MessageBox.Show("Save");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
        }
    }
}
