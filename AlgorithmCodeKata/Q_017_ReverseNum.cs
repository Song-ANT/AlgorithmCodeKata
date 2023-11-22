public class Q_017_ReverseNum
{
    //문제 설명
    // 자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 리턴해주세요.예를들어 n이 12345이면[5, 4, 3, 2, 1] 을 리턴합니다.

    // 제한 조건
    //n은 10,000,000,000이하인 자연수입니다.
    //입출력 예
    //n	return
    //12345	[5,4,3,2,1]



    public int[] solution(long n)
    {
        List<int> list = new List<int>();

        int count = 0;
        long num = n;

        while (num > 0)
        {
            count++;
            list.Add((int)(num % 10));
            num /= 10;
        }

        int[] answer = new int[count];

        for (int i = 0; i < count; i++)
        {
            answer[i] = list[i];
        }

        return answer;
    }

}