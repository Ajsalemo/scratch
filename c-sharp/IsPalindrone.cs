
Console.WriteLine(new Solution().IsPalindrome(1221));
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        if (x > 0 && x < 10) return true;

        string str = x.ToString();
        string reversedStr = String.Concat(str.Reverse());

        if (str != reversedStr) return false;

        return true;
    }
}