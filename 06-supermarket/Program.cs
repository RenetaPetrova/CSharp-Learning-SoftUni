using System.Collections;

string input = Console.ReadLine();
Queue<string> allCustomers = new Queue<string>();

while(input !="End")
{   
    if(input == "Paid")
    {
        while(allCustomers.Count > 0)
        {
            // Print customer names from the queue and empty the queue
            Console.WriteLine(allCustomers.Dequeue());
        }
    }
    else
    {
        allCustomers.Enqueue(input);
    }
    input = Console.ReadLine();
}

Console.WriteLine($"{allCustomers.Count} people remaining.");