using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;


public class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        char[] chars = s.ToCharArray();
        List<char> aux = new List<char>();
        int currValue = 0;
        bool isStart = true;
        int start = 0;
        for (int i = 0; i < chars.Count(); i++)
        {
            if (aux.Contains(chars[i]))
            {
                if (aux.Count > currValue)
                {
                    currValue = aux.Count;
                }
                aux.Clear();
                i = start;
                isStart = true;
                continue;
            }
            if (isStart)
            {
                start = i;
            }
            isStart = false;
            aux.Add(chars[i]);
        }
        if (aux.Count > currValue)
        {
            currValue = aux.Count;
        }
        return currValue;
    }
}