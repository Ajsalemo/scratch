class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x < 0:
            print("This is not a palindrome")
            return False
        else:
            if x > 0 and x < 10:
                print("This is a palindrome")
                return True
            o = True if str(x) == str(x)[::-1] else False
            print(o)
            return o


s = Solution()
print(s.isPalindrome(121))
print(s.isPalindrome(-121))
print(s.isPalindrome(10))