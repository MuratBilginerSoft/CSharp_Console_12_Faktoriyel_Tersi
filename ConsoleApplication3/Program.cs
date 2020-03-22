using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k=1;

            Console.Write("Değeri Giriniz=");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 100000; i++)
            {
                k = k * i;

                if (k==n)
                {
                    Console.WriteLine(n+"="+i+"!");
                    break;
                }

                else if (k>n)
                {
                    Console.WriteLine("Girmiş Olduğunuz Sayı Hiç bir sayının Faktöriyeli Değildir");
                    break;
                }
            }

            Console.ReadKey();

        }
    }
}
