/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
int[,] factorMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int element = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                element += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i , j] = element;
        }
    }
    return resultMatrix;
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
int[,] generatedArray1 = generate2DArray(2,3,0,10);
int[,] generatedArray2 = generate2DArray(3,4,0,10);
print2DArray(generatedArray1);
Console.WriteLine();
print2DArray(generatedArray2);
Console.WriteLine();
if (generatedArray1.GetLength(1) != generatedArray2.GetLength(0))
{
    Console.WriteLine($"Умножение матриц невозможно: число столбцов первой матрицы не равнр числу строк во второй");

}
else
{
    int[,] factoredMatrix = factorMatrix(generatedArray1, generatedArray2);
    Console.WriteLine("Результирующая матрицв");
    print2DArray(factoredMatrix);
} 

