// https://leetcode.com/problems/single-number/
// Given an array of integers, every element appears twice except for one. Find that single one.
// Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        HashSet<int> temp = new HashSet<int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (!(temp.Add(nums[i])))
            {
                temp.Remove(nums[i]);
            }
        }
        return temp.First();
    }
}

