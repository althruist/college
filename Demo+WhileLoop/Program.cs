using System.Security.Cryptography.X509Certificates;

Console.Clear();
Random randomizer = new Random();
char playerChoice;
int computerChoice;
char computerToChar = 'n';

do{
    Console.WriteLine("Choose rock (r), paper (p), scissors (s)");
    playerChoice = Console.ReadKey().KeyChar;
    Console.Clear();
    computerChoice = randomizer.Next(1,4);

    if (computerChoice == 1){
        computerToChar = 'r';
    }
    else if (computerChoice == 2){
        computerToChar = 'p';
    }
    else if (computerChoice == 3){
        computerToChar = 's';
    }

    Console.WriteLine("Computer chose: " + computerToChar);
    Console.WriteLine("You chose: " + playerChoice);
    Thread.Sleep(3000);
    Console.Clear();
    
    if (playerChoice == computerToChar){
        Console.WriteLine("It's a tie!");
    }
    else if((playerChoice == 'r' && computerToChar == 's') || (playerChoice == 's' && computerToChar == 'p') || (playerChoice == 'p' && computerToChar == 'r')){
        Console.WriteLine("You win!");
    }
    else{
        Console.WriteLine("You loose!");
    }
    Thread.Sleep(3000);
    Console.Clear();
    Console.WriteLine("Play again? No(n) Yes(any key)");
    char userInput = Console.ReadKey().KeyChar;
    if(userInput == 'n'){
        break;
    }
    else{
        Console.Clear();
    }
}while(true);