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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q) 
    {
        bool tooChaotic = true;
        int totBribes = 0;
        for(int i = q.Length -1; i >= 0; i--)
        {
            int j = i+1;

            if (q[i] == j)
            continue;
            else if ((i > 0) && (q[i-1] == j))
            {
                totBribes = totBribes + 1;
                q[i-1] = q[i];
                q[i] = j;
            }
            else if ((i>1) && (q[i-2] == j))
            {
                totBribes = totBribes + 2;
                q[i-2] = q[i-1];
                q[i-1] = q[i];
                q[i] = j;
            }
            else
            {
                tooChaotic = false;
                Console.WriteLine("Too chaotic");
                break;
            }
        }
        if (tooChaotic == true)
                Console.WriteLine(totBribes); 
    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
