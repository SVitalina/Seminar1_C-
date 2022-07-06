// Задача 18: Напишите программу, которая
// по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти");
int quarter = Convert.ToInt32 (Console.ReadLine());

if(quarter == 1)
{
    Console.WriteLine("0-y+, 0-x-");
}

if (quarter == 2)
{
    Console.WriteLine("y+, x+");
}

if(quarter == 3)
{
    Console.WriteLine("y-, x-");
}

if(quarter == 4)
{
    Console.WriteLine("y-, x+");
}
