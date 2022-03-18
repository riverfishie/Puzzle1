using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle1
{
    class TutorialPuzzle1
    {
        public void TutorialPuzzleMethod()
        {
            Console.WriteLine("Puzzle Version One, Tutorial");

            Console.WriteLine("You are at the start of a puzzle. You can go up or you can go left. When you start moving in a direction, you don't stop until you hit a wall");
            Console.WriteLine("Your goal is to reach the exit");

            int x = 0;
            int y = 0;
            String direction = null;
            String UpperDirection = null;



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
                direction = Console.ReadLine();
                UpperDirection = direction.ToUpper();

                if (UpperDirection == "L" || UpperDirection == "D")
                {
                    if (UpperDirection == "L")
                    {
                        x = 4;
                        y = 3;
                    }
                    else if (UpperDirection == "D")
                    {
                        x = 0;
                        y = 0;
                    }
                    else
                    {
                        Console.WriteLine("Try again...jk haven't finished this part yet");
                    }
                }
            }

            else if (x == 4 && y == 0)
            {
                Console.WriteLine("You can go up or you can go left");
                direction = Console.ReadLine();
                UpperDirection = direction.ToUpper();

                if (UpperDirection == "U" || UpperDirection == "L")
                {
                    if (UpperDirection == "U")
                    {
                        x = 4;
                        y = 3;
                    }
                    else if (UpperDirection == "L")
                    {
                        x = 0;
                        y = 0;
                    }
                    else
                    {
                        Console.WriteLine("Try again...jk haven't finished this part yet");
                    }
                }
            }
            else
            {
                Console.WriteLine("idk something went wrong...");
            }

            if (x == 4 && y == 3)
            {
                Console.WriteLine("Yay you win!!! You reached the end!!!");
            }
            else
            {
                Console.WriteLine("Lol I need to change it so that you can keep moving until you get to the end");
            }

            Console.WriteLine("End of Tutorial Puzzle 1");
        }
    }
}
