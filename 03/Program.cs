Console.Clear();
Console.WriteLine("3. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.");

Console.Write("Введите количество строк: ");
int numberStringArray = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int numberColumArray = int.Parse(Console.ReadLine());

int[,] newArray = new int[numberStringArray, numberColumArray];

FillArray(newArray, 0, 50);
PrintArray(newArray);

Console.WriteLine();

RowChangeArray(newArray, RowMinIndex(newArray));
ColChangeArray(newArray, ColumnMinIndex(newArray));
PrintChangeArray(newArray);


void FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] array)
{
    int stringLength = FindMaxVarLengthInArr(array) + 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            PrintVarToLength(array[i, j], stringLength);
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintChangeArray(int[,] array)
{
    int stringLength = FindMaxVarLengthInArr(array) + 1;
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
            PrintVarToLength(array[i, j], stringLength);
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMaxVarLengthInArr(int[,] array)
{
    int maxLen = array[0, 0].ToString().Length;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int curLen = array[i, j].ToString().Length;
            if (maxLen < curLen) maxLen = curLen;
        }
    return maxLen;
}

void PrintVarToLength(int var, int length)
{
    int spacesLength = length - var.ToString().Length;
    for (int i = 0; i < spacesLength; i++) Console.Write(" ");
    Console.Write(var);
}

int RowMinIndex(int[,] array)
{
    int min = array[0, 0];
    int MinIndRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                MinIndRow = i;
            }
        }
    }
    return MinIndRow;
}

int ColumnMinIndex(int[,] array)
{
    int min = array[0, 0];
    int MinIndCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                MinIndCol = j;
            }
        }
    }
    return MinIndCol;
}

void RowChangeArray(int[,] array, int MinIndRow)
{
    for (int i = MinIndRow; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i + 1, j];
        }
    }
}

void ColChangeArray(int[,] array, int MinIndCol)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = MinIndCol; j < array.GetLength(1) - 1; j++)
        {
            array[i, j] = array[i, j + 1];
        }
    }
}