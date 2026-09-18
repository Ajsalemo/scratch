class Solution:
    def strStr(self, haystack: str, needle: str) -> int:
        try:
            return haystack.index(needle)
        except ValueError:
            return -1


s = Solution()
print(s.strStr("sadbutsad", "sadz"))