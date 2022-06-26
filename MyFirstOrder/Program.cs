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

            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++) 
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }


            return result;

        }




    }
}
