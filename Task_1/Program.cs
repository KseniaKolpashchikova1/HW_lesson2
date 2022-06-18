using System;
using static System.Console;

WriteLine("Введите трехзначное число N = ");
int N = Convert.ToInt32 (Console.ReadLine());

if ((Math.Abs(N) < 100) || (Math.Abs(N) > 999)) {
    Console.WriteLine("Обратите внимание! Введено не трехзначное число!");
    return;
}
int N1 = ( N % 100) / 10;

WriteLine($"Вторая цифра заданного числа = {N1}");