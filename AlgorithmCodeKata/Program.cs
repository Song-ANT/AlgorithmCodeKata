using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace AlgorithmCodeKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Q_034_Descending res = new();
            var answer = res.solution("Zbcdefg");

            Console.WriteLine(answer);
            //foreach ( var i in answer )
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}

