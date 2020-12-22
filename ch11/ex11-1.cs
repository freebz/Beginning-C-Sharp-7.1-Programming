// 예제 11.1 람다 식을 이용한 메서드 본문 구현

public class Vector
{
    double x;
    double y;

    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector Move(double dx, double dy) => new Vector(x + dx, y + dy);

    public void PrintIt() => Console.WriteLine(this);

    public override string ToString() => string.Format("x = {0}, y = {1}", x, y);
}