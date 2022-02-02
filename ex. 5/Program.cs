/*
5.
а) Написать программу, которая запрашивает массу и рост человека, 
вычисляет его индекс массы и сообщает, 
нужно ли человеку похудеть, набрать вес или всё в норме.

(ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
*/

Console.WriteLine ("Введи свой рост и массу тела в килограммах: ");

double height = double.Parse (Console.ReadLine ());
height = height / 100; // чтобы перевести в метры с запятой
double weight = double.Parse (Console.ReadLine ());

double imt = weight/ (height * height); 

Console.WriteLine ("Твое ИМТ составляет: {0:F2}", imt);
