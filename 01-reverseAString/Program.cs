using System.Collections.Generic;

string input = Console.ReadLine();
Stack<char> stackOfChars = new Stack<char>();
foreach(var letter in input)
{
    stackOfChars.Push(letter);
}
while (stackOfChars.Count > 0)
{
    Console.Write(stackOfChars.Pop());
}