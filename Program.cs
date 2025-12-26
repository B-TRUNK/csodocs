// See https://aka.ms/new-console-template for more information

using static System.Console;
using static System.Math;
using csodocs._1_type_system;

// Basics are all embedded inside below function
void basics()
{
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
    double maxDoub  = double.MaxValue;
    double minDoub  = double.MinValue; 

    WriteLine("Hello, " + person);
    // String Interpolation
    WriteLine($"Hello, {person}");
    WriteLine($"'{person}' Has {person.Length} Characters");
    WriteLine($"Hello, {person}");
    greeting = greeting.Replace("Hello" ,"Greetings");
    WriteLine(greeting);
    WriteLine(songLowered.Contains("rechochet"));

    void printNumbers(int a,int b)
    {
        Console.WriteLine(a + b);
    }

    printNumbers(x, y);

    WriteLine($"'int' type value ranges from {maxInt} To {minInt}");
    WriteLine($"'double' type value ranges from {minDoub} To {maxDoub}");

    // await Task.Delay(5000);
    // WriteLine($"Hello Async \n Awaited for 5 seconds");

    WriteLine(Sqrt(2*6));

}

basics();


NameSpaces spaces = new NameSpaces();

spaces.setName("Abanoub");
spaces.setAge(35);
WriteLine(spaces.getName());
WriteLine(spaces.getAge());

