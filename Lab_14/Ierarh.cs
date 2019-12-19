using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
     class Place : IComparable
    {
        public static Random rnd = new Random();
        public int cnt_people { get; set; }
        public int cnt_woman { get; set; }
        public Place()
        {
            cnt_people = rnd.Next(0, 5000);
            cnt_woman = cnt_people - rnd.Next(0, 2500);
            if (cnt_woman < 0)
                cnt_woman = cnt_people;
        }
        public Place(int people)
        {
            cnt_people = people;
        }

        virtual public void Show()
        { }

        virtual public int AllPeople() { return 0; }

        public int CompareTo(object obj)
        {
            Place res = obj as Place;

            if (this.cnt_people < res.cnt_people)
                return -1;
            else if (this.cnt_people > res.cnt_people)
                return 1;
            else return 0;
        }
    }

    class Region : Place, ICloneable
    {
        public int cnt_towns { get; set; }
        public int code_reg { get; set; }
        Town[] towns;
        public Region(int people, int towns, int code) : base(people)
        {
            code_reg = code;
            cnt_towns = towns;
            this.towns = new Town[cnt_towns];
            for (int i = 0; i < cnt_towns; i++)
                this.towns[i] = new Town();
        }
        public Region() : base()
        {
            code_reg = rnd.Next(1, 300);
            cnt_towns = rnd.Next(1, 10);
            towns = new Town[cnt_towns];
            for (int i = 0; i < cnt_towns; i++)
                towns[i] = new Town();
        }


        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
                if (obj is Region reg)
                    if (this.cnt_people == reg.cnt_people && this.cnt_woman == reg.cnt_woman)
                        return true;
            return false;
        }


        public override void Show()
        {
            Console.WriteLine($"\nКод региона: {code_reg}\nКоличество городов в регионе: {cnt_towns}\nКоличество людей в регионе: {cnt_people} тыс. человек\n");
        }

        public override int AllPeople()
        {
            int sum = 0;
            for (int i = 0; i < cnt_towns; i++)
                sum += towns[i].cnt_people;
            return sum;
        }
        public override string ToString()
        {
            return $"Kод {code_reg}, города {cnt_towns}, {cnt_people} тыс. человек из них {cnt_woman} тыс. женщин.";
        }
        public object Clone()
        {
            return new Region(cnt_people, cnt_towns, code_reg);
        }

        public Place BasePlace
        {
            get { return new Place(); }
        }
    }

    class Town : Place
    {
        protected string name_Mer { get; set; }
        protected int avarage_price_hab { get; set; }

        public Town(int people, string Mer, int price) : base(people)
        {
            name_Mer = Mer;
            avarage_price_hab = price;
        }

        public Town() : base()
        {
            name_Mer = "Решетников О.И.";
            avarage_price_hab = rnd.Next(500, 10000);
        }

        public override void Show()
        {
            Console.WriteLine($"\nМер: {name_Mer}\nСредняя цена на жильё: {avarage_price_hab} тыс.руб\nКоличество людей в регионе: {cnt_people} тыс. человек\n");
        }

    }
    class Metropolis : Town
    {
        public Metropolis(int people, string Mer, int price) : base(people, Mer, price)
        {
            name_Mer = Mer;
            avarage_price_hab = price;
        }

        public Metropolis() : base()
        {
            name_Mer = "Русских И.А.";
            avarage_price_hab = rnd.Next(500, 10000);
        }
    }
    ;
    class Adress : Region
    {
        string Town { get; set; }
        string Street { get; set; }
        int Num_dom { get; set; }

        public Adress(int people, int towns, int code, string T, string S, int N) : base(people, towns, code)
        {
            Town = T;
            Street = S;
            Num_dom = N;
        }
        public Adress() : base()
        {
            Town = "Пермь";
            Street = "Профессора Поздеева";
            Num_dom = rnd.Next(1, 15);
        }
        public override void Show()
        {
            Console.WriteLine($"\nГород: {Town}\nУлица: {Street}\nНомер дома: {Num_dom}\nКод региона: {code_reg}\nКоличество людей: {cnt_people}\n");

        }
    }

    class CntPeople : IComparer
    {
        public int Compare(object x, object y)
        {
            Place res_x = x as Place;
            Place res_y = y as Place;

            if (res_x.cnt_people < res_y.cnt_people)
                return -1;
            else if (res_x.cnt_people > res_y.cnt_people)
                return 1;
            else return 0;
        }
    }
}
