using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MakeenkovMS.Sprint1.Task7.V2.Lib
{
    public class DataService : ISprint1Task7V2
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Sin(x) + Math.Cos(y);
            double denominator = Math.Cos(x) - Math.Sin(y);
            double res = (numerator / denominator) * Math.Tan(x * y);
            return Math.Round(res, 3);
        }
    }
}
