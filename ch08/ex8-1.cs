// 예제 8.1 생성자를 이용한 상태 변수 초기화

using System;

class Person
{
    string _name;
    int _age;

    public Person() // 기본 생성자
        : this(string.Empty, 0)
    {
    }

    public Person(string name) // name만 초깃값을 전달받는 생성자
        : this(name, 0)
    {
    }

    public Person(string name, int age) // name, age 모두 초깃값을 전달받는 생성자
    {
        _age = age;
        _name = name;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}

class Person2
{
    string _name;
    int _age;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}

class Person3
{
    public string _name;
    int _age;

    public Person3()
    {
    }

    public Person3(int age)
    {
        _age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person("Anders", 10);

        // 두 멤버 변수에 대한 다양한 초기화를 지원
        Person2 p1 = new Person2();
        Person2 p2 = new Person2 { Name = "Anders" };
        Person2 p3 = new Person2 { Age = 10 };
        Person2 p4 = new Person2 { Name = "Anders", Age = 10 };

        Person3 p5 = new Person3();
        Person3 p6 = new Person3(10) { _name = "Anders" }; // 생성자 + 객체 초기화
    }
}