using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MakeenkovMS.Sprint1.Task4.V2.Lib
{
    public class DataService : ISprint1Task4V2
    {
        public double Calculate(double x, double y)
        {
            double res = 1 / Math.Sqrt(x + 2 * y);
            return Math.Round(res, 3);
        }
    }
}
