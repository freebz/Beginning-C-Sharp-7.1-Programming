// 예제 4.8 프로퍼티 사용 예제

class Circle
{
    double pi = 3.14;

    public double Pi
    {
        get { return pi; }
        set { pi = value; }
    }

    // ...... [생략] ......
}

Circle o = new Circle();
o.Pi = 3.14159;         // 쓰기
double piValue = o.Pi;  // 읽기