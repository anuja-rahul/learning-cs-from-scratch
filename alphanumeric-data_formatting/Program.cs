﻿// string interpolation is a technique that simplifies composite formatting
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

// Formatting currency

decimal price1 = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price1:C} (Save {discount:C})");

// Formatting numbers

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

// Formatting percentages

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

// Combining formatting approaches

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);
