public class Q_054_2016
{

    //문제 설명
    //2016년 1월 1일은 금요일입니다. 2016년 a월 b일은 무슨 요일일까요? 두 수 a, b를 입력받아 2016년 a월 b일이 무슨 요일인지 리턴하는 함수, solution을 완성하세요. 요일의 이름은 일요일부터 토요일까지 각각 SUN, MON, TUE, WED, THU, FRI, SAT

    //입니다. 예를 들어 a= 5, b= 24라면 5월 24일은 화요일이므로 문자열 "TUE"를 반환하세요.

    //제한 조건
    //2016년은 윤년입니다.
    //2016년 a월 b일은 실제로 있는 날입니다. (13월 26일이나 2월 45일같은 날짜는 주어지지 않습니다)
    //입출력 예
    //a b   result
    //5	24	"TUE"

    public string solution(int a, int b)
    {
        string[] daysForWeek = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

        // 1월 1일 금요일만큼을 SUN에서 건너뛰기 
        int firstDayAdd = 5;

        int[] daysForMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int dayCount = 0;

        for (int i = 1; i <= 12; i++)
        {
            if (i < a)
            {
                dayCount += daysForMonth[i - 1];
            }
            else if (i == a)
            {
                dayCount += b;
            }
        }

        // 1월1일부터 특정날짜까지 + 0부터 시작하지않는만큼 추가 + (0부터 시작하는 인덱스 처리) 
        string answer = daysForWeek[(dayCount + firstDayAdd - 1) % 7];

        return answer;
    }

}






