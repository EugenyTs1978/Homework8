/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
*/
int[,] FillSpiralMatrix(int height, int width)
{
    int[,] matrix = new int[height, width];
    int val = 1;
    int n = 0;
    int m = 0;
    while (n < height && m < width)
    {
        for (int i = m; i < width; i++)
        {
            matrix[n, i] = val++;
        }
        n++;
        for (int j = n; j < height; j++)
        {
            matrix[j, width - 1] = val++;
        }
        width--;
        for (int i = width-1; i >= m; i--)
        {
            matrix[height - 1, i] = val++;
        }
        height--;
        for (int j = height-1; j >= n; j--)
        {
            matrix[j, m] = val++;
        }
        m++;
    }
    return matrix;
}
void print2DArray(int[,] arrayToPrint)
{
    
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            if (arrayToPrint[i,j] < 10)
            {
                Console.Write($"{0}{arrayToPrint[i,j]} ");
            }
            else
            {
                Console.Write(arrayToPrint[i,j]+" ");
            }    
        }
        Console.WriteLine();
    }
}

int[,] userArray = FillSpiralMatrix(4,4);
print2DArray(userArray);
