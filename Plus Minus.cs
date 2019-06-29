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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) 
    {
        double sumZeroes = 0;
        double sumNegatives = 0;
        double sumPositives = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                sumNegatives++;
            }
            else if (arr[i] == 0)
            {
                sumZeroes++;
            }
            else if (arr[i] > 0)                
            {
                sumPositives++;
            }
        }
        double ratioPositives = (sumPositives / arr.Length);
        double ratioZeroes = (sumZeroes / arr.Length);
        double ratioNegatives = (sumNegatives / arr.Length);
        Console.WriteLine(ratioPositives.ToString("N6"));
        Console.WriteLine(ratioNegatives.ToString("N6"));
        Console.WriteLine(ratioZeroes.ToString("N6"));
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
