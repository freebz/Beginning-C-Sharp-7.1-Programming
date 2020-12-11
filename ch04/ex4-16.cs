// 예제 4.16 상속받는 경우 생성자로 인한 오류

class Book
{
    decimal isbn13;

    public Book(decimal isbn13)
    {
        this.isbn13 = isbn13;
    }
}

class EBook : Book
{
    public EBook()  // 에러 발생
    {
    }
}