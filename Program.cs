// See https://aka.ms/new-console-template for more information

using static System.Console;
using static System.Math;
using csodocs._1_type_system;
using csodocs.cs7days.day1.type_system;
using csodocs.cs7days.day4;
using csodocs.cs7days.day5;
using System.Runtime.CompilerServices;
using csodocs.cs7days.day7;
using csodocs._1_type_system.records;
using csodocs._1_type_system.records.oop;
using csodocs.oop;

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

// cs7days/day1/ValRefOut.cs
int chk_int = 2;

ValRefOut passing_obj = new();
WriteLine("========================= \n Value After Passing by Value:");
passing_obj.PassByValue(chk_int);
WriteLine(chk_int);
WriteLine("========================= \n");

WriteLine("========================= \n Value After Passing by Reference:");
WriteLine(passing_obj.PassByReference(ref chk_int));
WriteLine("========================= \n");

//int arg; // Initialization is optional before the call
passing_obj.OutModified(out int arg); // C# 7+ inline declaration
WriteLine("Out Parameter Value");
WriteLine(arg); // Output: 10

// Using Discard
passing_obj.TryGetValues(out chk_int, out _);
WriteLine($"Result: {chk_int}"); // Output: Result: 1
// Console.WriteLine(_); // This would cause a compiler error



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

// cs7days/day7/Unsafe.cs

var unsf = new Pointers();


int z = 9;
unsf.ReliableCode(z);

// =================================================================================

// day1/Delegate.cs
FullDelegate deleg = new();
WriteLine("Delegate Exectution");
deleg.DelegateInstantiate();

int n = 7;
int m = 9;

// Lambda Expression
FullDelegate.MethodWithCallback(n, m, message =>
{
    WriteLine(message);
});

// Or
FullDelegate.MethodWithCallback(n, m, WriteLine);

// day1/Enummy.cs
Enummy enummy = new();

enummy.ShowEnumValues();

// ===============================================================================

// Records Revisited

// _1_type_system/records

PositionalRecordClass positionalRecordClass = new("Amgad" , 40);
WriteLine(positionalRecordClass);

var positionalRecordClass2 = new PositionalRecordClass("Atef" ,35);
WriteLine(positionalRecordClass2);;

var positionalRecordClass3 = new
{
    Name= "Youssef",
    Age=  27
};

WriteLine(positionalRecordClass3);

// Using NonDestructive Mutation "with"
var positionalRecordClass4 = positionalRecordClass3 with {Name = "Ashraf"}; 
WriteLine(positionalRecordClass4);
WriteLine(positionalRecordClass.ReturnDataAsString());

NewOOP newOOP = new("Alexander");
WriteLine(newOOP.PrintName());

// Using Primary Constructor /oop/PrimaryConst.cs
PrimaryConst primaryConst = new(35);
WriteLine(primaryConst.GetAge());

// Using Required Parameters
var requiredParam = new RequiredParam(){name = "Anis",age = 29};
WriteLine($"Name is : {requiredParam.name} \nAge is: {requiredParam.age}");


var structObj = Structy("Haytham", 28);