using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exe2_088
{
    class Program
    {
        public void SearchGPA()
        {
            int[] arr = new int[5];
            int n;
            int i;
        
            int Max(int a, int b, int c = Int32.MinValue)
            {
                int max1 = (a > b) ? a : b;
                return (c > max1) ? c : max1;
            }
        }
        void input()
        {
            while (true)
            {
                Console.WriteLine("Enter Subject");
                string s = Console.ReadLine();
                int = Int32.Parse(s);
                int n = 0;
                if ((n > 0) && (n <= 1620))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 1620 element.\n");
            }
        }

        public void AlgorithmLowHigh() {
        }
    }
}