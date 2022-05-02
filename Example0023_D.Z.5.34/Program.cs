// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. Длина массива задается с терминала.
//[345, 897, 568, 234] -> 2


Console.WriteLine ($"Введите длину массива : " );
int N;
while (!int.TryParse(Console.ReadLine(), out N) || N < 0)
    Console.WriteLine("некорректный  ввод , попробуйте ущё раз : ");

int[] FillArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
    
    }
Console.WriteLine();
Console.WriteLine($"Количество четных чисел {even}");
Console.WriteLine();
}

PrintResult(FillArray(N));
