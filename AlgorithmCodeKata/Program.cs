using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace AlgorithmCodeKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Q_020_Orderby res = new();
            var answer = res.solution(118372);

            Console.WriteLine(answer);
        }
    }
}
