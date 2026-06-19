using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int solution(int[] arr)
    {
        int answer = 0;

        List<int> cur = arr.ToList();

        while (true)
        {
            List<int> pre = new List<int>(cur);

            for (int i = 0; i < cur.Count; i++)
            {
                if (cur[i] >= 50 && cur[i] % 2 == 0)
                {
                    cur[i] /= 2;
                }

                else if (cur[i] < 50 && cur[i] % 2==1)
                {
                    cur[i] = cur[i] * 2 + 1;
                }
            }


            if(cur.SequenceEqual(pre))
            {
                return answer;
            }

            answer++;
        }
    }
}