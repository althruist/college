Console.WriteLine("Please input your theory mark:");
string theoryMark = Console.ReadLine();
Console.WriteLine("Please input your practical mark:");
string practicalMark = Console.ReadLine();

int practicalMarkInt = Convert.ToInt32(practicalMark);
int theoryMarkInt = Convert.ToInt32(theoryMark);

if (practicalMarkInt < 50)
{
    Console.WriteLine("You did not pass the practical");
}
else
{
    Console.WriteLine("You passed the practical!");
}
if (theoryMarkInt < 50)
{
    Console.WriteLine("You did not pass the theory");
}
else
{
    Console.WriteLine("You passed the theory!");
}

if ((theoryMarkInt + practicalMarkInt) >= 125 && theoryMarkInt >= 50 && practicalMarkInt >= 50)
{
    Console.WriteLine("You passed the semester!");
}
else
{
    Console.WriteLine("You did not pass the semester");
}