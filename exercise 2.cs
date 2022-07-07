Console.WriteLine("What is your favorite school subject?");
var subject = Console.ReadLine();

switch (subject)
{
    case "Math":
        Console.WriteLine("Math is kind of hard!");
        break;
    case "Science":
        Console.WriteLine("Science is my favorite also!");
        break;
    case "English":
        Console.WriteLine("English is a good subject to know!");
        break;
    case "History":
        Console.WriteLine("History is a tough subject!");
        break;
    case "PE":
        Console.WriteLine("PE is a fun class!");
        break;
    default:
        Console.WriteLine("Thats a cool subject");
        break;



}