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
    public partial class HandOne : Form
    {
        public HandOne()
        {
            InitializeComponent();
        }

        public int[] arr;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int size;
            string str = "0";
            size = Convert.ToInt32(numericUpDown1.Text);
            for (int i = 0; i < size - 1; i++)
                str += " 0";
            maskedTextBox1.Mask = str;
            numericUpDown1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            str = maskedTextBox1.Text;
            if (maskedTextBox1.MaskCompleted)
                arr = LabOne.Split(str);
            else
            {
                MessageBox.Show("Форма не заполнена!");
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arr = null;
            this.Close();
        }

        private void HandOne_Load(object sender, EventArgs e)
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
