// 예제 4.17 부모 클래스에서 정의한 메서드와 동일한 이름의 메서드를 자식 클래스에서 정의

class Mammal
{
    public void Move()
    {
        Console.WriteLine("이동한다.");
    }
}

class Lion : Mammal
{
    public void Move()
    {
        Console.WriteLine("네 발로 움직인다.");
    }
}

class Whale : Mammal
{
    public void Move()
    {
        Console.WriteLine("수영한다.");
    }
}

class Human : Mammal
{
    public void Move()
    {
        Console.WriteLine("두 발로 움직인다.");
    }
}