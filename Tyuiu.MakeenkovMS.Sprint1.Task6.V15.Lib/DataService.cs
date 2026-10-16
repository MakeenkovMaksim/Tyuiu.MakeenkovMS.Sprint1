using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MakeenkovMS.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            int letters = 0;
            int signs = 0;
            foreach (char c in value)
            {
                if (char.IsLetter(c))
                {
                    letters++;
                }
                else if (char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    signs++;
                }
            }
            return letters > signs;
        }
    }
}
