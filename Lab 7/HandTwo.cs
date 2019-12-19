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
    public partial class HandTwo : Form
    {
        public int[,] arr;
        private int k = 0;
        public HandTwo()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int size;
            string str = "0";
            size = Convert.ToInt32(numericUpDown1.Text);
            arr = new int[size, size];
            if (k != size)
            {
                for (int i = 0; i < size - 1; i++)
                    str += " 0";
                maskedTextBox1.Mask = str;
                textBox2.Text = $"Строка {k + 1}:";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted)
            {
                int[] res = new int[LabOne.Split(maskedTextBox1.Text).Length];
                res = LabOne.Split(maskedTextBox1.Text);

                for (int i = 0; i < res.Length; i++)
                {
                    arr[k, i] = res[i];
                }

                k++;

                if (k == Convert.ToInt32(numericUpDown1.Text))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }

                textBox2.Text = $"Строка {k + 1}:";
                maskedTextBox1.Clear();
            }
            else
            {
                MessageBox.Show("Форма не заполнена!");
                return;
            }

        }

        private void enter(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
