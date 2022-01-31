using System;
//1. Написать метод, возвращающий минимальное из трёх чисел.

Console.WriteLine ("Впиши три числа: ");
int first = int.Parse (Console.ReadLine());
int second = int.Parse (Console.ReadLine());
int third = int.Parse (Console.ReadLine());

   if ( first > second && first > third) {

      Console.WriteLine ($"Наибольшее число: {first}");

   } else if (second > third) Console.WriteLine ($"Наибольшее число: {second}");
   
    else Console.WriteLine ($"Наибольшее число: {third}");

