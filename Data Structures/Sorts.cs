using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Sorts
    {
        public static void BubbleSort(int[] list)
        {
            int temp;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[i] < list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;                      
                    }
                }
            }
        } 
        public static void SelectionSort(int[] list)
        {
            int temp;
            for (int i = 0; i < list.Length; i++)
            {
                int smallestIndex = i;
                for (int j = i; j < list.Length; j++)
                {                    
                    if (list[j] < list[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                if (i != smallestIndex)
                {
                    temp = list[i];
                    list[i] = list[smallestIndex];
                    list[smallestIndex] = temp;
                }

               
            }
        }




        public static void InsertionSort(int[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                int j = i;

                while (j > 0 && list[j] < list[j - 1])
                {
                    Swap(ref list[j], ref list[j - 1]);

                    j--;
                }
            }
        }

        public static void FixedInsertionSort(int[] list)
        {
            //looping from 0 to second to last index to be able to compare a value in front of the current index
            for (int i = 1; i < list.Length; i++)
            {
                //for (int j = i + 1; j > 0; j--)
                //int j = i + 1;
                int j = i;

                Console.WriteLine($"I: {i}, J: {j}");

                while (j > 0 && list[j] < list[j - 1])
                {
                    Swap(ref list[j], ref list[j - 1]);
                    j--;
                }
            }
        }

        /// <summary>
        /// Swaps variable values
        /// </summary>
        /// <remarks>Using ref so we keep the original memory address</remarks>
        /// <param name="a">First Value</param>
        /// <param name="b">Second Value</param>
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }



    }
}
