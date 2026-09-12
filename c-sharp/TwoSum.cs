int[] result = Solution.TwoSum([2, 7, 11, 15], 9);
Console.WriteLine(string.Join(", ", result));

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        List<int> summedArray = [];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j && summedArray.Count < 2)
                {
                    summedArray.Add(i);
                    summedArray.Add(j);
                }
            }
        }

        return [.. summedArray];
    }
}
