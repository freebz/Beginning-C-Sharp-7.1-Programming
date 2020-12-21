// 예제 8.10 Expression 타입으로 직접 구성한 식 트리

using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Expression<Func<int, int, int>> exp = (a, b) => a + b;

        // 람다 식 본체의 루트는 이항 연산자인 + 기호
        BinaryExpression opPlus = exp.Body as BinaryExpression;
        Console.WriteLine(opPlus.NodeType); // 출력 결과: Add

        // 이항 연산자의 좌측 연산자를 나타내는 표현식
        ParameterExpression left = opPlus.Left as ParameterExpression;
        Console.WriteLine(left.NodeType + ": " + left.Name); // 출력 결과: Parameter: a

        // 이항 연산자의 우측 연산자를 나타내는 표현식
        ParameterExpression right = opPlus.Right as ParameterExpression;
        Console.WriteLine(right.NodeType + ": " + right.Name); // 출력 결과: Parameter: b
        
        Func<int, int, int> func = exp.Compile();
        Console.WriteLine(func(10, 2)); // 출력 결과: 12



        ParameterExpression leftExp = Expression.Parameter(typeof(int), "a");
        ParameterExpression rightExp = Expression.Parameter(typeof(int), "b");
        BinaryExpression addExp = Expression.Add(leftExp, rightExp);

        Expression<Func<int, int, int>> addLambda =
            Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
                addExp, new ParameterExpression[] { leftExp, rightExp }
            );

        Console.WriteLine(addLambda.ToString()); // 출력 결과: (a, b) => (a + b)

        Func<int, int, int> addFunc = addLambda.Compile();
        Console.WriteLine(addFunc(10, 2)); // 출력 결과: 12
    }
}