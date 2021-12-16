using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample505
{
    class Program
    {
        static void Main()
        {
            int[,] arr = new int[3, 4];     // int arr[3][4]
            int m, n;

            // 値を代入
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 4; n++)
                {
                    arr[m, n] = m + n;
                }
            }
            // 二次元配列の値を出力
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 4; n++)
                {
                    Console.Write("arr[{0}, {1}] = {2} ", m, n, arr[m, n]);
                }
                Console.WriteLine();
            }
        }
    }
}