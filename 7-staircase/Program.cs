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

    // Complete the staircase function below.
    static void staircase(int n)
    {
        var textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //Height loop
        for (int i = 1; i <= n; i++)
        {
            for (int x = 1; x <= n; x++)
            {
                if ((n - i) >= x) { textWriter.Write(" "); }
                else { textWriter.Write("#"); }
            }
            
            if (i < n) { textWriter.WriteLine(); }
        }

        textWriter.Flush();
        textWriter.Close();
    }

    static void Main(string[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine());
        int n = 5;
        staircase(n);
    }
}
