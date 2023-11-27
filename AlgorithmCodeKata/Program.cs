using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace AlgorithmCodeKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Q_029_DeleteMin res = new();
            var answer = res.solution(new int[] {10});

            //Console.WriteLine(answer);
            foreach ( var i in answer )
            {
                Console.WriteLine(i);
            }
        }
    }



}
