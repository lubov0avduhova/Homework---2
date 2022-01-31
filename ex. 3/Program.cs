using System;

/*
3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
*/


Console.WriteLine("Введи числа, пока не введешь ноль, программа не закроется");

  int number = 0; 
  int odd = 0; 
do
{
    number = int.Parse (Console.ReadLine ());

    if (number % 2 != 0)
  {
      odd = number + 1;
  }

} while (number != 0);{
Console.WriteLine ("Число равно 0");
}
Console.WriteLine ($"Нечетные числа: {odd}");

