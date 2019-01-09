﻿using System.CodeDom.Compiler;
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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {

        HashSet<int> socks = new HashSet<int>();
        int pairs = 0;
        for(int i = 0; i < n; i++)
        {
            var sockValue = ar[i];
            if(!socks.Contains(sockValue))
            {
                socks.Add(sockValue);
            }
            else
            {
                pairs++;
                socks.Remove(sockValue);
            }
        }
        return pairs;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
