int[] numbers = { 15, -20, 5, 7, -5, -6, -7, 87, 90, 64 };
int i = 0;
int j = 1;
int musbet = 0;
int menfi = 0;
while (i < numbers.Length)

{
    numbers[i] = numbers[i] / j;
    if (numbers[i] > 0)
    {
        musbet++;
    }
    else
    {
        menfi++;

    }
    i++;

}
Console.WriteLine(musbet);
Console.WriteLine(menfi);