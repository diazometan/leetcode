// https://leetcode.com/problems/find-all-anagrams-in-a-string/

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var result = new List<int>();
        
        var letters = new Dictionary<char, int>();
        
        foreach (var letter in p)
        {
            if (!letters.ContainsKey(letter))
            {
                letters[letter] = 0;
            }
            
            letters[letter] += 1;
        }
        
        var left = 0;
        var counter = 0;
        for (var right = 0; right < s.Length; right++)
        {
            if (letters.ContainsKey(s[right]))
            {
                letters[s[right]]--;
                if (letters[s[right]] == 0)
                {
                    counter++;                    
                }
            }
            
            if (counter == letters.Count)
            {
                result.Add(left);
            }
            
            if (right - left + 1 == p.Length)
            {
                if (letters.ContainsKey(s[left]))
                {
                    if (letters[s[left]] == 0)
                    {
                        counter--;
                    }
                    letters[s[left]]++;
                }
                left++;
            }            
        }
        
        return result;
    }
}