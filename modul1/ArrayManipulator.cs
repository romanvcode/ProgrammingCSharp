using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace modul1
{
    public class ArrayManipulator
    {
        public static int[] GenerateRandomArray(int length, int min, int max)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Random random = new Random();
                array[i] = random.Next(min, max);
            }

            return array;
        }

        public static int FindMax(int[] array)
        {
            int max = array[0];
            foreach (int item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static void SortArray(int[] array)
        {
            Array.Sort(array);
        }
    }
}
