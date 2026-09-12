Console.WriteLine(new Solution().RomanToInt("MCMXCIV"));

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanMap = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;

        string normalizePairs = s.Replace("IV", ",4,")
                                     .Replace("IX", ",9,")
                                     .Replace("XL", ",40,")
                                     .Replace("XC", ",90,")
                                     .Replace("CD", ",400,")
                                     .Replace("CM", ",900,");

        string[] parts = normalizePairs.Split(',', StringSplitOptions.RemoveEmptyEntries);
        string joinedParts = string.Join(",", parts);
        
        foreach (KeyValuePair<char, int> numeral in romanMap)
        {
            joinedParts = joinedParts.Replace(numeral.Key.ToString(), $",{numeral.Value.ToString()},");
        }

        string[] newList = joinedParts.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string item in newList)
        {
            total += int.Parse(item);
        }

        return total; 
    }
}