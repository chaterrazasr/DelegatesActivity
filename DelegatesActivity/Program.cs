using System;

class Program
{
    delegate int MathOperation(int a, int b);

    static int Add(int a, int b)
    {
        Console.WriteLine("Add result:"+ (a+b));
        return a + b;
    }
    
    static int Subtract(int a, int b)
    {
        Console.WriteLine("Subtract result:"+ (a-b));
        return a - b;
    }

    static void Main(string[] args)
    {
    MathOperation operation = new MathOperation(Add);

    int addResult = operation(3, 2);
    Console.WriteLine("Addition result: " + addResult);

    operation = new MathOperation(Subtract);

    int subtractResult = operation(3, 2);
    Console.WriteLine("Subtraction result: " + subtractResult);

    }
}
