using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorithmsInCSharp.Sorting
{
    internal class MergeSort
    {
        //The best, average, and worst-case complexity of the merge sort algorithm is O(N*log N). 
        //The recurrence relation of merge sort is:
        //T(n)= Θ(1) if n=1 and 2T(n2)+Θ(n) if n>1
        //T(n) Represents the total time time taken by the algorithm to sort an array of size n.
        //2T(n/2) represents time taken by the algorithm to recursively sort the two halves of the array.
        //Since each half has n/2 elements, we have two recursive calls with input size as (n/2).
        //O(n) represents the time taken to merge the two sorted halves

        //The main reason why it is preferred to sort non-primitive types is stability which is not there in QuickSort.
        //For example Arrays.sort in Java uses QuickSort while Collections.sort uses MergeSort.
        static void Main(string[] args)
        {
            var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            var sortFunction = new MergeSort();
            var sortedArray = sortFunction.SortArray(array, 0, array.Length - 1);
        }
        public int[] SortArray(int[] array, int left, int right)
        {

            if (left < right)
            {
                int middle = left + (right - left) / 2;
                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);
                MergeArray(array, left, middle, right);
            }
            return array;
        }

        public void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;

            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];

            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }

        //Generic Merge Sort in c#
        static public void MainMerge<T>(T[] values, int left, int mid, int right) where T : IComparable<T>
        {
            T[] temp = new T[25];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (values[left].CompareTo(values[mid]) < 0)
                    temp[pos++] = values[left++];
                else
                    temp[pos++] = values[mid++];
            }

            while (left <= eol)
                temp[pos++] = values[left++];

            while (mid <= right)
                temp[pos++] = values[mid++];

            for (i = 0; i < num; i++)
            {
                values[right] = temp[right];
                right--;
            }
        }

        static public void SortMerge<T>(T[] values, int left, int right) where T : IComparable<T>
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(values, left, mid);
                SortMerge(values, (mid + 1), right);

                MainMerge(values, left, (mid + 1), right);
            }
        }
    }
}
