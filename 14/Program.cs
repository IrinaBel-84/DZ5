// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("введите количество элементов массива ");
int count = Convert.ToInt32(Console.ReadLine());

int [] array = new int [count];
for (int i = 0; i < array.Length; i++)
{
   array[i]= new Random().Next(100,1000);
}
for (int i = 0; i < array.Length; i++)
{
   Console.Write($"{array[i]}, ");
}
Console.WriteLine();
int b =0;
for (int i = 0; i < array.Length; i++)
{
   if (array[i]%2 == 0)
   {
    b = b+1;
   } 
}
Console.Write(b);




