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

    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(string s) 
    {
        Dictionary<string, int> allAnas = new Dictionary<string, int>();
        char[] charArr = s.ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
            string str = "";
            for (int j = i; j < s.Length; j++)
            {
                str = String.Concat(str, charArr[j]);
                char[] strArr = str.ToCharArray();
                Array.Sort(strArr);
                str = new string(strArr);
                if (allAnas.ContainsKey(str))
                    allAnas[str] = allAnas[str] + 1;
                else
                    allAnas[str] = 1; 
            }
        }
        int totAnas = 0;
        List<int> total = new List<int>();
        foreach (KeyValuePair<string, int> entry in allAnas)
        {
            int countAnas = entry.Value;
            string keyAnas = entry.Key;

            totAnas += Convert.ToInt32(countAnas * (countAnas - 1) / 2 );
            total.Add(totAnas);
        }
        return totAnas;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            int result = sherlockAndAnagrams(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
