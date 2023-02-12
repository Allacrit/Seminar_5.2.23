Console.Clear();
Console.WriteLine("4. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента.");

int sizeX = 4;
int sizeY = 4;
int sizeZ = 4;
int[,,] newArray = new int[sizeX, sizeY, sizeZ];

FillArray(newArray);
PrintArray(newArray);


void PrintArray(int[,,] array)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++) 
        {
            for (int l = 0; l < 4; l++)
            {
                Console.WriteLine($"Ячейка массива [{i},{j},{l}] Содержит значение: {array[i, j, l]}.");
            }
        }
    }

}

void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                count++;
                array[i, j, l] = count;
            }
        }

    }
}