// First implementation.
public class Solution {
    public string ReverseString(string s) 
    {
        char[] chars = s.ToArray();
        for (int i = 0; i < s.Length / 2; ++i)
        {
            var j = s.Length - 1 - i;
            chars[i] = s[j];
            chars[j] = s[i];
        }
        return new string(chars);
    }
}

// Second implementation.
public class Solution {
    public string ReverseString(string s) 
    {
        char[] chars = s.ToArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
