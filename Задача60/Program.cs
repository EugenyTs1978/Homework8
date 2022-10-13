/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/
int[,,] generate3DArray(int height, int length, int width, int randomStart, int randomEnd)
{
    int volume =  height * length * width;
    int[] randomNumber = new int[volume]; //Заполнение одномерного массива неповторяющимися числами.
    for (int i = 0; i < volume; i++)
    {
        int num = new Random().Next(randomStart, randomEnd);
        if (randomNumber.Contains(num))
        {
            i--;
        }
        else
        {
            randomNumber[i] = num;
        }
    }    
    int[,,] threeDArray = new int[height,length,width];//Заполнение 3-х мерного из одномерного.
    int l = 0;
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < length; j++)
        {
            for (int k = 0; k < width; k++)
            {
                threeDArray[i, j, k] = randomNumber[l];
                l++;
            }
        }
    }
    return threeDArray;
}
void print3DArray(int[,,] arrayToPrint)
{
    
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            Console.Write($"{arrayToPrint[i,j,k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}

int[,,] generatedArray = generate3DArray(2,3,3,10,100);
print3DArray(generatedArray);



