// See https://aka.ms/new-console-template for more information
Console.WriteLine("Puzzle Version One, Tutorial");

Console.WriteLine("You are at the start of a puzzle. You can go up or you can go left. When you start moving in a direction, you don't stop until you hit a wall");
Console.WriteLine("Your goal is to reach the exit");

int x = 0;
int y = 0;
String direction = null;
String UpperDirection = null;
if (direction != null)
{
    UpperDirection = direction.ToUpper();
}


while (UpperDirection != "U" && UpperDirection != "L")
{
    Console.WriteLine("You can go up or you can go left");
    Console.WriteLine("U = Up, D = Down, L = Left, R = Right");
    direction = Console.ReadLine();
    UpperDirection = direction.ToUpper();

    if (direction != null)
    {
        if (UpperDirection == "U")
        {
            x = 0;
            y = 3;
        }
        else if (UpperDirection == "L")
        {
            x = 4;
            y = 0;
        }

    }
    else
    {
        Console.WriteLine("Try again....");
    }
}

Console.WriteLine("You hit a wall!");

if (x == 0 && y == 3)
{
    Console.WriteLine("You can go left or you can go down");
}
else if (x == 4 && y == 0)
{
    Console.WriteLine("You can go up or you can go left");
}
else
{
    Console.WriteLine("idk something went wrong...");
}

direction = Console.ReadLine();
UpperDirection = direction.ToUpper();

//Make the exit scenarios for each path......... 







