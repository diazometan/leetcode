// https://leetcode.com/problems/max-consecutive-ones-iii/

public class Solution {
    public int LongestOnes(int[] nums, int k) {
        var left = 0;
        var right = 0;
        
        while (right < nums.Count())
        {
            if (nums[right] == 0)
            {
                k--;
            }
            if (k < 0)
            {
                if (nums[left] == 0)
                {
                    k++;
                }
                
                left++;
            }
            
            right++;
        }
        
        return right - left;
    }
}