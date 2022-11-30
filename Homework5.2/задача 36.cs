// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.

// [3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int size = 8;
int [] array = new int [size];
Random rnd = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(-99, 99);
    Console.Write ($"{array[i]}, ");
}

int sum = 0;

for (int n = 1; n < size; n+=2)
{
    sum += array[n];
    
}
Console.WriteLine();
Console.WriteLine ("Cумма равна: " + sum);