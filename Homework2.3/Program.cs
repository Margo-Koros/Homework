﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string [] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Восресенье"};
if (num<=0 || num>7){
Console.Write("Такого дня не существует");
}
else if (num-1 == days.Length-2 || num-1==days.Length-1){
    Console.Write("Это выходной день");
}
else  Console.Write("Это рабочий день");