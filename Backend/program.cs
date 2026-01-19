// See https://aka.ms/new-console-template for more information
using System.Data;
using System;

Console.WriteLine("Hello, World!");
Console.Write("Введите свое имя:");
string name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");
Console.WriteLine($"Сегодня: {DateTime.Now.DayOfWeek}");
Console.WriteLine("Хотите продолжить/выйти? (y/n)");
string next = Console.ReadLine();
 if (next == "y" || next == "Y")
        {
            Console.WriteLine("Вы выбрали: продолжить.");
        }
        else if (next == "n" || next == "N")
        {
            Console.WriteLine("Вы выбрали: выход.");
        }