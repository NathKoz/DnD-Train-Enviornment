using System.Runtime.CompilerServices;
#nullable disable

//Intro of the Terminal
var Intro = "\n\nWelcome User...\n\nLogin:";

foreach (var character in Intro)
    {
        Console.Write(character);
        Thread.Sleep(30);
    }
Console.WriteLine();
string Username = Console.ReadLine();

//After Login: Will
if (Username == "Clementine")
{
    var Will_Console = "\n\nWelcome, Clementine";

    foreach (var character in Will_Console)
    {
        Console.Write(character);
        Thread.Sleep(40);
    }
    Console.WriteLine();
}

