//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int number;

Console.Write("Введите введите число: ");

while (!int.TryParse(Console.ReadLine(), out number)|| number<0)
   Console.WriteLine("некорректный  ввод , попробуйте ущё раз : ");
int sum = 0;

while (number > 0)
{

    sum = sum + number % 10;

    number = number / 10;

}
Console.WriteLine($"Сумма цифр числа =  {sum} ");

