// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome contestant! State your name:");
string name;

name = Console.ReadLine();


Console.WriteLine($"Very well. Are you ready for the first question {name}?");
string ready = Console.ReadLine();

if (ready == "yes")
{
    Console.WriteLine(@"The first question: How many toes per foot does a normal human have?
    1. 2
    2. 5
    3. 26");

    string a = Console.ReadLine();
    if (a == "5")
    {
        Console.WriteLine("Correct!");
    }

    Console.WriteLine(@"Second question: How many humans are in the world right now?
    1. 400
    2. 7.8 billion
    3. 2 Million");

    string b = Console.ReadLine();
    if (b == "7.8 billion")
    {
        Console.WriteLine("Correct.");
    }

    Console.WriteLine(@"Am I a human?
    1. yes
    2. yes
    3. yes");

    string c = Console.ReadLine();
    if (c == "yes")
    {
        Console.WriteLine("...");

        Console.ReadLine();

        Console.WriteLine("Correct");
    }
}

else
{
    Console.WriteLine("Get the fuck out, the door is over there.");
}

Console.ReadLine();
