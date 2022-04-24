//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да
Console.Write("Введите пятизначное число:   ");
string number = Console.ReadLine();
int length = number.Length;

bool Palindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}
if (Palindrome())
    Console.Write("Число является полиндромом");
else
    Console.Write("Число не является полиндромом");
Console.WriteLine();
