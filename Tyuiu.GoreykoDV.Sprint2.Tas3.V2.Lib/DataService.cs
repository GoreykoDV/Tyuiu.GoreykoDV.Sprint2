using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GoreykoDV.Sprint2.Task3.V2.Lib
{
    public class DataService : ISprint2Task3V2
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 3)
            {
                y = Math.Round(x - 12 * x + Math.Cos(x), 3);
            }
            else
            {
                if (x == 2)
                {
                    y = Math.Round(x - (1 / x), 3);
                }
                else
                {
                    if ((x > -6) && (x < 1))
                    {
                        y = Math.Round(Math.Pow(x, 5) + 10 * x - (1 / Math.Sqrt(x + 3)), 3);
                    }
                    else
                    {
                        if (x < -6)
                        {
                            y = Math.Round(x + 10 * x - (1 / Math.Pow(x, 4)), 3);
                        }
                    }

                }
            }

            return y;
        }
    }
}
