using System;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace AlgorithmCodeKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Q_035_CalculationChange res = new();
            var answer = res.solution(3, 20, 4);

            Console.WriteLine(answer);
            //foreach ( var i in answer )
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}

