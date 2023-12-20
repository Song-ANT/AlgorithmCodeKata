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
            Q_051_FoodFight res = new();
            var answer = res.solution(new int[] { 1, 3, 4, 6 });

            //Console.WriteLine(answer);
            foreach (var i in answer)
            {
                Console.WriteLine(i);
            }
        }
    }
}


