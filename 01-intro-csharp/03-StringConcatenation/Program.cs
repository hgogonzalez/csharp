string firstName = "John";
string lastName = "Doe";
decimal balance = 12345.67m;

// Concatenation
string concatenatedString = "Name: " + firstName + " " + lastName + ", Balance: " + balance;
Console.WriteLine(concatenatedString);

// Interpolation
string interpolatedString = $"Name: {firstName} {lastName}, Balance: {balance}";
Console.WriteLine(interpolatedString);