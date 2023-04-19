//  Домашнее задание к 4 семинару
// Задание 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.Write("Введите число основание - ");
// int osn = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число степень -");
// int step = Convert.ToInt32(Console.ReadLine());
// int rez = osn;
// for (int count=2; count<=step; count++)
// {
//     rez=rez*osn;
// }

// Console.WriteLine($"Результат возведения числа {osn} в степнь {step}  равен {rez}");



//Задание 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumD (int num)
// {
//     if (num<0) num=num*(-1);
//     int rez=0;
//     while (num>0)
//     {
//         rez=rez+num%10;
//         num=num/10;
//     }
//     return rez;
// }
// Console.Write ("Введите число для обработки :");
// int inpnum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат обработки числа {inpnum} составляет {SumD (inpnum)}");