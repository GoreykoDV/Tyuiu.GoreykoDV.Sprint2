using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GoreykoDV.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((y == 3 && x >= 3 && x <= 5) || (y == 3 && x >= 8 && x <= 12) ||
                (y == 4 && x >= 3 && x <= 5) || (y == 4 && x >= 8 && x <= 12) ||
                (y == 5 && x >= 3 && x <= 4) || (y == 5 && x >= 7 && x <= 12) ||
                (y == 6 && x >= 3 && x <= 4) || (y == 6 && x >= 7 && x <= 8) || 
                (y == 6 && x == 12) || (y == 7 && x >= 3 && x <= 4) || 
                (y == 7 && x >= 7 && x <= 8) || (y == 7 && x == 12) ||
                (y == 8 && x >= 3 && x <= 4) || (y == 8 && x >= 7 && x <= 12) ||
                (y == 9 && x >= 3 && x <= 4) || (y == 9 && x >= 7 && x <= 12) ||
                (y == 10 && x >= 3 && x <= 12) || (y == 11 && x >= 3 && x <= 12) ||
                (y == 12 && x >= 6 && x <= 11))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
