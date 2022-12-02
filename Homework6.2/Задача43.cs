// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// var позволяет объявлять локальную переменную (внутри метода или цикла) без явного указания типа
// Оператор return завершает выполнение метода, в котором он присутствует, 
// и возвращает управление вызывавшему методу.

Console.Write("Введите k1: ");
var k1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDecimal(Console.ReadLine());

void СrossingPoint (decimal k1, decimal b1, decimal k2, decimal b2)
{
    if (b1 == b2 && k1 == k2)
    {
    Console.WriteLine ("прямые совпадают друг с другом");
    return;
    }
    
    if (k1 == k2)
    {
    Console.Write("прямые не пересекаются");
    return;
    }

    decimal x = -(b1 - b2) / (k1 - k2);
    decimal y = (k1 * x) + b1;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}   

СrossingPoint (k1, b1, k2, b2);
