/* Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = - n;
while(count <= n)
{
    Console.Write($"{count} ");
    count++;
}     */
/* 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
 */
/* 
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number< 0)
{
    number *= -1;
}

if(number >= 100 && number < 1000)
{
    int lastNumber = number % 10;
    Console.WriteLine($"{number} -> {lastNumber}");
}
else
{
    Console.WriteLine($"{number} -> Третьей цифры нет");
}
 */
/*  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/* Console.WriteLine("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3 целое число: ");
int numberC = Convert.ToInt32(Console.ReadLine());


if (numberA > numberB)
{
    Console.WriteLine($"{numberA} max");
}
if (numberB > numberA);
{
    Console.WriteLine($"{numberA} min");
}
if (numberC > numberA)
{
    Console.WriteLine($"{numberC} max");
} */

/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

/* Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number< 0)
{
    number *= -1;
}

if(number%2==0)
{
    
    Console.WriteLine($"{number} -> Да");
}
else
{
    Console.WriteLine($"{number} -> Нет");
} */

/* /*  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7 */

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

/* Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i += 2)
if (i % 2 == 0)
Console.Write(i + " "); */
/* Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число"); */


int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}

double Length = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Длина отрезка  {Length}");
