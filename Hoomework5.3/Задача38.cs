// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = new double [8];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 100);
    Console.Write ($"{array[i]}, ");
}

    double max = array[0];
    double min = array[0];

    foreach (int a in array)
    {
        if (a > max)
        {
        // найден больший элемент
        max = a;
        }
        else 
            if (a < min)
            {
            // найден меньший элемент
            min = a;
            }

    }
Console.WriteLine ();
Console.WriteLine (max);
Console.WriteLine ();
Console.WriteLine (min);
Console.WriteLine ();
Console.WriteLine (max - min);

