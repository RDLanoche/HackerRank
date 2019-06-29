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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) 
    {
        Dictionary<int, double> arDict = new Dictionary<int, double>();
        foreach (int arValue in ar) 
        {
            if (arDict.ContainsKey(arValue))
                arDict[arValue] = arDict[arValue] + 0.5;
            else
                arDict.Add(arValue, 0.5);
        }
        double sockPairs = 0;
        foreach (KeyValuePair<int, double> pair in arDict)
        {
            sockPairs = sockPairs + (Math.Floor(pair.Value));
        }
        int totPairs = Convert.ToInt32(sockPairs);
        return totPairs;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
