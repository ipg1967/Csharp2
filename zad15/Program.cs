﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите день недели : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (number == 6 || number == 7) 
    {
    System.Console.WriteLine($"{number} -> да");
    }
else
    {
    System.Console.WriteLine($"{number} -> нет");
    }