#region
var r = new Random();
var favNumber = r.Next(1, 1000);

Console.WriteLine("Please enter your guess");
var userInput = int.Parse(Console.ReadLine());

if (userInput < favNumber) 
{
Console.WriteLine($"{userInput} is too low");
}
else if (userInput > favNumber) 
{
    Console.WriteLine($"{userInput} is too high");
}
else if (userInput == favNumber)
{
    Console.WriteLine($"{userInput} is correct! congratulations!");
}



#endregion