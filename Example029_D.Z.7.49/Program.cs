
//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1,7 -> такого числа в массиве нет


int[,] CreateArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int[] FindNumberPosition(int[,] arr, int number)
{
    int[] position = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                position[0] = i + 1;
                position[1] = j + 1;
                return position;
            }
        }
    }
    position[0] = -1;
    position[1] = -1;
    return position;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
           Console.Write($"   {array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void PrintPosition(int[] pos, int num)
{
    Console.WriteLine();
    if (pos[0] > 0 || pos[1] > 0) Console.WriteLine($"Число {num} находится в {pos[0]}-й строке, {pos[1]}-м столбце");
    else Console.WriteLine($"Число {num} отсутствует в заданном массиве");
    Console.WriteLine();
}

int EnterNumerToFind()
{
    Console.WriteLine();
    Console.Write("Введите число:   ");
   // string writeNumber = Console.ReadLine();
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int m = 7;
int n = 4;
int min = 1;
int max = 100;

int[,] array1 = CreateArray(m, n, min, max);
PrintArray(array1);
int number = EnterNumerToFind();
int[] position = FindNumberPosition(array1, number);
PrintPosition(position, number);
