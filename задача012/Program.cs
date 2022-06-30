int number = new Random().Next(10,10000);
Console.Write(number);
int Thirdnumber ;

if (number < 100) 
{
    Console.WriteLine(" третьего числа нет");


}
if
    ( number > 100 && number < 1000);
{
    Thirdnumber = number % 10;
    Console.Write(Thirdnumber);
} 
if
    ( number > 1000 && number < 10000);
{
    Thirdnumber = (number / 10)% 10;
    Console.Write(Thirdnumber);
} 