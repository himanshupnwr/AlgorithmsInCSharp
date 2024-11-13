namespace AlgorithmsInCSharp.SumAlgorithms
{

    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.
    internal class TwoSum
    {
        public int[] ToSumProblemUsingHashTable(int[] nums, int target)
        {
            Dictionary<int, int> map = new();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (map.ContainsKey(nums[i]))
                {
                    return new int[] { map[nums[i]], i };
                }
                map.TryAdd(diff, i);
            }
            return null;
        }

        //Naive Method – O(n^2) Time and O(1) Space
        static bool TwoSumWithBruteForce(int[] arr, int target)
        {
            int n = arr.Length;

            // Iterate through each element in the array
            for (int i = 0; i < n; i++)
            {

                // For each element arr[i], check every
                // other element arr[j] that comes after it
                for (int j = i + 1; j < n; j++)
                {

                    // Check if the sum of the current pair
                    // equals the target
                    if (arr[i] + arr[j] == target)
                    {
                        return true;
                    }
                }
            }

            // If no pair is found after checking
            // all possibilities
            return false;
        }

        //Time Complexity: O(n) as the loops runs at most n times. We either increase left, or decrease right or stop the loop.
        //Auxiliary Space: O(1)
        static bool TwoSumWithTwoPointers(int[] arr, int target)
        {

            // Sort the array
            Array.Sort(arr);

            int left = 0, right = arr.Length - 1;

            // Iterate while left pointer is less than right
            while (left < right)
            {
                int sum = arr[left] + arr[right];

                // Check if the sum matches the target
                if (sum == target)
                    return true;
                else if (sum < target)
                    left++; // Move left pointer to the right
                else
                    right--; // Move right pointer to the left
            }
            // If no pair is found
            return false;
        }
    }
}
