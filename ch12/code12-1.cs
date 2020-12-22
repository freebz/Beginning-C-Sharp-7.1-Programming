// 더욱 편리해진 out 매개변수 사용

class Program
{
    static void Main(string[] args)
    {
        int result; // 변수를 미리 선언
        int.TryParse("5", out result);

        int.TryParse("5", out int result2);

        int.TryParse("5", out var result3); // out int result3로 컴파일러가 대신 처리

        int.TryParse("5", out int _); // 변수명 대신 밑줄(underline: _)로 생략
        int.TryParse("5", out var _);
    }
}