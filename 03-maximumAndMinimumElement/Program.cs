int n = int.Parse(Console.ReadLine()); 
Stack <int> stack = new Stack<int>(); // create a new empty stack

for (int i = 0; i < n; i++)
{
    int[] currentData = Console.ReadLine().Split().Select(int.Parse).ToArray(); 


    if (currentData[0] == 1)
    {
        stack.Push(currentData[1]);
    }
    else if (currentData[0] == 2) 
    {
        stack.Pop();
    }
    else if(currentData[0] == 3)

    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Max());
        }
    }
    else if (currentData[0] == 4)
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Max());
        }
    }
}
Console.WriteLine(string.Join(", ", stack));