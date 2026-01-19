// See https://aka.ms/new-console-template for more information
using System.Data;
using System;

Console.WriteLine("Hello, World!");
Console.Write("Введите свое имя:");
string name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");
Console.WriteLine($"Сегодня: {DateTime.Now.DayOfWeek}");
