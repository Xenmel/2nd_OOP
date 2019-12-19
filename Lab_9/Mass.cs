using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Mass
    {
        Uravnenie[] uravnenies;
        int size;
        Random rnd = new Random();

        public Mass()
        {
            size = rnd.Next(1, 15);
            uravnenies = new Uravnenie[size];
            for (int i = 0; i < size; i++)
                uravnenies[i] = new Uravnenie(2, 4, 0);
        }

        public Mass(int sz)
        {
            size = sz;
            uravnenies = new Uravnenie[size];

            for (int i = 0; i < size; i++)
            {
                uravnenies[i] = new Uravnenie(rnd.Next(-15, 15), rnd.Next(-15, 15), rnd.Next(-15, 15));
            }
        }

        public Mass(int sz, bool f)
        {
            size = sz;
            double a, b, c;
            uravnenies = new Uravnenie[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Введите параметр a: ");
                a = Program.Val();

                Console.WriteLine("Введите параметр b: ");
                b = Program.Val();

                Console.WriteLine("Введите параметр c: ");
                c = Program.Val();

                uravnenies[i] = new Uravnenie(a, b, c);
            }
        }

        public void Show()
        {
            for(int i = 0; i < size; i++)
            {
                Uravnenie.ShowResStat(uravnenies[i]);
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");

        }

        public double Max()
        {
            Pair res = uravnenies[0].Result();
            for(int i = 1; i < size; i++)
            {
                if(uravnenies[i].Plus())
                {
                    if (uravnenies[i].Result() > res)
                        res = uravnenies[i].Result();
                }
            }
            return (double)res;
        }

        Uravnenie this[int i]
        {
            get
            {
                if (uravnenies.Length != 0 && i >= 0 && i < uravnenies.Length)
                    return uravnenies[i];
                else
                    return uravnenies[0];
            }
            set
            {
                if (i >= 0 && i < uravnenies.Length)
                    uravnenies[i] = value;
                else
                    uravnenies[0] = value;
            }
        }
    }
}

