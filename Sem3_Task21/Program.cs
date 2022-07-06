//Задача 21: Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними 
//в 2D пространстве.


Console.Write("Введите координаты двух точек : ");
int x1 = Convert.ToInt32 (Console.ReadLine());
int y1 = Convert.ToInt32 (Console.ReadLine());
int x2 = Convert.ToInt32 (Console.ReadLine());
int y2 = Convert.ToInt32 (Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
Console.WriteLine(distance);





