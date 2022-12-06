// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int m = 3; 
int n = 4; 
int [,] array = new int [m, n]; 
 
PrintArray(FillArray (array));
AvgColumnArray (array);

int [,] FillArray (int [,] arr)
{ 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++) 
        { 
            arr[i,j] = new Random().Next(1,99);   
        } 
    }return arr; 
} 

void AvgColumnArray (int [,] ar)
{ 
    for (int j = 0; j < ar.GetLength(1); j++) 
    { double avg = 0;
        for (int i = 0; i < ar.GetLength(0); i++) 
        { 
            avg += (ar[i,j]);
        } 
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j+1} = {(float)avg/ar.GetLength(0)}"); 
    } return;
}

void PrintArray (int [,] ar)
{ 
    for (int i = 0; i < ar.GetLength(0); i++) 
    { 
        for (int j = 0; j < ar.GetLength(1); j++) 
        { 
            Console.Write($"{ar[i,j]} "); 
        } 
        Console.WriteLine(""); 
    } 
}
