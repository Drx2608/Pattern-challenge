using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int n = Int32.Parse(Console.ReadLine());

            for(int i =1; i <= n; i++) {
            int a = i;
            for(int j = 1; j <= n; j++) {
                    Console.Write(a + " ");
                    if(a == n) {
                        a = 0;
                    }

                    a++;
                }
                Console.WriteLine();
            }
        }
    }
}