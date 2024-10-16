Console.Clear();
Console.WriteLine("How many times?");
var num = Console.ReadLine();
var newNum = Convert.ToInt32(num);

for (int i = 1; i <= newNum; i++){
    Console.Clear();
    Console.WriteLine(i);
    Thread.Sleep(i);
}
Thread.Sleep(3000);

Console.Clear();
Console.Write("Please choose a number: ");
int multiplier = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("MULTIPLE   INCREMENT   ANSWER");
for (int i = 1; i <= multiplier; i++){
    Console.WriteLine("---------------------------");
    Console.WriteLine("|  " + multiplier + "  | * |  " + i + "  | = |  " + multiplier * i + "  |");
}