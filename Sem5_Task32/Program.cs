int [] array = new int [5];
FillArray(array);
PrintArray(array);

void FillArray(int[]masiv)
{
    for (int count = 0; count<masiv.Length; count++)
    {
        masiv[count] = new Random().Next(-9, 9);
    }
}


void PrintArray(int[]masiv)
{
    for (int count = 0; count<masiv.Length; count++)
    {
       Console.WriteLine (masiv[count]);
    }
}

for (int count = 0; count<array.Length; count++)
    {
       Console.WriteLine();
       Console.Write (array[count] * - 1 );
    }





