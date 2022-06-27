Console.Write("Введите первое число  ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число  ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write(numberA);
    Console.Write(" больше чем ");
    Console.Write(numberB);
}
else
{
    Console.Write(numberB);
    Console.Write(" больше чем ");
    Console.Write(numberA);
}