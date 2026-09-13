class Solution:
    def isValid(self, s: str) -> bool:
        map = {
            ')': '(',
            '}': '{',
            ']': '['
        }

        stack = []

        for c in s:
            if c in map:
                print(stack[-1])
                if len(stack) == 0 or stack[-1] != map[c]:
                    return False
                stack.pop()
            else:
                stack.append(c)

        return len(stack) == 0


s = Solution()
print(s.isValid("([)]{}"))