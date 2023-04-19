//  Домашнее задание к 4 семинару
// Задание 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число основание - ");
int osn = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число степень -");
int step = Convert.ToInt32(Console.ReadLine());
int rez = osn;
for (int count=2; count<=step; count++)
{
    rez=rez*osn;
}

Console.WriteLine($"Результат возведения числа {osn} в степнь {step}  равен {rez}");
