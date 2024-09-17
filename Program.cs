// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

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
if (Answer1 != ("yes"))
    Console.WriteLine("Wonderful!");
else Console.WriteLine("Too bad, stupid.");