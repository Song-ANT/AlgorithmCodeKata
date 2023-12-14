using System;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Drawing;
using System.Reflection;
using System.Threading;
using Microsoft.VisualBasic;
using System.Linq;
using System.ComponentModel.Design;

namespace AlgorithmCodeKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Q_048_NumOfKth res = new();
            var answer = res.solution(new int[] { 1, 5, 2, 6, 3, 7, 4}, new int[,] { {2,5,3 }, {4, 4, 1 }, {1, 7, 3 } });

            //Console.WriteLine(answer);
            foreach (var i in answer)
            {
                Console.WriteLine(i);
            }
        }
    }
}


