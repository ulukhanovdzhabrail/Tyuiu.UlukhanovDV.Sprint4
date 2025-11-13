using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.UlukhanovDV.Sprint4.Task7.V29.Lib
{
    public class DataService : ISprint4Task7V29
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mas = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0;j < m; j++)
                {
                    if (mas[i, j] % 2 == 0)
                    {
                        s += mas[i, j];
                    }
                }
            }
            return s;

        }   
        
        
    }
}
