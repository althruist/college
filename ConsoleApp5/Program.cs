Console.Clear();
Console.Write("Enter countdown time (seconds): ");
int input = Convert.ToInt32(Console.ReadLine());

for (int i = input; i >= 0; i--){
    Console.Clear();
    Console.WriteLine(i);
    Thread.Sleep(1000);
}

// fancy stuff
Console.Write("K");
for (int i = 5; i >= 0; i--){
    Thread.Sleep(100);
    Console.Write("A");
}
Console.Write("B");
for (int i = 100; i >= 0; i--){
    Thread.Sleep(10);
    Console.Write("O");
}
Console.Write("M!");