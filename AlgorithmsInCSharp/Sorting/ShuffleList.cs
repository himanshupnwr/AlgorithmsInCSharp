using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsInCSharp.Sorting
{
    internal static class ShuffleList
    {
        public static void Shuffle<T>(this IList<T> list, Random? rnd = null)
        {
            rnd ??= Random.Shared;
            // [edited]
            for (int i = list.Count - 1; i > 0; i--)
                list.Swap(i, rnd.Next(i + 1));
        }

        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        //another way
        public static void Shufflearray()
        {
            List<int> listOfInt = new() { 1, 2, 3, 4, 5 };
            listOfInt = listOfInt.OrderBy(x => Random.Shared.Next()).ToList();
        }
    }
}
