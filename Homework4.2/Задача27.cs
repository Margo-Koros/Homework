// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine ("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int n1 = num/100;
int n2 = (num/10)%10;
int n3 = num%10;

int sum = n1+n2+n3;
Console.WriteLine (sum);
