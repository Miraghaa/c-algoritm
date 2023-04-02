int[] numbers = { 15, -20, 5, 7, -5, -6, -7, 87, 90, 64 };
int i = 0;
int musbet = 0;
int menfi = 0;
while (i < numbers.Length)

{
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
