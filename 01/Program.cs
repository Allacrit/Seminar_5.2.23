Console.Clear();
Console.WriteLine("1. Составить частотный словарь элементов двумерного массива.");

Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов двумерного массива: ");
int cols = int.Parse(Console.ReadLine());

int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
CheckArray(array);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CheckArray(int[,] array)
{
    int[] voc = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
        {
            voc[array[i, j]] += 1;
        }

    for (int i = 0; i < voc.Length; i++)
    {
        if (voc[i] > 0)
            Console.WriteLine($"{i} встречается {voc[i]} раз(а).");
    }
}