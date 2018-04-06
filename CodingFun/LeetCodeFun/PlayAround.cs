using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeFun
{
    public class PlayAround
    {
        //3. Longest Substring Without Repeating Characters
        public int LengthOfLongestSubstring(string s)
        {
            int count = 0;
            var dic = new Dictionary<Char, int>();
            for (int i = 0; i < s.Length; i++)
                if (!dic.Keys.Contains(s.ElementAt(i)))
                    dic.Add(s.ElementAt(i), i);
                else
                {
                    int j = i;
                    i = dic[s.ElementAt(i)];
                    while (j < s.Length && dic.Keys.Contains(s.ElementAt(j)))
                    {                        
                        i = dic[s.ElementAt(j)] > i ? dic[s.ElementAt(j)] : i;
                        j++;
                    }
                    count = dic.Count > count ? dic.Count : count;
                    dic.Clear();
                    dic.Add(s.ElementAt(i+1), i+1);
                }

            count = dic.Count > count ? dic.Count : count;
            return count;
        }
    }
}
