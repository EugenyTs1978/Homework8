/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/
 int[,] generate2DArray(int height,int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height,width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd+1 );
        }
    }
    return twoDArray;
}
int minStringArray(int[,] array)
{   int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumString = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
           sumString += array[i,j];          
        }
        sum[i] = sumString;
    }
    int minSumOfString = sum[0];
    int index = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] < minSumOfString)
        {
            minSumOfString = sum[i];
            index = i;
        }
    }
    return index;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] generatedArray = generate2DArray(7,3,-10,10);
int minimum = minStringArray(generatedArray);
print2DArray(generatedArray);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {minimum + 1}");
