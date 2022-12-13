// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: "); 
int m = Convert.ToInt32(Console.ReadLine()); 


int sum = 0;
int Numbers(int first, int end) 
{ 
    
    if (first < 0 && end < 0) 
    Console.WriteLine("Отсутствуеют натуральные числа"); 
    else if (first < 0 && end > 0) 
    return Numbers (1, end); 
    if (first > end) return 0; 
    sum+=first;
 
    return Numbers(first+1, end); 
} 

Numbers(n, m);
Console.WriteLine("Сумма элементов равна "+sum);