using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0,  s;
            int value = 0;
            int[] arr = new int[100] ;

            Console.WriteLine("Entre the elements os array");

            s = int.Parse(Console.ReadLine());

            for(int i = 0; i < s; i++)
            {
                Console.Write("Element "+i+" : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The elements is array are : ");

            for(int j = 0; j < s; j++)
            {
                 value = arr[j];
                Console.Write(value+" ");
                if (max < value)
                {
                    max = value;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The maximum number in the array is :");
            Console.WriteLine( value);


            Console.ReadLine();
        }
    }
}
