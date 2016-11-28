using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySimetry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array:");
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a["+i+"]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
            ArraySymmetry(a);
        }
        static void ArraySymmetry(int[] arr)
        {
            if (arr.Length % 2 == 0)
            {
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    if (arr[i] == arr[arr.Length - 1 - i])
                    {
                        if (i < arr.Length / 2 - 1)
                        {
                            continue;
                        }
                        if (i < arr.Length / 2)
                        {
                            Console.WriteLine("The array is symmetric.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The array is not symmetric.");
                        break;
                    }
                }
            }
            if (arr.Length % 2 > 0)
            {
                int half = (int)(arr.Length / 2);
                for (int i = 0; i < half; i++)
                {
                    if (arr[i] == arr[arr.Length - 1 - i])
                    {
                        if (i < half - 1)
                        {
                            continue;
                        }
                        if (i < half)
                        {
                            Console.WriteLine("The array is symmetric.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The array is not symmetric.");
                        break;
                    }
                }
            }
        }
    }
}
