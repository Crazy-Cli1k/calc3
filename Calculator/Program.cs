﻿// See https://aka.ms/new-console-template for more information
using Calculator;

Console.WriteLine("Введите A");
double A = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите B");
double B = Double.Parse(Console.ReadLine());

Console.WriteLine("Выберите функцию:\n1) - выполнить операцию “+”\n2) - выполнить операцию “-”\n3) - выполнить операцию “*”\n4) - выполнить операцию “/”");
int choice = Int32.Parse(Console.ReadLine());

if (choice == 1)
{

}
else if (choice == 2)
{

}
else if (choice == 3)
{

}
else if (choice == 4)
{
    Console.WriteLine($"Получилось {Functions.Division(A,B)}");
}
else Console.WriteLine("Ошибка! Неверные данные!");
