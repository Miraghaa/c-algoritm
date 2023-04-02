
int result = 93;
if (result < 0 && result > 100)
{

}
else if (result > 90 && result <= 100)
{
    Console.WriteLine("A");
}
else if (result > 80 && result < 91)
{
    Console.WriteLine("B");
}
else if (result > 70 && result < 81)
{
    Console.WriteLine("c");
}
else if (result > 60 && result < 71)
{
    Console.WriteLine("D");
}
else if (result > 50 && result < 61)
{
    Console.WriteLine("E");
}
else
{
    Console.WriteLine("F");
}