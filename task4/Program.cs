/*
Задача 4: Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


Console.Write("Введите первое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число с: ");
int c = Convert.ToInt32(Console.ReadLine());
while (( a == b ) || (b == c) || ( a == c ))
   {
    Console.WriteLine("Ввели одинаковые числа, попробуйте еще раз.");
    Console.Write("Введите первое число a: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число b: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число с: ");
    c = Convert.ToInt32(Console.ReadLine());
   }
if (( b > a ) && ( b > c ))
   {
    Console.WriteLine ("Число b: " +b + " максимальное."); 
   }
else if (( c > a ) && ( c > b ))
   {
    Console.WriteLine ("Число c: " +c + " максимальное."); 
   }
else
    Console.WriteLine ("Число a: " +a + " максимальное.");