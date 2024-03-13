using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int totalQuantity = int.Parse(Console.ReadLine()); // 348
        int[] allOrders = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        //20 54 30 16 7 9

        Queue<int> queueAll = new Queue<int>(allOrders);

        int maxOrder = queueAll.Max(); // Find the maximum order before processing any orders
        Console.WriteLine(maxOrder);

        while (queueAll.Count > 0 && totalQuantity > 0)
        {
            int currentOrder = queueAll.Peek();

            if (totalQuantity - currentOrder >= 0)
            {
                totalQuantity -= queueAll.Dequeue();
            }
            else
            {
                break;
            }
        }

        if (queueAll.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine($"Orders left: {string.Join(", ", queueAll)}");
        }
    }
}
