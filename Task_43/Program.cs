/*                                          Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)        */

void EnterNumber(double pointB1, double pointK1, double pointB2, double pointK2) // найдёт точку пересечения двух прямых
{
    
    double b1 = pointB1;
    double k1 = pointK1;
    double b2 = pointB2;
    double k2 = pointK2;

    double x = (b2 - b1) / (k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;

    Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({y1}; {y2})");
}

EnterNumber(2, 5, 4, 9);


