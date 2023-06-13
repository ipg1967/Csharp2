// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число : ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number > 99)
{
    number = number - (number/100)*100 - number%10;
    System.Console.WriteLine($"Вторая цифра числа : {number/10}");
}
else
{
    System.Console.WriteLine("Число не трехзначное");
    System.Console.WriteLine("");
}