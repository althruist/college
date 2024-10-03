int generatedNumber;

Random generator = new Random();
generatedNumber = generator.Next(1, 11);

Console.WriteLine(generatedNumber);

Console.WriteLine("Choose from 1-10");

string userInput = Console.ReadLine();

int userInputInt = Convert.ToInt32(userInput);

if (userInputInt == generatedNumber)
    Console.WriteLine("YOU DID IT!!!!!!");
else
    Console.WriteLine("you suck.");