using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr)
    {
        var rows = arr.Length;
        var lr = 0;
        var rl = 0;
        for (int i = 0; i < rows; i++)
        {
            lr += arr[i][i];
            rl += arr[(rows - 1) - i][i];
        }

        if (lr == rl) { return 0; }
        return lr > rl ? lr - rl : rl - lr;
    }

    static void Main(string[] args)
    {
        var textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(3);
        int[][] arr = new int[n][];

        arr[0] = Array.ConvertAll("11 2 4".Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        arr[1] = Array.ConvertAll("4 5 6".Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        arr[2] = Array.ConvertAll("10 8 -12".Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        //var arr = new int[,] { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } };

        //for (int i = 0; i < n; i++)
        //{
        //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //}

        int result = diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
