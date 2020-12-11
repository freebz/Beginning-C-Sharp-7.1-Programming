// 예제 4.19 Book 타입의 Equals 개선

class Book
{
    decimal isbn13;
    string title;
    string contents;

    public Book(decimal isbn13, string title, string contents)
    {
        this.isbn13 = isbn13;
        this.title = title;
        this.contents = contents;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        Book book = obj as Book;
        if (book == null)
        {
            return false;
        }

        return this.isbn13 == book.isbn13;
    }
}