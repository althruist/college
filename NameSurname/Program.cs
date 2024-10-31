Console.WriteLine("Input your full name");
string fullName = Console.ReadLine();

int indexOfSpace = fullName.IndexOf(' ');

if (indexOfSpace == -1){
    Console.WriteLine("No space found");
}
else{
    char nameInitial = fullName[0];
    char surnameInitial = fullName[indexOfSpace + 1];
    Console.WriteLine($"Initials: {nameInitial}. {surnameInitial}");

    string nameOnly = fullName.Substring(0, indexOfSpace);
    string surnameOnly = fullName.Substring(indexOfSpace);
    Console.WriteLine($"Name Only: {nameOnly}");
    Console.WriteLine($"Surname Only: {surnameOnly}");
    Console.WriteLine($"Your name has {fullName.Length} letters");
}