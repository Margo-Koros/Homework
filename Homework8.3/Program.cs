// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = 2;
int n = 2;
int[,] array1 = {{2,4} , {3, 2}};
int[,] array2 = {{3,4} , {3, 3}};
int [,] productArrays = new int[m, n];

PrintArray(array1);
PrintArray(array2);
PrintArray(ProductOfMatrix(array1, array2, productArrays));

int[,] ProductOfMatrix(int[,] matrixFirst,int[,] matrixSecond,int[,] productMatrix)
{
    for (int i = 0; i <matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            productMatrix[i,j] = 0;
            for (int k = 0; k <matrixFirst.GetLength(1); k++)
//Произведение двух матриц находим по формуле resultMatrix[i,j] += op1[i,k] * op2[k,j];
           productMatrix[i,j] += matrixFirst[i,k]*matrixSecond[k,j];
        }

    }
    return productMatrix;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}