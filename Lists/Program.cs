using System.Collections.Generic;

List<string> myList = new List<string>();
myList.Add("Mercury");
myList.Add("Venus");
myList.Add("Mars");
myList.Add("Jupiter");
myList.Add("Pluto");

myList.Insert(2, "Earth");

myList.Remove("Pluto");
// myList.RemoveAt(1); -- to use w/ index instead of name

myList[myList.IndexOf("Mars")] = "Red Planet";

foreach(string item in myList){
    Console.WriteLine(item);
}

// To find object is myList.Contains("object")

// lists start a 0
Console.WriteLine("First item: " + myList[0]);
Console.WriteLine("Number of item: " + myList.Count);
Console.WriteLine("Last item is: " + myList[myList.Count - 1]);