﻿ //Напишите программу, которая принимает на вход трёхзначное 
 //число и на выходе показывает последнюю цифру этого числа.

 Console.WriteLine("Введите трехзначное числo : ");
int a = Convert.ToInt32(Console.ReadLine());
int last = 0 ;

last = a%10;
Console.WriteLine("Последняя цифра числа "+ a +" это : "+ last + "");
