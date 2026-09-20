class Solution:
    def searchInsert(self, nums: list[int], target: int) -> int:
        if len(nums) == 0:
            return 0

        if target in nums:
            return nums.index(target)
        else:
            if target > nums[len(nums) - 1]:
                return len(nums)
            elif target < nums[0]:
                return 0
            else:
                insertPoint = 0

                for i in range(len(nums)):
                    if i >= 0 and i < len(nums) - 1:
                        if target > nums[i] and target < nums[i + 1]:
                            insertPoint = i + 1
                            break

                return insertPoint


s = Solution()
print(s.searchInsert([1, 3, 5, 6], 2))
