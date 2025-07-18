
Console.WriteLine("Hello and welcome to the Task Tracker App!");

bool active = true;
while (active)
{
    Console.WriteLine("--------------------------");
    Console.WriteLine("What would you like to do?");
    string input = Console.ReadLine() ?? string.Empty;

    switch (input) 
    {
        case "":
            Console.WriteLine("You entered an empty command. Please try again.");
            break;

        case "done":
            Console.WriteLine("Exiting the Task Tracker App. Goodbye!");
            active = false;
            break;
    }
}
