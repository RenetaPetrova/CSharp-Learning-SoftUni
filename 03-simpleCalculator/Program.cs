string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
Stack<string> calculator = new Stack<string>(input);

while (calculator.Count > 1)
{
    int firstNum = int.Parse(calculator.Pop());
    string op = calculator.Pop();
    int secondNum = int.Parse(calculator.Pop());

    if (op == "+")
    {
        calculator.Push((firstNum + secondNum).ToString());
    }
    else
    {
        calculator.Push((firstNum - secondNum).ToString());
    }   
}
Console.WriteLine(calculator.Pop());