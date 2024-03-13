int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 4 1 666
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 420 69 13 666

Stack<int> stack = new Stack<int>(input.Take(values[0])); // Create a new stack with the first 'elToPush' elements: 420 69 13 666
int elToPop = values[1];
int searchEl = values[2]; // search for 666

while (stack.Count > 0 && elToPop > 0)
{
    stack.Pop();
    elToPop--; // remove the last 'elToPop' elements
}

if (stack.Contains(searchEl))
{
    Console.WriteLine("true"); // print true if the searched element is found
}
else if (stack.Count == 0)
{
    Console.WriteLine(0); // if there are no elements, print 0 
}
else
{
    Console.WriteLine(stack.Min()); // no searched element but with items in the stack
}
