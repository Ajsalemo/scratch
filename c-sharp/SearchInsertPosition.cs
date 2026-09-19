Console.WriteLine(new Solution().SearchInsert(new int[] { 1, 3, 5, 6 }, 2));

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        if (nums.Length == 0) return 0;

        if (nums.IndexOf(target) != -1)
        {
            return nums.IndexOf(target);
        }
        else
        {
            // If the target is greater than the last elements value, it should be inserted at the end.
            if (target > nums[nums.Length - 1])
            {
                return nums.Length;
            }
            // Else if its smaller than the first element, it should be inserted at the beginning.
            else if (target < nums[0])
            {
                return 0;
            }
            // Value wasm't found so iterate over the array for the insertion point
            // Check if the value is between two numbers
            else
            {
                int insertPoint = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i >= 0 && i < nums.Length - 1)
                    {
                        if (target > nums[i] && target < nums[i + 1])
                        {
                            insertPoint = i + 1;
                        }
                    }
                }
                return insertPoint;
            }
        }
    }
}