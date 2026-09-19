class Solution:
    def removeElement(self, nums: list[int], val: int) -> int:
        if len(nums) == 0 or nums is None:
            return 0

        t = 0
        for i in range(len(nums)):
            if nums[i] != val:
                nums[t] = nums[i]
                t += 1
        return t