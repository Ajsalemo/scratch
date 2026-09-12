from typing import List


class Solution:
    def twoSum(self, nums: List[int], target: int):
        summed_arr = []
        for k, v in enumerate(nums):
            for j, w in enumerate(nums):
                if v + w == target and k != j and len(summed_arr) < 2:
                    summed_arr.extend([k, j])

        return summed_arr


s = Solution()
print(s.twoSum([2, 7, 11, 15], 9))
