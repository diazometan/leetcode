// https://leetcode.com/problems/longest-repeating-character-replacement/

public class Solution {
    public int CharacterReplacement(string s, int k) {
        var letters = new Dictionary<char, int>();
        
        var left = 0;
        var result = 0;
        var mostFreqLetter = 0;
        for (var right = 0; right < s.Length; right++)
        {
            if (!letters.ContainsKey(s[right]))
            {
                letters[s[right]] = 0;
            }
            letters[s[right]]++;
            
            mostFreqLetter = Math.Max(mostFreqLetter, letters[s[right]]);
            
            if (right - left + 1 - mostFreqLetter > k)
            {
                letters[s[left]]--;
                left++;
            }
            
            result = Math.Max(result, right - left + 1);
        }
        
        return result;
    }
}