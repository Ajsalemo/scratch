Console.WriteLine(new Solution().RemoveElement([0,1,2,2,3,0,4,2], 2));

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        int t = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                Console.WriteLine($"Current array state: {nums[t]} - {nums[i]}");
                nums[t] = nums[i];
                t++;
            }

        }

        Console.WriteLine(string.Join(",", nums));

        return t;
    }
}