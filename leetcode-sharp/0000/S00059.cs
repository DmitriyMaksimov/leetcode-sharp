﻿namespace leetcode_sharp;

// 59. Spiral Matrix II
// https://leetcode.com/problems/spiral-matrix-ii/
public class S00059
{
    public int[][] GenerateMatrix(int k)
    {
        var matrix = new int[k][];
        for (var i = 0; i < k; i++)
        {
            matrix[i] = new int[k];
        }
        
        var n = matrix.Length;
        var m = matrix[0].Length;
        var left = 0;
        var right = m - 1;
        var bottom = n - 1;
        var top = 0;
        var direction = 1;
        var result = new List<int>();
        var index = 1;

        while (left <= right && top <= bottom)
        {
            switch (direction)
            {
                case 1:
                {
                    for (var i = left; i <= right; i++)
                    {
                       matrix[top][i] = index++;
                    }

                    direction = 2;
                    top++;
                    break;
                }
                case 2:
                {
                    for (var i = top; i <= bottom; i++)
                    {
                        matrix[i][right] = index++;
                    }

                    direction = 3;
                    right--;
                    break;
                }
                case 3:
                {
                    for (var i = right; i >= left; i--)
                    {
                        matrix[bottom][i] = index++;
                    }

                    direction = 4;
                    bottom--;
                    break;
                }
                case 4:
                {
                    for (var i = bottom; i >= top; i--)
                    {
                        matrix[i][left] = index++;
                    }

                    direction = 1;
                    left++;
                    break;
                }
            }
        }

        return matrix;
    }
}