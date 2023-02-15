// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("введите количество элементов массива ");
int count = Convert.ToInt32(Console.ReadLine());
int[]array = new int [count];
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(-99999, 99999);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");    
}
int result = 0;
for (int i = 0; i < array.Length; i+=2)
{
    result = result + array[i];
}
Console.WriteLine("");
Console.WriteLine(result);