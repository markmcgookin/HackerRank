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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        float p = 0, n = 0, z = 0;
        foreach (var x in arr)
        {
            if (x >= 1) { p++; }
            else if (x < 0) { n++; }
            else { z++; }
        }

        float pr = p / (float)arr.Length;
        float nr = n / (float)arr.Length;
        float zr = z / (float)arr.Length;
        
        var textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        textWriter.WriteLine(pr);
        textWriter.WriteLine(nr);
        textWriter.WriteLine(zr);
        textWriter.Flush();
        textWriter.Close();
    }

    static void Main(string[] args)
    {

        //int n = Convert.ToInt32(Console.ReadLine());
        //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        var arr = new int[] { -4, 3, -9, 0, 4, 1 }; //p = 3, n = 2, z = 1
        plusMinus(arr);
    }
}
