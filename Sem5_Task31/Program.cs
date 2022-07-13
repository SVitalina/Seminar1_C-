int [] array = new int [12];
FillArray(array);
PrintArray(array);

void FillArray(int[]masivchik)
{
    for ( int count = 0; count<masivchik.Length; count++)
    {
     masivchik[count]= new Random().Next(-9,9);
    }
}

void PrintArray(int[]masivchik)
{
    for ( int count = 0; count<masivchik.Length; count++)
    {
     Console.Write(array[count]+ " ");
    }
    Console.WriteLine();
}

int negative = 0;
int positive = 0;

for (int count = 0; count < array.Length; count++)
{
        if (array[count] > 0)
    {
        positive += array[count];
    }
    else
    {
        negative += array[count];
    }
}
 Console.WriteLine("Сума негативных чисел ровна: " + negative);
 Console.WriteLine("Сума позитивных чисел ровна: " + positive);




