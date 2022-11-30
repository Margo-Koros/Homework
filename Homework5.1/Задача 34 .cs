// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int size = 8;
int [] array = new int [size];
Random rnd = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(100, 999);
    Console.WriteLine ($"{array[i]}, ");
}

Console.WriteLine ();
int result = 0;

for (int n=0; n < array.Length; n++)
{
    if (array[n]%2  == 0)
    result += 1;
}
Console.Write ("Общее количество элементов " + result);
Console.WriteLine ();


