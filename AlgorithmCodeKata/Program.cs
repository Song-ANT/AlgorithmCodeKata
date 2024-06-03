
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





