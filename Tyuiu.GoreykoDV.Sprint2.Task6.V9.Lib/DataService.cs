using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GoreykoDV.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int days = m switch
            {
                4 or 6 or 9 or 11 => 30,
                2 => 28,
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31 
            };

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
