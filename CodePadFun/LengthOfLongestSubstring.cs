//3. Longest Substring Without Repeating Characters
//abcabcbb
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int count = 0;
        var set = new HashSet<Char>();
        for(int i=0; i<s.Length; i++)
        {
            if(!set.Add(s.CharAt(i)))            
                count = set.Size();
        }
    }
}