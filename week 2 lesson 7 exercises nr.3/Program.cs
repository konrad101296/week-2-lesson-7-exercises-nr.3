Console.WriteLine("Enter number: ");
double number = double.Parse(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine($"{number} jest liczba ujemna");
}
else if (number > 0)
{
    Console.WriteLine($"{number} jest liczba dodatnia");
}
else
{
    Console.WriteLine("podana liczba wynosi zero");
}