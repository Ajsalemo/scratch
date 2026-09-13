Console.WriteLine(new Solution().IsValid("([)]{}"));

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new();
        Dictionary<char, char> bpair = new() {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        foreach (char c in s)
        {
            if (bpair.TryGetValue(c, out char opening))
            {
                if (stack.Count == 0 || stack.Peek() != opening)
                {
                    return false;
                }
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}