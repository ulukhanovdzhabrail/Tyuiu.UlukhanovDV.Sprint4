using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.UlukhanovDV.Sprint4.Task4.V7.Lib
{
    public class DataService : ISprint4Task4V7
    {
        public int Calculate(int[,] matrix)
        {
            int r = matrix.GetUpperBound(0) + 1;
            int c = matrix.Length / r;
            int s = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        s += matrix[i, j];
                    }
                }

            }
            return s;
        }
    }
}
