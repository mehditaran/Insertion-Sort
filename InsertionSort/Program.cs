using System;

namespace InsertionSort
{
    public static class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }         
        }
        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, -1, 2, 4, 9, 3, 6, 2 };
            InsertionSort.Sort(arr);
            InsertionSort.PrintArray(arr);
        }
    }
}
