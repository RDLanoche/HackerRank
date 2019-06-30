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

class Solution {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) 
    {
        List<int> ar = new List<int>();
        foreach(char c in s)
        {
            if (c.Equals('U'))
            {
                ar.Add(1);
            }
            else
            {
                ar.Add(-1);
            }
        }
        int j = 0;
        string altitude = "level";
        int valley = 0;
        for (int i = 0; i < n; i++)
        {
            j = j + ar[i];
            if (j > 0)
            {
                altitude = "above";
            }
            else if (j < 0) 
            {
                altitude = "below";
            }
            if ((j == 0) && (ar[i] == +1) && (altitude.Equals("below")))
            {
                valley++;
            }
        }
        return valley;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
