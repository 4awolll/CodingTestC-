using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int n)
    {
        HashSet<int> answer = new HashSet<int>();

        for(int i=2;i<=n;i++)
        {
            while(n % i == 0)
            {
                answer.Add(i);
                n /= i;
            }
        }

        return answer.ToArray();
    }
}