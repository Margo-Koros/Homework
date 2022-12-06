// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = 3; 
int n = 4; 
int [,] array = new int [m, n]; 
 
PrintArray(FillArray (array));
CheckArray (array);

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
 
 void CheckArray (int [,] arra)
 {
    Console.WriteLine ("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    bool foundOut = false;

    for (int i = 0; i < arra.GetLength(0); i++) 
    { 
        for (int j = 0; j < arra.GetLength(1); j++) 
        { 
            if (arra [i,j] == number)
            {
                foundOut = true;
                break;
            }
        }
    }
     if (foundOut)
    {
        Console.WriteLine("Такое число есть");
        return;
    }
    
    Console.WriteLine("Такого числа нет");
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
