using System.Data.Common;
using System.Reflection.Metadata.Ecma335;

Console.Clear();
Console.WriteLine("Welcome to the character creator!");
Thread.Sleep(3000);
Console.Clear();
Console.WriteLine("Please give a name to your character:");

string characterName = Console.ReadLine();
int points = 10;

Console.Clear();
Console.WriteLine("Allocate points for Strength: ");
Console.WriteLine("You have " + points + " points left");
string strengthPoints = Console.ReadLine();
int strengthPointsInt = Convert.ToInt32(strengthPoints);
points = points - strengthPointsInt;
 
Console.Clear();
Console.WriteLine("Allocate points for Agility: ");
Console.WriteLine("You have " + points + " points left");
string agilityPoints = Console.ReadLine();
int agilityPointsInt = Convert.ToInt32(agilityPoints);
points = points - agilityPointsInt;

Console.Clear();
Console.WriteLine("Allocate points for Intelligence: ");
Console.WriteLine("You have " + points + " points left");
string intelligencePoints = Console.ReadLine();
int intelligencePointsInt = Convert.ToInt32(intelligencePoints);
points = points - intelligencePointsInt;
Console.Clear();

if (points < 0)
{
    Console.WriteLine("Insufficient points!");
}

else if (points > 0)
{
    Console.WriteLine("Not enough points used!");
}
 
else if (strengthPointsInt == 0 || agilityPointsInt == 0 || intelligencePointsInt == 0)
{
    Console.WriteLine("Each attribute must have 1 point at least!");
}
else
{
    Console.WriteLine(characterName + "'s stats:");
    Console.WriteLine("\n");
    Thread.Sleep(1000);
    Console.Write(strengthPointsInt + "💪");
    Thread.Sleep(1000);
    Console.Write("   " + agilityPointsInt + "🏃");
    Thread.Sleep(1000);
    Console.Write("   " + intelligencePointsInt + "🧠");
}