using System;

public class Solution
{
    public int solution(int[,] sizes)
    {
        int maxWidth  = 0;
        int maxHeight = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int w = sizes[i, 0];
            int h = sizes[i, 1];

            int rowMax = Math.Max(w, h);
            int rowMin = Math.Min(w, h);

            if (rowMax > maxWidth) maxWidth = rowMax;
            if (rowMin > maxHeight) maxHeight = rowMin;
        }

        return maxWidth * maxHeight;
    }
}