// 예제 4.7 클래스의 인스턴스를 단 하나만 만드는 예제

class Person
{
    static public Person President = new Person("대통령"); // public 정적 필드
    string _name;

    private Person(string name) // private 인스턴스 생성자
    {
        _name = name;
    }

    public void DisplayName()  // public 인스턴스 메서드
    {
        Console.WriteLine(_name);
    }
}