using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GoreykoDV.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int days = 31;

            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    days = 28;
                    break;
            }

            n++;
            if (n > days)
            {
                n = 1;
                m++;
            }

            return $"{n:D2}.{m:D2}";
        }
    }
}
