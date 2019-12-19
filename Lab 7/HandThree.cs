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
    public partial class HandThree : Form
    {
        public HandThree()
        {
            InitializeComponent();
        }

        public int[][] arr;
        private int size;
        private int k = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted)
            {
                int[] res = new int[LabOne.Split(maskedTextBox1.Text).Length];
                res = LabOne.Split(maskedTextBox1.Text);

                //maskedTextBox1.Mask = "0";
                for (int i = 0; i < res.Length; i++)
                {
                    arr[k][i] = res[i];
                }

                k++;

                if (k == Convert.ToInt32(numericUpDown1.Text))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }

                textBox2.Text = $"Строка {k + 1}:";
                maskedTextBox1.Clear();
                numericUpDown2.Select();
            }
            else
            {
                MessageBox.Show("Форма не заполнена!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            size = Convert.ToInt32(numericUpDown1.Value);
            arr = new int[size][];
            numericUpDown1.Enabled = false;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int sz;
            string str = "0";

            sz = Convert.ToInt32(numericUpDown2.Text);
            arr[k] = new int[sz];
            for (int i = 0; i < sz - 1; i++)
                str += " 0";
            maskedTextBox1.Mask = str;

        }

        private void HandThree_Load(object sender, EventArgs e)
        {
            numericUpDown1.Select();
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
