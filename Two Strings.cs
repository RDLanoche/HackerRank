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

    // Complete the twoStrings function below.
    static string twoStrings(string s1, string s2) 
    {
        string answer;
        bool b = false;
        Dictionary<char, bool> dict = new Dictionary<char, bool>();
        foreach (char c in s1)
        {
            dict[c] = true;
        }
        foreach (char c in s2)
        {
            if ((dict.ContainsKey(c)) && (dict[c] == true))
            {
                b = true;
                break;
            }
        }
        if (b == true)
            answer = "YES";
        else
            answer = "NO";
        return answer;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = twoStrings(s1, s2);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
