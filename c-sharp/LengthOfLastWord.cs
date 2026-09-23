Console.WriteLine(new Solution().LengthOfLastWord("   fly me   to   the moon  "));

public class Solution {
    public int LengthOfLastWord(string s) {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        var words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        return words[words.Length - 1].Length;
    }
}