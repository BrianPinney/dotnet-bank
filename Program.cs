



// Console.WriteLine("Hello, World!");
// int age = 39;
// string name = "Brian";
// bool isHere = true;
// double salary = 220000.01;
// Console.WriteLine($"My name is {name}, I'm {age} and am here. {isHere}");
// Console.WriteLine($"I make ${salary} a year");

try {

savingsAccount myAccount = new savingsAccount(450);

Console.Write($"Your balance is "); 
Console.Write(myAccount.getBalance());

Console.WriteLine(" and you're good looking");
} catch (Exception ex) {
    Console.WriteLine($"We got an error: {ex.Message}");
}