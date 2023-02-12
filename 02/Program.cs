Console.Clear();
Console.WriteLine("2. Найти произведение двух матриц.");

Console.Write("Введите количество строк первой матрицы: ");
int numberStringFirstArray = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов первой матрицы: ");
int numberColumFirstArray = int.Parse(Console.ReadLine());

int[,] firstArray = new int[numberStringFirstArray, numberColumFirstArray];

Console.Write("Введите количество строк второй матрицы: ");
int numberStringSecondArray = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов второй матрицы: ");
int numberColumSecondArray = int.Parse(Console.ReadLine());

int[,] secondArray = new int[numberStringSecondArray, numberColumSecondArray];

Console.WriteLine();
Console.WriteLine("Задана первая матрица: ");

FillArray(firstArray);
PrintArray(firstArray);

Console.WriteLine("Задана вторая матрица: ");

FillArray(secondArray);
PrintArray(secondArray);

Console.WriteLine();
if (!ValidateMatr(firstArray, secondArray))
{
    Console.WriteLine("Произведение матриц невозможно! Количество столбцов, строк первой матрицы должно быть равно количеству столбцов, строк второй матрицы.");
}
else
{
    Console.WriteLine("Получим произведение двух матриц:");
    PrintArray(MultiplicationMatr(firstArray, secondArray));
}
Console.WriteLine();

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

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
}

bool ValidateMatr(int[,] firstMatrix, int[,] secondMatrix)
{
    if ((firstMatrix.GetLength(0) != secondMatrix.GetLength(0)) || (firstMatrix.GetLength(1) != secondMatrix.GetLength(1)))
    {
        return false;
    }
    return true;
}

int[,] MultiplicationMatr(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            resultMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
        }
    }
    return resultMatrix;
}