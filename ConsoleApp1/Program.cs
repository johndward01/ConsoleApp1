
Console.Write("Please enter your first name: ");
string firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
string lastName = Console.ReadLine();
Console.WriteLine();
//Console.WriteLine("Hello, " + firstName + " " + lastName + "!"); // concatenation
//Console.WriteLine("Hello, {0} {1}!", firstName, lastName); // composite formatting
Console.WriteLine($"Hello, {firstName} {lastName}!");
