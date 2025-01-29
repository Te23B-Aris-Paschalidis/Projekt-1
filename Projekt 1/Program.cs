// Asking the users name and taking in the information from the user
Console.WriteLine("Hello player what should system call you?");
string nameofuser = Console.ReadLine();
Console.WriteLine($"Welcome {nameofuser}\n");
// 
Console.WriteLine("Do you want to enter the dungeon yes or no?");

string en = Console.ReadLine().ToLower();

while (en != "yes" && en != "no")
{
    Console.WriteLine("You have to write yes or no!");
    en = Console.ReadLine().ToLower();
}


if (en == "yes")
{
    Console.WriteLine("Welcome to the dungeon you are now in the waiting room");
    else
    {
        Console.WriteLine("");
    }
}


Console.ReadLine();