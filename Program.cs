using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSortCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 9, 7, 2, 10, 35, 23, 14, 13, 1 };
            int aux = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //swap operation
                        aux = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = aux;
                    }
                }
                
            }

            for (int i = 0; i<= arr.Length -1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Read();
        }
    }
}
