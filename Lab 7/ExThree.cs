using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class ExThree : Form
    {
        public ExThree()
        {
            InitializeComponent();
        }
        public int k1, k2;

        private void button2_Click(object sender, EventArgs e)
        {
            k1 = Convert.ToInt32(maskedTextBox1.Text);
            k2 = Convert.ToInt32(maskedTextBox2.Text);
            k1--;
            k2--;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Select();
        }
    }
}
