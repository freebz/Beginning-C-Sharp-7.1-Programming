// 예제 5.1 Author 특성

class AuthorAttribute : System.Attribute
{
    string name;

    public AuthorAttribute(string name)
    {
        this.name = name;
    }
}

[Author("Anders")]  // new Author("Anders");와 같은 사용 구문을 연상하면 된다.
class Program
{
    static void Main(string[] args)
    {
    }
}