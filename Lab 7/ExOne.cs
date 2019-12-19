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
    public partial class ExOne : Form
    {
        public ExOne()
        {
            InitializeComponent();
        }
        public int N, K;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {       
                maskedTextBox1.Select();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Length != 0)
                N = Convert.ToInt32(maskedTextBox1.Text);
            else { MessageBox.Show("Форма не заполнена!"); return; }
            if (maskedTextBox2.Text.Length != 0)
                K = Convert.ToInt32(maskedTextBox2.Text);
            else { MessageBox.Show("Форма не заполнена!"); return; }

            if(K == 0)
            {
                MessageBox.Show("Такого элемента нет!");
                return;
            }
            K--;
            DialogResult = DialogResult.OK;
            this.Close();

        }

    }
}
