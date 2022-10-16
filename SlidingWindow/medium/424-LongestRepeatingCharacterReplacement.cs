// https://leetcode.com/problems/longest-substring-without-repeating-characters/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var uniqLetters = new HashSet<char>();

        var left = 0;
        var right = 0;
        var maxResult = 0;
        
        while (right < s.Length)
        {
            if (!uniqLetters.Contains(s[right]))
            {
                uniqLetters.Add(s[right]);
                right++;
            }
            else
            {
                uniqLetters.Remove(s[left]);
                left++;
            }
            
            maxResult = Math.Max(maxResult, right - left);
        }
        
        return maxResult;
    }
}