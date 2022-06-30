//Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите числo : ");
int a = Convert.ToInt32(Console.ReadLine());
int numbers = 0;

numbers = (a - (a+a)); 

while (numbers <= a)
{
   Console.WriteLine(numbers);
   numbers = ( numbers + 1);
}

