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

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        int star = 1;
        int space = n - 1;
        while (n > 0)
        {

            for (int i = 0; i < space; i++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < star; j++)
            {
                Console.Write("#");
            }
            star = star + 1;
            space = space - 1;
            n--;
            Console.WriteLine("");

        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
        Console.ReadKey();
    }
    
}

