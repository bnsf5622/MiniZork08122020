﻿using System;

namespace MiniZork08122020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are standing in an open field West of a white house,");
            Console.WriteLine("With a boarded front door.");
            Console.WriteLine("There is a small mailbox here.");
            Console.Write("Go to the house, or open the mailbox? ");

            String action = Console.ReadLine();

            if (action.Equals("open the mailbox"))
            {
                Console.WriteLine("You open the mailbox.");
                Console.WriteLine("It's really dark in there.");
                Console.Write("Look inside or stick your hand in? ");
                action = Console.ReadLine();

                if (action.Equals("look inside"))
                {
                    Console.WriteLine("You peer inside the mailbox");
                    Console.WriteLine("It's really dark inside the Mailbox.");
                    Console.Write("Run away or keep looking? ");
                    action = Console.ReadLine();

                    if (action.Equals("keep looking"))
                    {
                        Console.WriteLine("Turns out, hanging out around dark places isn't a good idea.");
                        Console.WriteLine("You've been eaten by a grue.");
                    }
                    else if (action.Equals("run away"))
                    {
                        Console.WriteLine("You run away screaming ac ross the fields - looking very foolish.");
                        Console.WriteLine("But you alive. Possibly a wise choice.");
                    }
                }
                else if (action.Equals("stick your hand in")) { }
            }
            else if (action.Equals("go to the house")) { }
        }
    }
}