// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите Ваше счастливое число : ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number > 99) // модуль больше 100 - значит трехзначное
{
    int razryad = 10;
    while (number > 999)
    {
            number = number / razryad;
    }
    number = number - (number/100)*100;
    number = number - (number/10)*10;
    System.Console.WriteLine($"Третья цифра числа равна {number}");
}
else
{
    System.Console.Write("у числа нет третьей цифры ");
}