string word = "WORD!";

Console.WriteLine("Remember this word: " + word);
Thread.Sleep(3000);
Console.Clear();

Console.WriteLine("What was the word?");
string userInput = Console.ReadLine();

if (word == userInput)
    Console.WriteLine("Correct");
else
    Console.WriteLine("Incorrect");