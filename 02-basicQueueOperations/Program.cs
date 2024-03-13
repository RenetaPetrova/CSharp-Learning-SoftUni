int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 4 1 666
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 420 69 13 666

Queue <int> queue = new Queue<int>(input.Take(values[0])); // Create a new stack with the first 'elToPush' elements: 420 69 13 666
int elToPop = values[1];
int searchEl = values[2]; // search for 666

while (queue.Count > 0 && elToPop > 0)
{
    queue.Dequeue();
    elToPop--; // remove the last 'elToPop' elements
}

if (queue.Contains(searchEl))
{
    Console.WriteLine("true"); // print true if the searched element is found
}
else if (queue.Count == 0)
{
    Console.WriteLine(0); // if there are no elements, print 0 
}
else
{
    Console.WriteLine(queue.Min()); // no searched element but with items in the stack
}
