﻿/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int num = new Random().Next(100,1000);

Console.WriteLine(num);

int sec = num / 10 % 10; // исключили последнюю и первую цифры трехзначного числа

Console.WriteLine(sec);
