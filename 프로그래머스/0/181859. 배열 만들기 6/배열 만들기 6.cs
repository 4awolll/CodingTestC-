using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        Stack<int> stk = new Stack<int>();

        foreach (int num in arr)
        {
            if (stk.Count == 0)
            {
                stk.Push(num);
            }
            else if (stk.Peek() == num)
            {
                stk.Pop();
            }
            else
            {
                stk.Push(num);
            }
        }

        if (stk.Count == 0)
        {
            return new int[] { -1 };
        }

        int[] result = stk.ToArray();
        Array.Reverse(result);

        return result;
    }
}