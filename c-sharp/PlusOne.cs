using System.Numerics;

Console.WriteLine(new Solution().PlusOne([7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6]));

public class Solution {
    public int[] PlusOne(int[] digits) {
        string number = string.Join("", digits);
        // This handles problemsets where the int array overflows what a int64 can hold
        var num = BigInteger.Parse(number) + 1;
        var numArray = Array.ConvertAll(num.ToString().ToCharArray(), c => int.Parse(c.ToString()));

        return numArray;
    }
}