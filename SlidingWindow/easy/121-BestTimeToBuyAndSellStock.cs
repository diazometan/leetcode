// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

public class Solution {
    public int MaxProfit(int[] prices) {
        var result = 0;
        var left = 0;
        var right = 1;
        
        while (right < prices.Count())
        {
            if (prices[left] < prices[right])
            {
                result = Math.Max(result, prices[right] - prices[left]);
            }
            else
            {
                left = right;
            }

            right++;
        }
        
        return result;
    }
}