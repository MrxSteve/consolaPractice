﻿Console.WriteLine("Hello, World!");

float temperatura;
string nombre;
MiClase miClase;

char primeraLetra = 'a';
var limite = 3;
int[] recurso = { 1, 2, 3, 4, 5 };
var query = from item in recurso
            where item <= limite
            select item;


int num = 2147483647;
long bigNum = num;

    
double x = 1234.7;   
int a;

try
{
    a = (int)x;
    System.Console.WriteLine(a);
} catch (InvalidCastException e)
{
    System.Console.WriteLine(e.Message);
}

int i = 3;
Console.WriteLine(i); // Output: 3
Console.WriteLine(i++); // Output: 3
Console.WriteLine(i); // Output: 4

int j = 3;
Console.WriteLine(j); // Output: 3
Console.WriteLine(++j); // Output: 4
Console.WriteLine(j); // Output: 4


Console.WriteLine(+4); // Output: 4
Console.WriteLine(-4); // Output: -4
Console.WriteLine(-(4)); // Output: 4

int c = 5;

uint z = 5;
var b = -z;
Console.WriteLine(b); // Output: 5
Console.WriteLine(b.GetType()); // Output: System.Int64

Console.WriteLine(-double.NaN); // Output: NaN

Console.WriteLine(5 * 2); // Output: 10
Console.WriteLine(0.5 / 2.5); // Output: 1.25
Console.WriteLine(0.1m * 23.4m); // Output: 2.34

Console.WriteLine(13 / 5.0); // Output: 2.6

int n1 = 13;
int n2 = 5;

Console.WriteLine((double)n1 / n2); // Output: 2.6

Console.WriteLine(5 % 4); // Output: 1
Console.WriteLine(5 % -4); // Output: 1
Console.WriteLine(-5 % 4); // Output: -1
Console.WriteLine(-5 % -4); // Output: -1

void DisplayMeasurement(double val)
{
    if (val < 0 || val > 100)
    {
        Console.WriteLine("Invalid measurement");
    }
    Console.WriteLine($"Measurement: {val}");
}

DisplayMeasurement(45); // Output: Measurement: 45
DisplayMeasurement(-5); // Output: Invalid measurement


void DisplayWheatherReport (double tempInCelsius)
{
    if (tempInCelsius < 20.0)
    {
        Console.WriteLine("It's cold outside");
       

    } else
    {
        Console.WriteLine("Perfect");
    }
}

DisplayWheatherReport(15.0); // Output: It's cold outside
DisplayWheatherReport(25.0); // Output: Perfect

void DisplayCharacter(char c)
{
    if (char.IsUpper(c))
    {
        Console.WriteLine($"Uppercase {c}");
    }
    else if (char.IsLower(c))
    {
        Console.WriteLine($"Lowercase {c}");
    }
    else if (char.IsDigit(c))
    {
        Console.WriteLine($"Digit {c}");
    }
    else
    {
        Console.WriteLine($"Other {c}");
    }
}

DisplayCharacter('A'); // Output: Uppercase A
