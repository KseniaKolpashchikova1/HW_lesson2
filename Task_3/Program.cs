//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

using System;
using static System.Console;

WriteLine("Введите номер дня недели = ");
int N = Convert.ToInt32(Console.ReadLine());

string answer = N < 5 || N == 5? 
"День недели является будним"
:$"День недели является выходным"; 

WriteLine(answer);