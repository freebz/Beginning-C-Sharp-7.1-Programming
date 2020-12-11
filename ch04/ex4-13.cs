// 예제 4.13 참조 형식의 Equals 메서드의 동작 방식

class Book
{
    decimal _isbn;

    public Book(decimal isbn)
    {
        _isbn = isbn;
    }
}

Book book1 = new Book(9788998139018);
Book book2 = new Book(9788998139018);

Console.WriteLine(book1.Equals(book2)); // 출력 결과: False