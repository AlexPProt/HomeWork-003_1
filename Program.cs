// //Домашнее задание к 6му семинару


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int CheckNeg (int n)
// {
//     int count=0;
//     int temp;
//     for (int i=0; i<n ; i++)
//     {
//         Console.Write ($"Введите {i} е число -");
//         temp = Convert.ToInt32(Console.ReadLine());
//         if (temp<0) count++;
//     }
//     return count;
// }
// Console.Write("Input a quantity of elements - ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"A quantity negative elements - {CheckNeg(n)}");







// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double PointX (double k1, double k2, double b1, double b2)
{
    double rez =(b2-b1)/(k1-k2);
    return rez;    
}
double PointY (double k1, double k2, double b1, double b2)
{
    return k1* PointX(k1,k2,b1,b2) +b1;    
}
Console.Write("Input ratio k1 - ");
double k1=Convert.ToDouble(Console.ReadLine());
Console.Write("Input ratio k2 - ");
double k2=Convert.ToDouble(Console.ReadLine());
Console.Write("Input ratio b1 - ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.Write("Input ratio b2 - ");
double b2=Convert.ToDouble (Console.ReadLine());

Console.WriteLine ($"Point intersection of lines  (X : {PointX (k1,k2,b1,b2)} ,  Y : {PointY (k1,k2,b1,b2)})");






//----------------СЕМИНАР 6-----------

// 1 Напишите программу, которая принимает на вход три числа и проверяет, 
//  может ли существовать треугольник с сторонами такой длины.

// bool CheckTrin(int l1, int l2, int l3)
// {
//     if (l1<l2+l3 && l2<l1+l3 && l3<l1+l2) return true;
//     return false;
// }

// Console.WriteLine("Input size 1 - ");
// int l1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size 1 - ");
// int l2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size 1 - ");
// int l3=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ($" По заданным длинам труегольник -  {CheckTrin (l1,l2,l3)} " );



// 2 Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


// int[] Fibonacci (int num1, int num2, int razm)
// {
//     int[] array = new int[razm];
//     array[0]=num1;
//     array[1]=num2;
//     for (int i=2; i<razm; i++) array[i]=array[i-1]+array[i-2];
//     return array;
// }

// Console.Write ("Введите кол-во эл-в ряда - ");
// int razm = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите превое значние ряда - ");
// int num1= Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите превое значние ряда - ");
// int num2= Convert.ToInt32(Console.ReadLine());

// int[] fibArray= Fibonacci(num1,num2,razm);

// ShowIntMas (fibArray);

// 3 Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.



// // Задаем исходные параметры
// Console.Write("Input a quantity of elements array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] myArray = CreatRandomArray (size,min,max);   // Гененрируем массив

// int [] CopyArray (int[] array)
// {
//     int[] mas = new int [array.Length];
//     for (int i=0; i<array.Length; i++) mas[i]=array[i]+1;
//     return mas;
// }

// ShowIntMas(myArray);
// int [] newArray= CopyArray(myArray);
// ShowIntMas(newArray);



















// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void ReverseArray (int [] array)
// {
//     for (int i=0, j=array.Length-1; i<j; i++, j--)
//     {
//         int temp=array[i];
//         array[i]=array[j];
//         array[j]=temp;
//     }
// }
// int size=6;
// int min = 1;
// int max=10;
// int [] myArray = CreatRandomArray (size,min,max);
// ShowIntMas(myArray);
// ReverseArray(myArray);
// ShowIntMas(myArray);

// Домашнее задание к семинару №5 ЗАДАНИЕ №3
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double MinMaxDif (double [] array)          // Метод вычисления разницы между мин и макс эл-ми массива
// {
//     double min= array[0];
//     double max= array[0];
//     for (int i=1; i<array.Length; i++)
//     {
//         if (array[i]<min) min=array[i];
//         if (array[i]>max) max=array[i];
//     }
//     return (max-min);
// }

// // Console.Write("Input a quantity of elements array: ");
// // int size = Convert.ToInt32(Console.ReadLine());
// // double [] myArray = new double [size];
// // for (int i=0;i<size;i++)
// // {
// //     Console.Write($"Input {i} element of array: ");
// //     myArray[i]= Convert.ToDouble(Console.ReadLine());
// // }
// // ShowDoubMas(myArray);                                   // Выводим массив и результат обработки
// // Console.WriteLine ("The difference betwin min & max elements of the array is :"+ MinMaxDif (myArray) );


// Домашнее задание к семинару №5 ЗАДАНИЕ №2
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int SumOddPos (int [] array)  // функция определения суммы эелементов стоящих на нечетных позициях
//     {
//         int sum=0;
//         for (int i=1;i<array.Length;i=i+2) sum=sum+array[i];
//         return sum;
//     }

// // Задаем исходные параметры
// Console.Write("Input a quantity of elements array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] myArray = CreatRandomArray (size,min,max);   // Гененрируем массив
// ShowIntMas (myArray);                                   // Выводим массив и результат обработки
// Console.WriteLine ("The number of even elements of the array is :"+ SumOddPos (myArray) );



// Домашнее задание к семинару №5 ЗАДАНИЕ №1
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int EventElem (int [] array)
// {
//     int count=0;
//     for (int i=0; i<array.Length; i++)
//         if (array[i]%2==0) count++;
//     return count;
// }
// // Задаем исходные параметры
// int min=100;
// int max=1000;
// Console.Write("Input a quantity of elements array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] myArray = CreatRandomArray (size,min,max);
// ShowIntMas(myArray);
// Console.WriteLine ("The number of even elements of the array is -"+ EventElem (myArray) );





// Процедура генерации массива с указанными параметрами
int[] CreatRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for (int i=0; i<size; i++)
    {
        array[i]= new Random().Next(minValue,maxValue+1);
    }
    return array;
}

// Процедура вывода массива на экран с числами double
void ShowDoubMas (double [] array)
{
    for (int count=0; count <array.Length; count++) Console.WriteLine ($"Элемент массива {count} - {array[count]}");
    Console.WriteLine();
}


// Процедура вывода массива на экран с числами int
void ShowIntMas (int [] array)
{
    for (int count=0; count <array.Length; count++) Console.WriteLine ($"Элемент массива {count} - {array[count]}");
    Console.WriteLine();
}




//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] CreatRandomArray (int size, int minValue, int maxValue)
// {
//     int [] array = new int [size];
//     for (int i=0; i<size; i++)
//     {
//         array[i]= new Random().Next(minValue,maxValue+1);
//     }
//     return array;
// }
// int[] MakePositive(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = array[i] * (-1);
//     return array;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size, min, max);
// ShowArray(myArray);
// MakePositive(myArray);
// ShowArray(myArray);


//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// bool HaveChosenNumber(int number, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             Console.WriteLine($"There is such number in the current array.");
//             return true;
//         }
//     }
//     Console.WriteLine($"There is NO such number in the current array.");
//     return false;

// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input chosen number, please: ");
// int chosenNum = Convert.ToInt32(Console.ReadLine());

// int[] array = CreatRandomArray(size, min, max);
// ShowArray(array);
// HaveChosenNumber(chosenNum, array);


// 3 Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

// int QuantityOfElements(int[] array, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] <= max && array[i] >= min) count++;
//     return count;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input lower boarder, please: ");
// int boarderA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input top boarder, please: ");
// int boarderB = Convert.ToInt32(Console.ReadLine());

// int[] array = CreatRandomArray(size, min, max);
// ShowArray(array);
// Console.WriteLine("The quantity of elements between boarders: " + QuantityOfElements(array, boarderA, boarderB));


// Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

// int GetSumNeg(int[] array)
// {
//     int sumNeg=0;
//     for (int i=0; i<array.Length; i++)
//         if (array[i]<0) 
//             sumNeg+=array[i];

//     return sumNeg;
// }

// int[] CreatRandomArray (int size, int minValue, int maxValue)
// {
//     int [] array = new int [size];
//     for (int i=0; i<size; i++)
//     {
//         array[i]= new Random().Next(minValue,maxValue+1);
//     }
//     return array;
// }

// void PrintMas (int [] array)
// {
//     for (int count=0; count <array.Length; count++) Console.WriteLine ($"Элемент массива {count} - {array[count]}");
// }

// Console.Write ("Введите кол-во элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите минимальный элемент: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите максимальный элемент: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size,min,max);
// PrintMas (myArray);
// Console.WriteLine("Сумма отрицательных чисел - "+ GetSumNeg(myArray));
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


//Задание 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int longmas=8;
// int [] checkarray = new int[longmas];
// for (int count=0; count<longmas; count++)
// {
//     Console.Write($"Введите {count} элемент массива ");
//     checkarray[count] = Convert.ToInt32(Console.ReadLine());
// }

// void PrintMas (int [] array)
// {
//     for (int count=0; count <array.Length; count++) Console.WriteLine ($"Элемент массива {count} - {array[count]}");
// }
// PrintMas (checkarray);