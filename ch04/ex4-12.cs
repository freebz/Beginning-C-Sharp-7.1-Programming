// 예제 4.12 as의 잘못된 사용 예

int n = 5;
if ((n as string) != null)  // 컴파일 오류 발생
{
    Console.WriteLine("변수 n은 string 타입");
}

string txt = "text";
if ((txt as int) != null)   // 컴파일 오류 발생
{
    Console.WriteLine("변수 txt는 int 타입");
}