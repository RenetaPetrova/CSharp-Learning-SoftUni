using System;
using System.Collections.Generic;
using System.Linq;
int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Queue<int> numberQueue = new Queue<int>(numbers);

while (numberQueue.Count > 0)
    {
        int number = numberQueue.Dequeue();
            if (number % 2 == 0)
            {
                Console.Write(number);

                // Add a comma and space if there are more even numbers
                if (numberQueue.Any(n => n % 2 == 0))
                    {
                    Console.Write(", ");
                }
            }
        }
Console.WriteLine(); // Move to the next line after printing even numbers
