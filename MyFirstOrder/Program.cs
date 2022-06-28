﻿using System;

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
            int mim5 = FindMin(a);
            Console.WriteLine("min: " + mim5);
            return result;
        }

        static int FindMin(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
