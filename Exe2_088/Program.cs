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
                int n = 0;
                if ((n > 0) && (n <= 1620))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 1620 element.\n");
            }
        }
        public void AlgorithmLowHigh(int low, int high) 
        {
            int pivot, i, j;
            if (low > high)
                return;
            i = low + 1;
            j = high + 1;

            while (i <= j)
            {
                static void Main(string[] args)
            {
                Program myList = new Program();
                int Menu;
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("===========");
                    Console.WriteLine("1.SearchGPA");
                    Console.WriteLine("2.AlgorithmLowHigh");
                    Console.WriteLine("3. Exit");
                    Menu = Convert.ToInt32(Console.ReadLine());

                    switch (Menu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("...............");
                            Console.WriteLine("SearchGPA");
                            Console.WriteLine("...............");
                            myList.input();
                            myList.SearchGPA();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("...............");
                            Console.WriteLine("AlgorithmLowHigh");
                            Console.WriteLine("...............");
                            myList.input();
                            myList.AlgorithmLowHigh();
                            break;
                        case 3:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    //to exit from the console
                    Console.WriteLine("\n\nPress return to exit.");
                    Console.ReadLine();
                } while (Menu != 3);
            }
        }
    }
}