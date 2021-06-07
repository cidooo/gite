using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static String[] veriler = new String[0];
        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);
            Array.Resize(ref veriler, veriler.Length + 1);
            veriler[veriler.GetUpperBound(0)] = textBox1.Text;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            this.Hide();
        }
    }
}
