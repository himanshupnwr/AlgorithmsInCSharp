using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsInCSharp.Sorting
{
    internal class SelectionSort
    {
        //As the length of the array increases to N, the time complexity would be O(N²) because we use two nested loops.
        //The algorithm has a space complexity of O(1) as the sorting process doesn’t need an extra array to store the
        //final result. Selection sort is ideal for sorting values that do not occupy a lot of memory
        //Selection Sort 	Ω(n^2) 	Θ(n^2) 	O(n^2) 	O(1)
        public int[]? NumArray { get; set; }
        public int[] SortArray()
        {
            var arrayLength = NumArray.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (NumArray[j] < NumArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = NumArray[smallestVal];
                NumArray[smallestVal] = NumArray[i];
                NumArray[i] = tempVar;
            }
            return NumArray;
        }
    }
}
