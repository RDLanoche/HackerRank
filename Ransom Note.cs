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

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) 
    {
        bool b = true;
        Dictionary<string, int> magDict = new Dictionary<string, int>();
        int i = 0;
        foreach (string s in magazine)
        {
            if (magDict.ContainsKey(s))
            {
                magDict[s] = magDict[s] +1;
            }
            else 
            magDict.Add(s, 1);
        }
        foreach (string s in note)
        {
            if ((magDict.ContainsKey(s)) && (magDict[s] > 0))
            {
                magDict[s] = magDict[s] - 1;
            }
            else
            {
            Console.WriteLine("No");
            b = false;
            break;
            }
        }
        if (b == true)
        {
            Console.WriteLine("Yes");
        }
    }

    static void Main(string[] args) {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
