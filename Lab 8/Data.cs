using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    [Serializable]
    struct DayTemp
    {
        int day;
        double temp;

        public void Day(int day, double temp)
        {
            this.day = day;
            this.temp = temp;
        }

        public int День
        {
            get { return day; }
            set { day = value; }
        }

        public double Температура
        {
            get { return temp; }
            set { temp = value; }
        }

        public double GetTemp()
        {
            return temp;
        }
    }

    class Month
    {
        static int countDays = 30;
        static public DayTemp[] days = new DayTemp[countDays];

        public Month()
        {
            for(int i = 1; i <= countDays; i++)
            {
                days[i - 1].День = i;
            }
        }
        public void SetDay(int day, double temp)
        {           
                days[--day].Day(++day, temp);
        }

        public double SearchMin()
        {
            double res = days[0].GetTemp();
            for (int i = 1; i < countDays; i++)
            {
                if (days[i].GetTemp() < res)
                    res = days[i].GetTemp();
            }
            return res;
        }

        public double SearchMax()
        {
            double res = days[0].GetTemp();
            for (int i = 1; i < countDays; i++)
            {
                if (days[i].GetTemp() > res)
                    res = days[i].GetTemp();
            }
            return res;
        }

        public double Average()
        {
            double res = 0;
            for( int i = 0; i < countDays; i++)
            {
                res += days[i].GetTemp();
            }
            res /= countDays;
            return res;
        }

        public void Delete(int day)
        {
            days[--day].Температура = 0;

        }

        public void Delete(double temp)
        {
            for(int i = 0; i < countDays; i++)
            {
                if(days[i].Температура == temp)
                {
                    days[i].Температура = 0;
                }
            }
        }

    }
}
