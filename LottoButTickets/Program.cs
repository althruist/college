Console.Clear();
List<int> lottoNumbers = new List<int>();
List<int> ticketNumbers = new List<int>();
int count = 5;

do{
    Console.WriteLine($"{count} numbers left!");
    Console.WriteLine("\n");
    Console.Write("Lotto numbers: ");
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

// ticket part

count = 5;

do{
    Console.WriteLine($"{count} numbers left!");
    Console.WriteLine("\n");
    Console.Write("Ticket numbers: ");
    foreach(int number in ticketNumbers){
        Console.Write($" [{number}] ");
    }
    Console.WriteLine("\n");
    Console.Write("Please input a number: ");
    try{
    int userChoice = Convert.ToInt32(Console.ReadLine());

    if ((userChoice > 0 && userChoice <= 90) && !(ticketNumbers.Contains(userChoice))){
        ticketNumbers.Add(userChoice);
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

int matchingNumbers = 0;

foreach(int number in lottoNumbers){
    if(ticketNumbers.Contains(number)){
        matchingNumbers += 1;
    }
}

Console.WriteLine($"Matching numbers: {matchingNumbers}");