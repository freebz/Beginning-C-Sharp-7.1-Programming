// 예제 7.1 박싱이 발생하는 Stack 구현

using System;

public class OldStack
{
    object[] _objList;
    int _pos;

    public OldStack(int size)
    {
        _objList = new object[size];
    }

    public void Push(object newValue)
    {
        _objList[_pos] = newValue;
        _pos++;
    }

    public object Pop()
    {
        _pos--;
        return _objList[_pos];
    }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            OldStack stack = new OldStack(10);
            stack.Push(1); // 박싱 발생
            stack.Push(2); // 박싱 발생
            stack.Push(3); // 박싱 발생

            Console.WriteLine(stack.Pop()); // 언박싱 발생
            Console.WriteLine(stack.Pop()); // 언박싱 발생
            Console.WriteLine(stack.Pop()); // 언박싱 발생
        }
    }
}