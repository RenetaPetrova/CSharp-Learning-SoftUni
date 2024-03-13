Stack<int> inputData = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

string command = Console.ReadLine().ToLower();
while (command != "end")
{
    string[] actions = command.Split(' ');
    if (actions.Contains("add"))
    {
        int firstNum = int.Parse(actions[1]);
        int secondNum = int.Parse(actions[2]);
        inputData.Push(firstNum);
        inputData.Push(secondNum);
    }
    else if (actions.Contains("remove"))
    {
        int n = int.Parse(actions[1]);
        if(n <= inputData.Count)
        {
            for (int i = 0; i < n; i++)
            {
               inputData.Pop();
            }
        }
    }
    
    command = Console.ReadLine().ToLower();
}
int total = 0;
while(inputData.Count > 0)
{
    total += inputData.Pop();
}
Console.WriteLine($"Sum: {total}");