// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int size = 8;
int [] array = new int [size];
Random rnd = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next();
    Console.Write($"{array[i]}, ");
}