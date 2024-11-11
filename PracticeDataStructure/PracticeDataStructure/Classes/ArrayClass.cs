using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDataStructure.Classes
{
    public static class ArrayClass
    {
        public static void SortyArrayDescendingOrder(this int[] array)
        {
            if (array.Length == 0) return;

            // Find the maximum value in the array
            int maxValue = array[0];
            foreach (int num in array)
            {
                if (num > maxValue)
                    maxValue = num;
            }

            // Create a counting array with size max+1
            int[] count = new int[maxValue + 1];

            // Count each element
            foreach (int num in array)
            {
                count[num]++;
            }

            // Reconstruct the array in descending order
            int index = 0;
            for (int i = maxValue; i >= 0; i--)
            {
                while (count[i] > 0)
                {
                    array[index++] = i;
                    count[i]--;
                }
            }
        }

        public static int SecondSmallestElement(this int[] array)
        {
            int secondSmallestValue = 0;
            if (array.Length == 0) return secondSmallestValue;

            // Find the maximum value in the array
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                    max = num;
            }

            // Create a counting array with size max+1
            int[] count = new int[max + 1];

            // Count each element
            foreach (int num in array)
            {
                count[num]++;
            }

            // Reconstruct the array in ascending order
            int index = 0;
            for (int i = 0; i <= max; i++)  // Start from the smallest to the largest
            {
                while (count[i] > 0)
                {
                    array[index++] = i;
                    count[i]--;
                }
            }
            secondSmallestValue = array[1];
            return secondSmallestValue;

        }

        public static int FindMedianSortedArrays(this int[] nums1, int[] nums2)
        {
            int median = 0;
            int[] mergedArray = new int[nums1.Length + nums2.Length];
            nums1.CopyTo(mergedArray, 0);
            nums2.CopyTo(mergedArray, nums1.Length);
            Array.Sort(mergedArray);
            if(mergedArray.Length%2 == 1)
            {
                median = mergedArray[mergedArray.Length / 2];
                return median;
            }
            else
            {
                median = (mergedArray[mergedArray.Length / 2] + mergedArray[(mergedArray.Length / 2)-1]) / 2;
                return median;
            }
            return 0;
        }
    }
}
