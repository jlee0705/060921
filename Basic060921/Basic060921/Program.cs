using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic060921
{
    class Program
    {
        /// <summary>
        /// 메인함수
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //출력
            Console.WriteLine("안녕하세요");
            Console.WriteLine("핼로우 C#");

            //입력
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();
            Console.WriteLine("이름: " + name);

            Console.WriteLine("나이 입력: ");
            //method 1
            //string age = Console.ReadLine();
            //int nAge = Convert.ToInt32(age);

            //method 2
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("나이 : {0}", age);
            Console.WriteLine("나이 : {0}, 이름: {1}", age,name);

            //method 3
            string str = string.Format("이름: {0}, 나이:{1}", name, age);
            Console.WriteLine(str);
        }
    }
}
