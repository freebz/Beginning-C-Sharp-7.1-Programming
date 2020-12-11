// 예제 4.5 생성자를 여러 개 사용

class Book
{
    public string Title;
    public decimal ISBN13;
    public string Author;

    public Book(string title)
    {
        Title = title;
    }

    public Book(string title, decimal isbn13)
    {
        Title = title;
        ISBN13 = isbn13;
    }

    public Book(string title, decimal isbn13, string author)
    {
        Title = title;
        ISBN13 = isbn13;
        Author = author;
    }

    // ...... 생략 ......
}