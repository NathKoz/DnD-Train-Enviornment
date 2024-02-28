#nullable disable
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static bool loggedIn = false;

    static void Main(string[] args)
    {
        UserManager userManager = new UserManager(); // Instantiate UserManager
        ChallengeManager challengeManager = new ChallengeManager(userManager.Users); // Pass users to ChallengeManager
        User currentUser = null;

        while (true)
        {
            if (!loggedIn)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();
                if (userManager.UserExists(username))
                {
                    loggedIn = true;
                    currentUser = userManager.GetUser(username);
                    Console.WriteLine($"Welcome, {username}!");
                }
                else
                {
                    Console.WriteLine("User not found");
                }
            }
            else
            {
                Console.Write("> ");
                string command = Console.ReadLine();
                if (command == "help")
                {
                    DisplayHelp();
                }
                else if (command.ToLower() == "enzo")
                {
                    currentUser.Logout();
                    loggedIn = false;
                    currentUser = null;
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
    }


    static void DisplayHelp()
    {
        TypeOut("Available commands:\n");
        Thread.Sleep(500);
        TypeOut("help - Display this help message\n");
        Thread.Sleep(500);
        TypeOut("Enzo - Log out\n");
    }

    static void TypeOut(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(50); // Adjust the sleep duration to control typing speed
        }
    }
}