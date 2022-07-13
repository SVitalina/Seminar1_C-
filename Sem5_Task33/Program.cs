// Задайте массив. Напишите программу,
// которая определяет, присутствует ли заданное число в массиве.

int [] array = new int [10];
FillArray(array);
PrintArray(array);

void FillArray(int[]masiv)
{
    for (int count = 0; count<masiv.Length; count++)
    {
        masiv[count] = new Random().Next(0, 10);
    }
}

void PrintArray(int[]masiv)
{
    for (int count = 0; count<masiv.Length; count++)
    {
       Console.WriteLine (masiv[count]);
    }
}

int find = 4;
for (int count = 0; count<array.Length; count++)
{
    if (array [count] == find )
    {
      Console.WriteLine("Нужный элемент находится под индексом : " +count);
      break;
    }
    else
    {
    }
}
