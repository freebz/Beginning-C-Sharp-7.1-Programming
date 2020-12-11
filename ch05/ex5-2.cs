// 예제 5-2 타입의 범위를 넘어서는 연산

short c = 32767;
c++;
Console.WriteLine(c); // 출력 결과: -32768

int n = 32768;
c = (short)n;
Console.WriteLine(c); // 출력 결과: -32768