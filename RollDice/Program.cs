using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

Random dice1 = new Random();
Random dice2 = new Random();

int rollingTime = 100;

while(true){
    if(rollingTime == 0){
        break;
    }
    Console.Clear();
    int num1 = dice1.Next(1,7);
    int num2 = dice2.Next(1,7);
    Console.WriteLine("|" + num1 + "|           |" + num2 + "|");
    rollingTime -= 1;
    Thread.Sleep(10);
}
Console.Clear();
int finalNum1 = dice1.Next(1,7);
int finalNum2 = dice2.Next(1,7);
Console.WriteLine("|" + finalNum1 + "|           |" + finalNum2 + "|");
Thread.Sleep(2000);
Console.Clear();
int total = finalNum1 + finalNum2;
Console.Write("|" + total + "|");
Thread.Sleep(2000);
if (total ==7 || total == 11){
    Console.Write("   You win! 🎉   ");
}
else if (total == 2){
    Console.Write("   Snake eyes! 🐍   ");
}
else {
    Console.Write("   Try again! 🔁   ");
}