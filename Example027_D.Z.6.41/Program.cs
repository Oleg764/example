//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3
Console.Write("Назовите кол-во чисел , которые вы собираетесь ввести :   ");
int m = Convert.ToInt32(Console.ReadLine());
int volume = m;                // колчество ввода чисел
int count = 0;
while (volume > 0)
{
    System.Console.Write("Введите число:   ");
    string num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if (number > 0) count++;
    volume--;
}
Console.WriteLine($"Количество чисел больше 0 : {count}");
Console.WriteLine();
