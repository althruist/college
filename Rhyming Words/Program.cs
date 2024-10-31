List<string> wordList = new List<string>
       {
           "cat", "hat", "bat", "rat", "mat", "flat",
           "dog", "frog", "log", "jog", "smog",
           "tree", "free", "see", "bee", "spree",
           "light", "fight", "night", "sight", "might"
       };

Console.Clear();

Console.Write("Welcome to the game that finds rhyme words for you but limited to a few words!!!");
Thread.Sleep(1000);
Console.Write(" cuz its fun!");
Thread.Sleep(500);
Console.Clear();
Console.WriteLine("Write a word that's easy.. I guess:");
string userInput = Console.ReadLine();

string last2Letters = userInput.Substring(userInput.Length - 2);
Console.WriteLine(last2Letters);

Console.Write("Your word rhymes with:");
foreach(string word in wordList){
    if(word.Substring(word.Length - 2) == last2Letters){
        Console.Write($" {word},");
    }
}