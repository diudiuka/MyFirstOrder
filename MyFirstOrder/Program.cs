using System;

namespace MyFirstOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 99, 98, 92, 97, 98, 456, 86 };
            marks = Sort(marks);
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }

        }
        static int[] Sort(int[] a)
        {
            int[] result = new int[a.Length];
            int mim5 = FindMinButMoreThan(a, 0);
            Console.WriteLine("min: " + mim5);
            return result;
        }

        static int FindMinButMoreThan(int[] array, int intAfter)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min && array[i] > intAfter)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
