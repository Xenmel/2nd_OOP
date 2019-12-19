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

namespace Lab_7
{
    public partial class Main : Form
    {
        int Mass = 1;
        bool In = false;
        static int[] arr1;
        static int[,] arr2;
        static int[][] arr3;

        public Main()
        {
            InitializeComponent();
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!In)
                switch (Mass)
                {
                    case 1:
                        richTextBox1.Clear();
                        richTextBox1.Text += "Сформирован одномерный массив:\n\n";
                        arr1 = LabOne.Arr1(In);
                        arr1 = LabOne.RandomArr(arr1, In);
                        richTextBox1.Text += LabOne.Out(arr1);
                        break;
                    case 2:
                        richTextBox1.Clear();
                        richTextBox1.Text += "Сформирован двумерный массив:\n\n";
                        arr2 = LabOne.Arr2(In);
                        arr2 = LabOne.RandomArr(arr2, In);
                        richTextBox1.Text += LabOne.Out(arr2);
                        break;
                    case 3:
                        richTextBox1.Clear();
                        richTextBox1.Text += "Сформирован рваный массив:\n\n";
                        arr3 = LabOne.JagArr(In);
                        arr3 = LabOne.RandomArr(arr3, In);
                        richTextBox1.Text += LabOne.Out(arr3);
                        break;
                    default:
                        break;
                }
            else
            {
                DialogResult res; 
                switch (Mass)
                {
                    case 1:
                        HandOne diag1 = new HandOne();
                        res = diag1.ShowDialog(this);
                        if (res == DialogResult.OK)
                        {
                            richTextBox1.Clear();
                            richTextBox1.Text += "Сформирован одномерный массив:\n\n";
                            arr1 = diag1.arr;
                            richTextBox1.Text += LabOne.Out(arr1);

                        }
                        else
                        {
                            richTextBox1.Clear();
                            arr1 = null;
                            richTextBox1.Text += "Действие отменено. ";
                        }
                            break;
                    case 2:
                        HandTwo diag2 = new HandTwo();
                        res = diag2.ShowDialog(this);
                        if (res == DialogResult.OK)
                        {
                            richTextBox1.Clear();
                            richTextBox1.Text += "Сформирован двумерный массив:\n\n";
                            arr2 = diag2.arr;
                            richTextBox1.Text += LabOne.Out(arr2);
                        }
                        else
                        {
                            richTextBox1.Clear();
                            arr2 = null;
                            richTextBox1.Text += "Действие отменено. ";
                        }
                            break;
                    case 3:
                        HandThree diag3 = new HandThree();
                        res = diag3.ShowDialog(this);
                        if (res == DialogResult.OK)
                        {
                            richTextBox1.Clear();
                            richTextBox1.Text += "Сформирован рваный массив:\n\n";
                            arr3 = diag3.arr;
                            richTextBox1.Text += LabOne.Out(arr3);
                        }
                        else
                        {
                            richTextBox1.Clear();
                            arr3 = null;
                            richTextBox1.Text += "Действие отменено. ";
                        }
                            break;
                    default:
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            switch (Mass)
            {
                case 1:
                    int N, K;
                    if (arr1 != null)
                    {
                        ExOne diag2 = new ExOne();
                        DialogResult res = diag2.ShowDialog(this);
                        if (res == DialogResult.OK)
                        {
                            N = diag2.N;
                            K = diag2.K;
                            if (N > arr1.Length)
                            {
                                MessageBox.Show("N превышает размер массива. ");
                            }
                            else if (K >= arr1.Length)
                            {
                                MessageBox.Show("K превышает размер массива. ");
                            }
                            else if (N + K > arr1.Length)
                            {
                                MessageBox.Show("N + K превышает размер массива. ");

                            }
                            else
                            {
                                arr1 = LabOne.Rm(arr1, N, K);
                                richTextBox1.Clear();
                                richTextBox1.Text += "Результат: \n\n";
                                richTextBox1.Text += LabOne.Out(arr1);
                            }
                        }
                        else richTextBox1.Text = "Действие отменено. ";
                    }
                    else richTextBox1.Text = "Массив пуст! ";

                    break;
                case 2:
                    richTextBox1.Clear();
                    richTextBox1.Text += "Результат добавления столбца из единиц: \n\n";
                    arr2 = LabOne.AddCol(arr2);
                    richTextBox1.Text += LabOne.Out(arr2);
                    break;
                case 3:
                    if (arr1 != null)
                    {
                        int k1, k2;
                        ExThree diag3 = new ExThree();
                        DialogResult res1 = diag3.ShowDialog(this);
                        if (res1 == DialogResult.OK)
                        {
                            k1 = diag3.k1;
                            k2 = diag3.k2;
                            if(k1 >= arr3.Length || k2 >= arr3.Length)
                                MessageBox.Show("K превышает размер массива. ");

                            else if(k1 + k2 >= arr3.Length)
                                MessageBox.Show("K1 + K2 превышает размер массива. ");
                            else
                            {
                                richTextBox1.Clear();
                                richTextBox1.Text += "Результат: \n\n";
                                arr3 = LabOne.RmK(arr3, k1, k2);
                                richTextBox1.Text += LabOne.Out(arr3);
                            }

                            
                        }
                        else richTextBox1.Text = "Действие отменено. ";
                    }
                    else richTextBox1.Text = "Массив пуст! ";
                    break;

                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e) // сохранить
        {
            MessageBox.Show("Массив сохранен в файл.");
            string file = "";
            switch (Mass)
            {
                case 1:
                    file = "TextFile1.txt";
                    break;
                case 2:
                    file = "TextFile3.txt";
                    break;
                case 3:
                    file = "TextFile3.txt";
                    break;
                default:
                    break;
            }
            StreamWriter writer = new StreamWriter(file);
            writer.Write(richTextBox1.Text);
            writer.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (Mass)
            {
                case 1:
                    richTextBox1.Clear();
                    richTextBox1.Text += "Одномерный массив:\n\n";
                    richTextBox1.Text += LabOne.Out(arr1);
                    break;
                case 2:
                    richTextBox1.Clear();
                    richTextBox1.Text += "Двумерный массив: \n\n";
                    richTextBox1.Text += LabOne.Out(arr2);
                    break;
                case 3:
                    richTextBox1.Clear();
                    richTextBox1.Text += "Рваный массив: \n\n";
                    richTextBox1.Text += LabOne.Out(arr3);
                    break;
                default:
                    break;
            }
        }

        private void одномерныйToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Mass = 1;
            одномерныйToolStripMenuItem.Checked = true;
            двумерныйToolStripMenuItem.Checked = false;
            рваныйToolStripMenuItem.Checked = false;
        }

        private void двумерныйToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Mass = 2;
            одномерныйToolStripMenuItem.Checked = false;
            двумерныйToolStripMenuItem.Checked = true;
            рваныйToolStripMenuItem.Checked = false;
        }

        private void рваныйToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Mass = 3;
            одномерныйToolStripMenuItem.Checked = false;
            двумерныйToolStripMenuItem.Checked = false;
            рваныйToolStripMenuItem.Checked = true;
        }

        private void ручнойToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            In = true;
            ручнойToolStripMenuItem.Checked = true;
            дСЧToolStripMenuItem.Checked = false;
        }

        private void дСЧToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            In = false;
            ручнойToolStripMenuItem.Checked = false;
            дСЧToolStripMenuItem.Checked = true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            одномерныйToolStripMenuItem.Checked = true;
            дСЧToolStripMenuItem.Checked = true;
        }

        private void изФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            switch (Mass)
            {
                case 1:
                    reader = new StreamReader("TextFile1.txt");
                    reader.ReadLine();
                    arr1 = LabOne.ParseAs1D(reader.ReadToEnd());
                    reader?.Close();
                    break;
                case 2:

                    reader = new StreamReader("TextFile2.txt");
                    reader.ReadLine();
                    arr2 = LabOne.ParseAs2D(reader.ReadToEnd());
                    reader?.Close();
                    break;
                case 3:
                    reader = new StreamReader("TextFile3.txt");
                    reader.ReadLine();
                     arr3 = LabOne.ParseAsJag(reader.ReadToEnd());
                    reader?.Close();
                    break;
                default:
                    break;

            }
        }
    }
}
