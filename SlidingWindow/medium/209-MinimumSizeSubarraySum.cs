// https://leetcode.com/problems/minimum-size-subarray-sum/

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        var res = Int32.MaxValue;
        var left = 0;
        var sum = 0;
        
        for (var right = 0; right < nums.Count(); right++)
        {
            sum += nums[right];
            while (sum >= target)
            {
                res = Math.Min(res, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }
        
        return res == Int32.MaxValue ? 0 : res;
    }
}