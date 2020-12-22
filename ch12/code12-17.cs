// 자유로워진 throw 사용

public bool Assert(bool result) =>
#if DEBUG
    result == true ? result : throw new ApplicationException("ASSERT");
#else
    result;
#endif


public bool Assert(bool result) =>
#if DEBUG
    result == true ? result : AssertException("ASSERT");
#else
    result;
#endif

public bool AssertException(string msg)
{
    throw new ApplicationException(msg);
}


public void Assert(bool result) =>
#if DEBUG
    _ = result == true ? result : throw new ApplicationException("ASSERT");
#else
    _ = result;
#endif


class Person
{
    public string Name { get; }

    // null 병합 연산자(??)에서 throw 사용 가능
    public Person(string name) => Name name ??
                                throw new ArgumentNullException(nameof(name));
    
    // 람다 식으로 정의된 메서드에서 사용 가능
    public string GetLastName() => throw new NotImplementedException();

    public void Print()
    {
        // 단일 람다 식을 이용한 델리게이트 정의에서 사용 가능
        AssertException action = () => throw new System.Exception();
        action();
    }
}