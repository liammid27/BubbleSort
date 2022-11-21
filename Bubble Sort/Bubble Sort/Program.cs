using System;

namespace Bubble_Sort
{
    class Bubble 
    {
        

        static void Sort(int[] numArray)
        {
            int n = numArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numArray[j] > numArray[j + 1])
                    {
                        Swap<int>(ref numArray[j], ref numArray[j + 1]);
                    }
                }
            }
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void PrintSortedArray(int[] numArray)
        {
            int n = numArray.Length;
            Console.WriteLine("Sorted Array: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numArray[i] + " ");

            }
            Console.WriteLine();
        }

        static void PrintUnsortedArray(int[] numArray)
        {
            int n = numArray.Length;
            Console.WriteLine("Unsorted Array: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numArray[i] + " ");

            }
        }

        public static void Main()
        {
            int[] numArray = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = randNum.Next(0, 100);
            }

            PrintUnsortedArray(numArray);
            Sort(numArray);
            PrintSortedArray(numArray);
        }
    }
}
