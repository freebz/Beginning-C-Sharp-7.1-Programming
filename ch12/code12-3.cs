using System;

class Program
{
    static void Main(string[] args)
    {
        CallVal();
        CallRef();
    }

    private static void CallVal()
    {
        IntList intList = new IntList();
        int[] list = intList.GetList(); // IntList에 정의된 list 요소를 바꾸기 위해 목록 반환
        list[0] = 5; // list[0]의 요소를 변경

        intList.Print(); // 출력 결과: 5,2,
    }

    private static void CallRef()
    {
        IntList intList = new IntList();
        ref int item = ref intList.GetFirstItem();
        item = 5; // 참조값이므로 값을 변경하면 원래의 int [] 배열에도 반영

        intList.Print(); // 출력 결과: 5,2,
    }
}

class IntList
{
    int[] list = new int[2] { 1, 2 };

    public int [] GetList()
    {
        return list;
    }

    public ref int GetFirstItem()
    {
        return ref list[0];
    }

    internal void Print()
    {
        Array.ForEach(list, (e) => Console.Write(e + ","));
        Console.WriteLine();
    }
}