using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsInCSharp.Sorting
{
    internal class InsertionSort
    {
        public int[] SortArray(int[] array, int length)
        {
            for (int i = 1; i < length; i++)
            {
                var key = array[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
            return array;
        }

        //Recursive Implementation - although its slower than iterative implementation
        public int[] SortArrayRecursive(int[] array, int length)
        {
            if (length <= 1)
            {
                return array;
            }
            SortArrayRecursive(array, length - 1);
            var key = array[length - 1];
            var k = length - 2;
            while (k >= 0 && array[k] > key)
            {
                array[k + 1] = array[k];
                k = k - 1;
            }
            array[k + 1] = key;
            return array;
        }
    }
}
