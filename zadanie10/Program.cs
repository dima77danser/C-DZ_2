﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("ВВедите число");
int num = Convert.ToInt32(Console.ReadLine());


int result = num%100/10;

Console.WriteLine(result);
