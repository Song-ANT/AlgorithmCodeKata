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
using static System.Formats.Asn1.AsnWriter;

namespace AlgorithmCodeKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Q_055_Cards res = new();
            var answer = res.solution(new string[] { "i", "drink", "water" }, new string[] { "want", "to" }, new string[] { "i", "want", "to", "drink", "water" });

            Console.WriteLine(answer);
            //foreach (var i in answer)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
