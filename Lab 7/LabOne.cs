using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class LabOne
    {
        public static int[] Arr1(bool r = false)
        {
            int size, cnt = -1;
            bool f;
            if (r)
                do
                {
                    cnt++;
                    if (cnt > 0)
                        Console.WriteLine("Ввод неверен. Повторите: ");

                    Console.Write("Введите размер динамического одномерного массива: ");
                    f = int.TryParse(Console.ReadLine(), out size);
                } while (!f || size <= 0 || size > 1000000);
            else
            {
                Random rnd = new Random();
                size = rnd.Next(1, 15);
            }
            int[] arr = new int[size];
            return arr;
        }

        public static int[,] Arr2(bool r = false)
        {
            int size, cnt = -1;
            bool f;
            if (r)
                do
                {
                    cnt++;
                    if (cnt > 0)
                        Console.WriteLine("Ввод неверен. Повторите: ");
                    Console.Write("Введите размер двумерного массива: ");
                    f = int.TryParse(Console.ReadLine(), out size);
                }
                while (!f || size <= 0 || size > 1000000);
            else
            {
                Random rnd = new Random();
                size = rnd.Next(1, 15);
            }
            int[,] arr = new int[size, size];
            return arr;
        }

        public static int[][] JagArr(bool r = false)
        {
            int size, sz, cnt = -1;
            bool f;
            int[][] arr;
            if (r)
            {
                do
                {
                    cnt++;
                    if (cnt > 0)
                        Console.WriteLine("Ввод неверен. Повторите: ");

                    Console.Write("Введите длину рваного массива: ");
                    f = int.TryParse(Console.ReadLine(), out size);
                } while (!f || size <= 0 || size > 1000000);

                arr = new int[size][];
                for (int i = 0; i < size; i++)
                {
                    do
                    {
                        Console.Write("Введите размер подмассива: ");
                        f = int.TryParse(Console.ReadLine(), out sz);
                    } while (!f || size <= 0);
                    arr[i] = new int[sz];
                }
            }
            else
            {
                Random rnd = new Random();
                size = rnd.Next(1, 15);
                arr = new int[size][];
                for (int i = 0; i < size; i++)
                {
                    sz = rnd.Next(1, 15);
                    arr[i] = new int[sz];
                }
            }
            return arr;
        }

        public static int[] RandomArr(int[] arr, bool f = false)
        {
            int size = arr.Length;
            if (!f)
            {
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                {
                    arr[i] = rnd.Next(-100, 100);
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                    do
                    {
                        Console.Write("Введите элемент массива: ");
                        f = int.TryParse(Console.ReadLine(), out arr[i]);
                    } while (!f);
            }
            return arr;
        }

        public static int[,] RandomArr(int[,] arr, bool f = false)
        {
            int size = (int)Math.Sqrt(arr.Length);
            if (!f)
            {
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        arr[i, j] = rnd.Next(-100, 100);
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        do
                        {
                            Console.Write("Введите элемента массива: ");
                            f = int.TryParse(Console.ReadLine(), out arr[i, j]);
                        } while (!f);
            }
            return arr;
        }

        public static int[][] RandomArr(int[][] arr, bool f = false)
        {
            int size = arr.Length;
            if (!f)
            {
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < arr[i].Length; j++)
                        arr[i][j] = rnd.Next(-100, 100);
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < arr[i].Length; j++)
                        do
                        {
                            Console.Write("Введите элемент массива: ");
                            f = int.TryParse(Console.ReadLine(), out arr[i][j]);
                        } while (!f);
            }
            return arr;
        }

        public static string Out(int[] arr)
        {
            StringBuilder str = new StringBuilder();
            if (arr != null)
                foreach (int cur in arr)
                    str.Append($" {cur.ToString()}");
            else str.Append("Массив пуст!");
            str.AppendLine();
            return str.ToString();
        }

        public static string Out(int[,] arr)
        {
            StringBuilder str = new StringBuilder();
            if (arr != null)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        str.Append($" {arr[i, j], 5}");
                    }
                    str.AppendLine();
                }
            }
            else str.Append("Массив пуст!");
            str.Append("\n");
            return str.ToString();
        }

        public static string Out(int[][] arr)
        {
            StringBuilder str = new StringBuilder();
            if (arr != null)
            {
                foreach (int[] a in arr)
                {
                    foreach (int cur in a)
                    {
                        str.Append($"{cur.ToString(), 5} ");
                    }
                    str.AppendLine();
                }
            }
            else str.Append("Массив пуст! ");
            str.AppendLine();

            return str.ToString();
        }

        public static int[] Rm(int[] arr, int N, int k)  // удалить N элементов, начиная с номера K
        {
            int size, count = 0;
            size = arr.Length;
            
            int[] newArr = new int[size - N];
            for (int i = 0; i < size; i++)
            {
                if (i == k & N != 0)
                {
                    count += N;
                    i += N - 1;
                }
                else
                    newArr[i - count] = arr[i];
            }
            if (newArr.Length == 0) newArr = null;
            return newArr;
        }

        public static int[,] AddCol(int[,] arr)  // добавить столбец в начало матрицы
        {
            int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1) + 1];

            for (int i = 0; i < arr.GetLength(0); i++)
                newArr[i, 0] = 1;

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 1; j < arr.GetLength(1) + 1; j++)
                    newArr[i, j] = arr[i, j - 1];
            return newArr;
        }

        public static int[][] RmK(int[][] arr, int k1, int k2)  // удалить строки начиная с K1, заканчивая K2 включительно
        {
            int size;
      
            size = arr.GetLength(0) - (k2 - k1 + 1);
            int[][] newArr = new int[size][];

            for (int i = 0, j = 0; i < arr.GetLength(0); i++)
                if (i >= k1 && i <= k2)
                    continue;
                else
                {
                    newArr[j] = arr[i];
                    j++;
                }
            if (newArr.Length == 0) newArr = null;
            return newArr;
        }

        public static int[] Split(string str)
        {
            string[] strr = str.Split(' ');
            int[] arr = new int[strr.Length];

            for (int i = 0; i < strr.Length; i++)
                arr[i] = Convert.ToInt32(strr[i]);
            return arr;
        }

        static public int[,] ParseAs2D(string str)
        {
            string[] rows = str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (str.Length == 0) return null;
            string[] values_buf = rows[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[,] arr = new int[rows.Length, values_buf.Length];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                rows[i] = rows[i].Trim('\n');
                values_buf = rows[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = Convert.ToInt32(values_buf[j]);
            }

            return arr;
        }

        static public int[] ParseAs1D(string str)
        {
            if (str.Length == 0) return null;
            str = str.Trim('\n');
            string[] values = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[values.Length];

            for (int i = 0; i < arr.GetLength(0); i++)
                arr[i] = Convert.ToInt32(values[i]);


            return arr;
        }

        static public int[][] ParseAsJag(string str)
        {
            if (str.Length == 0) return null;
            string[] rows = str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            string[] values_buf = rows[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[][] arr = new int[rows.Length][];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                rows[i] = rows[i].Trim('\n');
                values_buf = rows[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                arr[i] = new int[values_buf.Length];

                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = Convert.ToInt32(values_buf[j]);
            }

            return arr;
        }
    }
}


