// * Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message}: ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int[,] GenerateArray(int size)
{
    int[,] sqareArray = new int[size, size];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= sqareArray.GetLength(0) * sqareArray.GetLength(1))
    {
        sqareArray[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqareArray.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqareArray.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqareArray.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return sqareArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int len = ReadInt("Введите размер массива ");
Console.Clear();
ShowArray(GenerateArray(len));