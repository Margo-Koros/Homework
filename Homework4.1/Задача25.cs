// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
/*
Console.WriteLine ("Введите число А ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число B ");
int b = Convert.ToInt32(Console.ReadLine());

double c = Math.Pow(a, b);
Console.WriteLine (c);
*/

Console.WriteLine("Введите А"); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите B"); 
int b = Convert.ToInt32(Console.ReadLine()); 
 
Console.Write(stepen1(a, b));

int stepen1 (int a, int b)
{ 
    int temp = 1; 
    for (int i = 0; i<b; i++)
    { 
        temp *= a; 
    }return temp; 
}


