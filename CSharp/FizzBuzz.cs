public class Solution 
{
    public IList<string> FizzBuzz(int n) 
    {
        var list = new List<string>();
        for (int i = 1; i <= n; ++i)
        {
            string s = null;
            if (i % 3 == 0)
            {
                s += "Fizz";
            }
            if (i % 5 == 0)
            {
                s += "Buzz";
            }
            
            list.Add(s ?? i.ToString());
        }
        return list;
    }
}
