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

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr) 
    {
        int counter = 0;
        bool[] met = new bool[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if ((arr[i] != (i+1)) && (met[i] == false))
            {
                met[i] = true;
                int j = (arr[i] - 1);
                int n = 0;
                while (met[j] == false)
                {
                    met[j] = true;
                    n++;
                    j = (arr[j] - 1);
                }
                counter = (counter + n);
            }
        }
        return counter;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
