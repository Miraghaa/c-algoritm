using System.Runtime.InteropServices;

int[] numbers = { 1, 5, 105, 25, 93, 100 };
int i = 0;
int boyuk = numbers[0];
while (i < numbers.Length) 
{
    if(numbers[i] >boyuk  )
    {
        boyuk = numbers[i];
    }
    i++;

}

Console.WriteLine(boyuk);
