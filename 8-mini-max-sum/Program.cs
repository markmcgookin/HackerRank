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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        var minArr = new int[arr.Length];
        Array.Sort(arr);
        Array.Copy(arr, minArr, arr.Length);
        Array.Reverse(arr);
        long min = 0;
        long max = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            max += arr[i];
            min += minArr[i];
        }

        var textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        textWriter.WriteLine($"{min} {max}");
        textWriter.Flush();
        textWriter.Close();
    }

    static void Main(string[] args)
    {
        //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] arr = new int[5];
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        arr[4] = 5;
        miniMaxSum(arr);
    }
}
