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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) 
    {
        long countAs = 0;
        foreach (char a in s)
        {
            if (a.Equals('a'))
                countAs++;
        }
        long sInN = Convert.ToInt64(Math.Floor((double)n/s.Length));
        /*Multiply number of As in previous step by how many 
        times the string fits in n */
        countAs = countAs * sInN;
        //add the number of As in the substring representing the remainder
        int partS = Convert.ToInt32(n % s.Length);
        string sub = s.Substring(0, partS);
        foreach (char a in sub)
        {
            if (a.Equals('a'))
                countAs++;
        }
        return countAs;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
