// Asking the users name and taking in the information from the user
Console.WriteLine("Hello player what should system call you?");
string nameofuser = Console.ReadLine();
Console.WriteLine($"Welcome {nameofuser}\n");

// 
Console.WriteLine("Do you want to enter the dungeon yes or no?");

string weaponName = "";

// A loop that force the person to say yes or no
static string Loop()
{
    string en = Console.ReadLine().ToLower();

    while (en != "yes" && en != "no")
    {
        Console.WriteLine("You have to write yes or no!");
        en = Console.ReadLine().ToLower();
    }
    return en;
}
string en = Loop();
// A loop were you have to say yes

if (en == "yes")
{
    Console.WriteLine("Welcome to the dungeon you are now in the waiting room");
}
    else
    {
        Console.WriteLine($"{nameofuser} you don't have a choice you are forced to enter the room!");
        Console.WriteLine();
        Console.WriteLine($"{nameofuser} you are now in the waiting room");
    }
    // A list were you can choose your weapon
    List<string> weapons = [];
    
    ChooseWeapon(weapons, "Sword", "Staff");


Console.ReadLine();




static void ChooseWeapon(List<string> weapons, string weapon1, string weapon2)
{
    Console.WriteLine($"You have a choice between 1) {weapon1} and 2) {weapon2}");
    Console.WriteLine("What do you choose?");

    string wChoice = Console.ReadLine();
    if (wChoice == "1" || wChoice == weapon1)
    {
        weapons.Add(weapon1);
    }
    if (wChoice == "2" || wChoice == weapon2)
    {
        weapons.Add(weapon2);
    }
}
