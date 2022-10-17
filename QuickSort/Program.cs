using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        private int[] arr = new int[20];
        private int cmp_count = 0;
        private int mov_count = 0;

        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of element in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\n Array can have maximum 20 elements\n");
            }
            Console.WriteLine("===================");
            Console.WriteLine("Enter Array Element");
            Console.WriteLine("===================");

            for(int i = 0; i < n; i++)
            {
                Console.Write("<"+(i+1)+">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
