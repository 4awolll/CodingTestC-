using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] str_list)
    {
        List<string> answer = new List<string>();

        int lIndex = Array.IndexOf(str_list, "l");
        int rIndex = Array.IndexOf(str_list, "r");

        if (rIndex == -1 && lIndex == -1)
        {
            return answer.ToArray();
        }

        if (lIndex != -1 && (rIndex == -1 || lIndex < rIndex))
        {
            for (int i = 0; i < lIndex; i++)
            {
                answer.Add(str_list[i]);
            }
        }
        else if (rIndex != -1 && (lIndex == -1 || rIndex < lIndex))
        {
            for (int i = rIndex + 1; i < str_list.Length; i++)
            {
                answer.Add(str_list[i]);
            }
        }

        return answer.ToArray();
    }
}