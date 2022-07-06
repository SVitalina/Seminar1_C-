// Задача 22: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

int N = new Random().Next(1, 10);
int N1 = 1;
int Num = 0;

Console.WriteLine( N );

while (N1<=N)
{
    Num = N1*N1;
    Console.WriteLine(Num);
    N1++;
}






