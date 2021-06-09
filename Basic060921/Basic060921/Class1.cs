using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic060921
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("새로운 main");

            // 1차원 배열 초기화
            int[] arrint = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < arrint.Length; i++)
            {
                Console.Write(arrint[i] + " ");
                string str = string.Format("1차원 배열[{0}]: {1}", i, arrint[i]);
                Console.WriteLine(str);
            }

            // 1차원 배열 초기화 2
            char[] arrCh = new char[4]
            {
                '박', '김','이','최'
            };

            for (int i = 0; i < arrCh.Length; i++)
            {
                Console.Write(arrCh[i] + " ");
                string str = string.Format("1차원 배열[{0}]: {1}", i, arrCh[i]);
                Console.WriteLine(str);

            }

            // 2차원 배열 초기화 1
            int[,] arrint2 =
            {
                {1,2,3}, {4,5,6}
            };
            for (int i = 0; i< 2; i++)
            {
                for(int j=0; j<3;j++)
                {
                    Console.Write(arrint2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
