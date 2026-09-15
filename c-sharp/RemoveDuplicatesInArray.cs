Console.WriteLine(new Solution().RemoveDuplicates([1, 1, 2]));

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var distinctArray = nums.Distinct().ToList();
        Console.WriteLine(string.Join(", ", distinctArray));
        
        int v = 0;
        for (int i = 0; i < distinctArray.Count; i++)
        {
            nums[i] = distinctArray[i];
            v++;
        }

        return v;
    }
}

