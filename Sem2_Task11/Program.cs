// Напишите програму которая вводит случайное трехзначное 
// число и удаляет 2 цифру этого числа 

int a = new Random().Next(100, 999);
int centre = 0; 
int centre1 = 0;
int centre2 = 0 ;

centre = a%10;
centre1 = a/100;
centre2 = centre1 * 10 + centre;


Console.WriteLine(a);
Console.WriteLine(centre2);

