// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Net;
using System.Runtime.CompilerServices;

Console.WriteLine("Greetings, Human.");
Console.WriteLine("What might your name be?");
string name = Console.ReadLine();
Console.WriteLine("Your name is....");
Console.Write(name);
Console.Write("?");
Console.WriteLine(" ");
Console.WriteLine("That's a dumb name");

Console.WriteLine("Anyways I have a cool set of things for you to choose between!");
Console.WriteLine("Wanna see them? Yes or no?");
String Answer1 = Console.ReadLine();
if (Answer1 == ("yes"))
    {
    Console.WriteLine("Wonderful!");
}
  
else Console.WriteLine("Too bad, stupid.");

Console.WriteLine("You have a set of doors you may choose from.");
Console.WriteLine("a) A door with a cat.");
Console.WriteLine("b) A door with a cross symbol.");
Console.WriteLine("c) A door with a Tophat.");

string answer2 = Console.ReadLine();

if (answer2 == ("a") || answer2 == ("A"))
{
    Console.WriteLine("Congradulations! You have entered the CAT QUIZ!!");
    Console.WriteLine("From what country did the Sphynx Cat breed originate?");
    Console.WriteLine("a) Canada.");
    Console.WriteLine("b) Egypt.");
    Console.WriteLine("c) Italy");
    string catAnswer = Console.ReadLine();
    if (catAnswer == ("a") || catAnswer == ("A"))
    {
        Console.WriteLine("Congradulations! You were somehow right, so here's a CAT FACT!");
        Console.WriteLine("Orange cats are psychotic maniacs forced into tiny cat bodies.");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("WRONGWRONGWRONG YOU ARE A FOOL!");
        Environment.Exit(0);
    }
}

else
{
    if (answer2 == ("b") || answer2 == ("B"))
    {
        Console.WriteLine("You have entered the Math Room.");
        Console.WriteLine("Give me a number human.");
        int mathAnswer = int.Parse(Console.ReadLine());
        mathAnswer += (25);
        Console.WriteLine("I'm so smart I added 25 to your stupid number human");
        Console.WriteLine("Here is the result:");
        Console.WriteLine(mathAnswer);
        Console.WriteLine("Now Human. What is 9+10?");
        string mathAnswer2 = Console.ReadLine();
        if (mathAnswer2 == ("19"))
        {
            Console.WriteLine("You may not be as stupid as I thought human.");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("You are stupid.");
            Environment.Exit(0);
        }
    }
    else
    {
        if (answer2 == ("c") || answer2 == ("C"))
        {
            Console.WriteLine("You are now in the hat room. Choose a hat.");
            Console.WriteLine("a) Bowler Hat.");
            Console.WriteLine("b) Top Hat.");
            Console.WriteLine("c) Fedora.");
            Console.WriteLine("d) Bucket Hat.");
            string hatChoice = Console.ReadLine();
            if (hatChoice == ("a") || hatChoice == ("A"))
            {
                Console.WriteLine("Bowler hats are the roundest hat. At least I think so. I always imagined that people who wear bowler hats are bald under there. Good choice.");
                Environment.Exit(0);
            }
            else
            {
                if (hatChoice == ("b") || hatChoice == ("B"))
                {
                    Console.WriteLine("Tophats are great! Abraham Lincoln wore a tophat and he was a president! Smart and good people wear tophats. Good choice, human.");
                    Environment.Exit(0);
                }
                else
                {
                    if (hatChoice == ("c") || hatChoice == ("C"))
                    {
                        Console.WriteLine("Neck beard.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        if (hatChoice == ("d") || hatChoice == ("D"))
                        {
                            Console.WriteLine("Bucket hats are for fishermen. Firshermen are good hunters. Fishermen are the apex. Good choice.");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Your answer was invalid. Stupid human.");
                            Environment.Exit(0);
                        }
                    }
                }
            }

        }
    }
}
Console.WriteLine("You couldn't even choose a door properly. You are an absolute fool.");
Environment.Exit(0);