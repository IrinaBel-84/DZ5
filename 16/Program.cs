// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте длинну массива ");
int count = Convert.ToInt32(Console.ReadLine());
double[] array = new double[count];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Ввелите следующий элемент массива ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.Write(string.Join(" ", array));
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
}
Console.WriteLine();
Console.WriteLine($"минимальное значение в массиве {min}");
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
}
Console.WriteLine($"минимальное значение в массиве {max}");

double result = 0;
result = max - min;
Console.WriteLine(result);