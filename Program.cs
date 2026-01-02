// See https://aka.ms/new-console-template for more information

using static System.Console;
using static System.Math;
using csodocs._1_type_system;
using csodocs.cs7days.day1.type_system;
using csodocs.cs7days.day4;
using csodocs.cs7days.day5;

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
        WriteLine(a + b);
    }

    printNumbers(x, y);

    WriteLine($"'int' type value ranges from {maxInt} To {minInt}");
    WriteLine($"'double' type value ranges from {minDoub} To {maxDoub}");

    // await Task.Delay(5000);
    // WriteLine($"Hello Async \n Awaited for 5 seconds");

    WriteLine(Sqrt(2*6));

}

basics();


NameSpaces space1 = new();

space1.setName("Abanoub");
space1.setAge(35);
WriteLine(space1.getName());
WriteLine(space1.getAge());

Person person = new("David_Abanoub", "Jonathan_Abanoub");

person.printName();


// cs7days/Overview

Overview obj = new();
obj.setNumber(5.4);
// test type_casting
WriteLine(obj.setInt());

// cs7days/NewClass
NewClass nc = new(8);

// cs7days/PrimaryConstClass
PrimaryConstClass pcs = new(1, "Your Name,");

// cs7days/RequiredPropsClass
RequiredPropsClass rpc = new() {FirestName="Abanoub", LastName="Boshra"};

// cs7days/day4/Generics.cs
Generics<string> stringData = new();
Generics<int> intData = new Generics<int>();

stringData.Data = "String Data Filled!";
intData.Data = 10;

stringData.PrintData(stringData.Data);
intData.PrintData(intData.Data);

// cs7days/day4/GenMethods.cs

int a = 1; int b = 3;
WriteLine($"a= {a} + b = {b}");

GenMethods gen = new();
gen.swap(ref a, ref b);

WriteLine($"a= {a} + b = {b}");

// cs7days/day5/Delegates.cs
Delegates dg = new();

dg.Instantiate();


