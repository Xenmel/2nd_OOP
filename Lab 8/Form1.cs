using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        Month month = new Month();
        BindingSource source = new BindingSource();

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedDayDel.Enabled = true;
            maskedTextBox1.Enabled = false;
            maskedDay.Select();
            source.DataSource = Month.days;
            dataGridView1.DataSource = source;

            source.ResetBindings(false);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int dayNum;
            double temp;

            if (DSC.Checked)
            {
                dayNum = rnd.Next(1, 30);
                temp = rnd.Next(-30, 30) + (1 / rnd.Next(10, 100));
                month.SetDay(dayNum, temp);
            }
            else
            {
                if (maskedDay.MaskCompleted && maskedTemp != null)
                {
                    dayNum = Convert.ToInt32(maskedDay.Text);
                    if (dayNum <= 30 && dayNum > 0)
                    {
                        
                        if (plus.SelectedItem == "Минус")
                            temp = Convert.ToDouble('-' + maskedTemp.Text);
                        else temp = Convert.ToDouble(maskedTemp.Text);

                        if (temp < 57 && temp > -89)
                            month.SetDay(dayNum, temp);
                        else MessageBox.Show("Апокалипсис!");
                    }
                    else MessageBox.Show("Неверно указан день. ");
                }
                else MessageBox.Show("Поля не заполнены. ");
            }

            source.DataSource = Month.days;
            dataGridView1.DataSource = source;
            source.ResetBindings(false);

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (SrTemperature.Checked && !HighTemp.Checked && !LowTemp.Checked)
            {
                MessageBox.Show($"Средняя температура за месяц: {month.Average()}");
            }
            else if ((!SrTemperature.Checked && HighTemp.Checked && !LowTemp.Checked))
            {
                MessageBox.Show($"Самая высокая температура за месяц: {month.SearchMax()}");
            }
            else if ((!SrTemperature.Checked && !HighTemp.Checked && LowTemp.Checked))
            {
                MessageBox.Show($"Самая низкая температура за месяц: {month.SearchMin()}");
            }
            else MessageBox.Show("Пожалуйста, выберите один элемент. ");
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (maskedDayDel.Enabled)
            {
                month.Delete(Convert.ToInt32(maskedDayDel.Text));
            }
            else
            {
                double temp;
                if (comboBox2.SelectedItem == "Минус")
                    temp = Convert.ToDouble('-' + maskedTextBox1.Text);
                else
                    temp = Convert.ToDouble(maskedTextBox1.Text);
                month.Delete(temp);
            }

            source.DataSource = Month.days;
            dataGridView1.DataSource = source;
            source.ResetBindings(false);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "По дате")
            {
                maskedDayDel.Enabled = true;
                maskedTextBox1.Enabled = false;
            }
            else
            {
                maskedDayDel.Enabled = false;
                maskedTextBox1.Enabled = true;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream f2 = new FileStream("Demo.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Month.days = (DayTemp[])bf.Deserialize(f2);
            f2.Close();
            MessageBox.Show("Месяц загружен. ");

            source.DataSource = Month.days;
            dataGridView1.DataSource = source;
            source.ResetBindings(false);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream f1 = new FileStream("Demo.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f1, Month.days); 
            f1.Close();
            MessageBox.Show("Месяц сохранен. ");
        }

        private void DSC_CheckedChanged_1(object sender, EventArgs e)
        {
            if (DSC.Checked)
            {
                maskedDay.Enabled = false;
                maskedTemp.Enabled = false;
                plus.Enabled = false;
            }
            else
            {
                maskedDay.Enabled = true;
                maskedTemp.Enabled = true;
                plus.Enabled = true;
            }
        }
    }
}
