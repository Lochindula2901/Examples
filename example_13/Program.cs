/* Yfgbibnt ghjujhfve rjnjhfz yf d[jl ghbybvftn xbckj b dslftn tuj rdflhfn] */
/* 
4->16
5->25 */

/* Console.WriteLine("Введитецелое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;
Console.Write($"{number} -> {square}"); */

/* Напишите программу 
принимает на вход два числа
проверяет является ли первое квадратом второго
 */

 /* Console.WriteLine("Enter integer first number: ");
 int numberA = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Enter integer second number: ");
 int numberB = Convert.ToInt32(Console.ReadLine());

 if ((numberA / numberB) == numberB)
 {
    Console.WriteLine("Yes");
 }
 else 
 {
    Console.WriteLine("No");
 } */

/*  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

/* string dayNumber;
Console.WriteLine("День недели");
dayNumber = Console.ReadLine();

if (dayNumber == "1")
{
    Console.WriteLine($"{dayNumber} -> Понедельник"); */
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = -1 * n;
while(count <= n)
{
    Console.Write($"{count} ");
    count = count + 1;
}