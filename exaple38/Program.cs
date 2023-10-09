/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

Console.Write("Введите кол-во элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] arrayRealN = new double[N];

for (int i = 0; i < N; i++)
{
    Console.Write($"\nВведите {i + 1}й элемент массива:\t"); // Ввод числа через (,) заработал {N,n}
    arrayRealN[i] = Convert.ToDouble(Console.ReadLine());
}
double max = arrayRealN[0];
double min = arrayRealN[0];

for (int i = 1; i < arrayRealN.Length; i++)
{
    if (max < arrayRealN[i])
    {
        max = arrayRealN[i];
    }
    if (min > arrayRealN[i])
    {
        min = arrayRealN[i];
    }
}

double differenceOfNumbers = max - min;

Console.WriteLine();
Console.Write('[' + string.Join(", ", arrayRealN) + ']');
Console.WriteLine($" -> {differenceOfNumbers}\n");
Console.WriteLine($"Разница между между максимальным ({max}) и минимальным({min}) элементами = {differenceOfNumbers}");