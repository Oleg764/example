//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


Console.WriteLine();

double[,] GetTableDouble(int m, int n)
{
    double[,] table = new double[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().NextDouble() * 100;
        }
    }
    return table;
}

void PrintTable(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write(tab[i, j]+ " ;");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число строк m : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n : ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] TableDouble = GetTableDouble(m, n);
PrintTable(TableDouble);

