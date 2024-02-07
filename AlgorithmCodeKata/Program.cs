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
using static System.Collections.Specialized.BitVector32;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace AlgorithmCodeKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Q_061_Lottos res = new();
            var answer = res.solution(new int[] {44, 1, 0, 0, 31, 25}, new int[] {31, 10, 45, 1, 6, 19});

            //Console.WriteLine(answer);
            foreach (var i in answer)
            {
                Console.WriteLine(i);
            }
        }
    }
}


