Console.Clear();
List<int> lottoNumbers = new List<int>();
int count = 5;

Console.WriteLine("Welcome to the lotto where you can gamble your insur-"); //humour :)
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("- i mean...");
Thread.Sleep(250);
Console.Clear();
Console.Write("test your luck! :D");
Thread.Sleep(1000);
Console.Write(" ... obviously.");
Thread.Sleep(800);
Console.Clear();

do{
    Console.WriteLine($"{count} numbers left!");
    Console.WriteLine("\n");
    Console.Write("Your current numbers: ");
    foreach(int number in lottoNumbers){
        Console.Write($" [{number}] ");
    }
    Console.WriteLine("\n");
    Console.Write("Please input a number: ");
    try{
    int userChoice = Convert.ToInt32(Console.ReadLine());

    if ((userChoice > 0 && userChoice <= 90) && !(lottoNumbers.Contains(userChoice))){
        lottoNumbers.Add(userChoice);
        count -= 1;
        Console.Clear();
    }
    else{
        Console.Clear();
        Console.WriteLine("Value either has been used already or is invalid, please try again!");
        Console.WriteLine("\n");
    }
    }catch(FormatException){
        Console.Clear();
        Console.WriteLine("Not a number!");
        Console.WriteLine("\n");
    }
}while(count != 0);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"Prima number is: {lottoNumbers[0]}");