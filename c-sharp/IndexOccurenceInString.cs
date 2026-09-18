Console.WriteLine(new Solution().StrStr("sadbutsad", "sad"));

public class Solution {
    public int StrStr(string haystack, string needle) {
        return haystack.IndexOf(needle);
    }
}