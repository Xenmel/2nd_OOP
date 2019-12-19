using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    struct Pair
    {
        double x11, x22;
        public double X1
        {
            get { return x11; }
            set { x11 = value; }
        }

        public double X2
        {
            get { return x22; }
            set { x22 = value; }
        }

        public static bool operator >(Pair ex1, Pair ex2)
        {
            if (ex1.x11 + ex1.x22 > ex2.x11 + ex2.x22)
                return true;
            else return false;
        }

        public static bool operator <(Pair ex1, Pair ex2)
        {
            if (ex1.x11 + ex1.x22 < ex2.x11 + ex2.x22)
                return true;
            else return false;
        }

        public static explicit operator double(Pair ex)
        {
            return ex.x11 + ex.x22;
        }

    }
    class Uravnenie
    {
        double a, b, c;

        public static int Count = 0;
        public Uravnenie(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Uravnenie.Count++;
        }

        double Descriminante()
        {
            return (b * b - 4 * a * c);
        }

        public bool Plus()
        {
            if (Descriminante() >= 0)
                return true;
            else return false;
        }

        public double x1()
        {
            if (a != 0)
                return ((b - Math.Sqrt(Descriminante())) / (2 * a));
            else return -999999;
        }

        public double x2()
        {
            if (a != 0)
                return ((b + Math.Sqrt(Descriminante())) / (2 * a));
            else return -999999;
        }

        public Pair Result()
        {
            Pair res = new Pair();
            if (Plus() && a != 0)
            {
                res.X1 = x1();
                res.X2 = x2();
            }
            else
            {
                res.X1 = 0;
                res.X1 = 0;
            }
            return res;
        }

        public void ShowRes()
        {
            if (Plus() && a != 0)
                Console.WriteLine($"{a}x+{b}x^2+{c}={Result().X1}\n{a}x+{b}x^2+{c}={Result().X2}");
            else Console.WriteLine("Нет действительных корней!");
        }

        public static void ShowResStat(Uravnenie example)
        {
            if (example.Plus() && example.a != 0)
                Console.WriteLine($"{example.a}x+{example.b}x^2+{example.c}={example.Result().X1}\n{example.a}x+{example.b}x^2+{example.c}={example.Result().X2}");
            else Console.WriteLine("Нет действительных корней!");
        }

        public static Uravnenie operator ++(Uravnenie ex)
        {
            ex.a++;
            ex.b++;
            ex.c++;
            return ex;
        }

        public static Uravnenie operator --(Uravnenie ex)
        {
            ex.a--;
            ex.b--;
            ex.c--;
            return ex;
        }

        public static bool operator !=(Uravnenie ex1, Uravnenie ex2)
        {
            if (ex1.a != ex2.a && ex1.b != ex2.b && ex1.c != ex2.c)
                return true;
            return false;
        }

        public static bool operator ==(Uravnenie ex1, Uravnenie ex2)
        {
            if (ex1.a == ex2.a && ex1.b == ex2.b && ex1.c == ex2.c)
                return true;
            return false;
        }

        

        public static implicit operator double(Uravnenie ex)
        {
            if (ex.Plus())
            {
                return ex.x1();
            }
            else return 0;
        }
        public static explicit operator bool(Uravnenie ex)
        {
            if (ex.Plus())
            {
                return true;
            }
            else return false;
        }
    }
}
