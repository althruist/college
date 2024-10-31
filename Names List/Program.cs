using System.Drawing;

Console.Clear();
Console.WriteLine("Welcome to [insert name inserter game]!");
Thread.Sleep(3000);

List<string> names = new List<string>();
Random luckyWinner = new Random();

do{
    Console.Clear();
    Console.WriteLine("Current amount of names: " + names.Count);
    Console.WriteLine('\n');
    Console.WriteLine('\n');
    Console.Write("Please input a name or type 'stop': ");
    string nameInput = Console.ReadLine();
    if (nameInput.ToLower() == "stop"){
        break;
    }
    else{
        names.Add(nameInput);
    }
}while (true);

Console.Clear();
Console.BackgroundColor = System.ConsoleColor.Cyan;
Console.WriteLine("You inserted " + names.Count + " names:");
Console.WriteLine('\n');

Console.BackgroundColor = System.ConsoleColor.White;
foreach(string name in names){
    Console.WriteLine($"[{names.IndexOf(name)}]  {name}");
    Thread.Sleep(500);
}
Console.BackgroundColor = System.ConsoleColor.Black;
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("The lucky winner is: 🥁");
Thread.Sleep(3000);
Console.Clear();
Console.WriteLine($"{names[luckyWinner.Next(0,names.Count)]}");