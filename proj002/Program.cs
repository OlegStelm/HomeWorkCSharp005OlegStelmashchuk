/*  **Задача 36**
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0    */

int[] array = new int[5];
int sum = 0;
Console.Write($"[ ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write($"{array[i]} ");
    if (i % 2 == 0)
    {
        sum += array[i];
    }
}
Console.WriteLine($"]");
Console.Write($"Sum of elements of even positions = {sum}");