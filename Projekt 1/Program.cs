int money = 5;

// Asking the users name and taking in the information from the user
Console.WriteLine("Hello player what should system call you?");
string nameofuser = Console.ReadLine();
Console.WriteLine($"Welcome {nameofuser}\n");
Console.WriteLine("Do you want to enter the dungeon yes or no?");

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
    Console.WriteLine("\nWelcome to the dungeon you are now in the waiting room\n");
}
else
{
    Console.WriteLine($"{nameofuser} you don't have a choice you are forced to enter the room!");
    Console.WriteLine();
    Console.WriteLine($"{nameofuser} you are now in the waiting room");
    Console.WriteLine();

}
// A list were you can choose your weapon
List<string> weapons = [];

ChooseWeapon(weapons, "wooden sword", "wooden staff");


Console.ReadLine();


//  A method to let the user chose a weapon.

static void ChooseWeapon(List<string> weapons, string weapon1, string weapon2)
{
    Console.WriteLine($"You have a choice between: \n1) {weapon1} (5 physical dmg) \n2) {weapon2} (5 magic dmg)\n");
    Console.WriteLine("What do you choose?");

    string wChoice = Console.ReadLine().ToLower();
    if (wChoice == "1" || wChoice == weapon1 || wChoice == "sword")
    {
        weapons.Add(weapon1);
        Console.WriteLine("You have chosen Wooden Sword");
    }
    else if (wChoice == "2" || wChoice == weapon2 || wChoice == "staff")
    {
        weapons.Add(weapon2);
        Console.WriteLine("You have chosen Wooden Staff");
        Console.WriteLine();
    }
}

Console.WriteLine($"{nameofuser} you have 5 gold to spend on health potions do you want to use your gold now yes or no?");
// Using the yes or no loop
string a = Loop();
string n = "";

if ("yes" == a)
{
    Console.WriteLine("OK, how many?");
    string pAntal = Console.ReadLine();
    int potion = 1;
    bool success = int.TryParse(pAntal, out potion);

    money = money - potion;
    while ("yes" == pAntal)
    {
        Console.ReadLine();
    }

}
else if ("no" == n)

    Console.WriteLine("You will enter the dungeon in 3 seconds");
Console.WriteLine("3");
Console.WriteLine("2");
Console.WriteLine("1");