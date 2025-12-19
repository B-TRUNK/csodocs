// See https://aka.ms/new-console-template for more information

string person = " Abanoub";
string trimmedPerson = person.Trim();
string greeting = "Hello, " + person;
string song = "I'm Titanium, Rechochet!";
string songLowered = song.ToLower();

int x = 10;
int y = 20;

// Premitive Data Type Ranges
int maxInt      = int.MaxValue;
int minInt      = int.MinValue;
double maxDoub = double.MaxValue;
double minDoub  = double.MinValue; 



Console.WriteLine("Hello, " + person);
// String Interpolation
Console.WriteLine($"Hello, {person}");
Console.WriteLine($"'{person}' Has {person.Length} Characters");
Console.WriteLine($"Hello, {person}");
greeting = greeting.Replace("Hello" ,"Greetings");
Console.WriteLine(greeting);
Console.WriteLine(songLowered.Contains("rechochet"));

void printNumbers(int a,int b)
{
    Console.WriteLine(a + b);
}

printNumbers(x, y);



Console.WriteLine($"'int' type value ranges from {maxInt} To {minInt}");
Console.WriteLine($"'double' type value ranges from {minDoub} To {maxDoub}");

