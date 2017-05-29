using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Floyd
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4]{
                {0, 5, 0, 0 },
                {50, 0, 15, 5},
                {30, 0, 0, 15 },
                {15, 0, 5, 0 }
            };

            Floyd.floyd(arr, 4);

            Console.Read();
        }
    }
    public class Floyd
    {
        const int VC = int.MaxValue;
        public static void floyd(int[,] arr, int length)
        {
            int i, j, k;
            int[,] d = new int[length, length];
            int[,] p = new int[length, length];
            //khoi dong ma tran d va p
            for (i = 0; i < length; i++)
            {
                for (j = 0; j < length; j++)
                {
                    d[i, j] = arr[i, j];
                    p[i, j] = 0;
                }
            }
            //tinh ma tran d va p o buoc lap thu K
            for (k = 0; k < length; k++)
            {
                for (i = 0; i < length; i++)
                    if (d[i, k] > 0 && d[i, k] < VC)
                        for (j = 0; j < length; j++)
                        {
                            if (d[k, j] > 0 && d[k, j] < VC)
                            {
                                if (d[i, k] + d[k, j] < d[i, j])
                                {
                                    d[i, j] = d[i, k] + d[k, j];
                                    p[i, j] = k;
                                }
                            }
                        }
            }
            Console.Read();
        }
    }
}
