// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// \n - переход на следующую строчку

void InputArray (string [] args)
{

    Console.Write ("Введите количество элементов в массиве: ");
    int M = Convert.ToInt32(Console.ReadLine());

    int [] array = new int [M];
    for (int i = 0; i < array.Length; i++)
    {   
        Console.WriteLine ($"Введите число в массив (отрицательные или положительные) под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    Console.Write ("\nВвод массива: ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]}, ");
    } 
    
    int count = 0;
    foreach (int i in array)
    {
        if (i > 0)
        count++;
    }
    Console.WriteLine ("\nКоличество числе больше 0: " + count);
}
InputArray (args);

