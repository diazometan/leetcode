// https://leetcode.com/problems/valid-anagram/

public class Solution {
    public bool IsAnagram(string s, string t) {
        var letters = new Dictionary<char, int>();

        foreach (var letter in t)
        {
            if (!letters.ContainsKey(letter))
            {
                letters[letter] = 0;
            }
            
            letters[letter] += 1;
        }
        
        foreach (var letter in s)
        {
            if (!letters.ContainsKey(letter))
            {
                return false;
            }
            
            letters[letter] -= 1;
        }
        
        foreach (var (key, value) in letters)
        {
            if (value != 0)
            {
                return false;
            }
        }
        
        return true;
    }
}