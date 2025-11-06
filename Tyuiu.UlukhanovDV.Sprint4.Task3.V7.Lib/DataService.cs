using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.UlukhanovDV.Sprint4.Task3.V7.Lib
{
    public class DataService : ISprint4Task3V7
    {
        public int Calculate(int[,] array)
        {
            int r = array.GetUpperBound(0) + 1;
            int co = array.Length / r;
            int s = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < co; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        s++;
                    }
                }

            }
            return s;
        }
    }
}
