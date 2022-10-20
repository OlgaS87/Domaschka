/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/


Console.WriteLine("Введите числа: ");
string[] Array = Console.ReadLine().Split(", ");
int[] NumArray = new int[Array.Length];
for (int i = 0; i < Array.Length; i++)
{
    NumArray[i] = Int32.Parse(Array[i]);
}
Console.WriteLine("[{0}]", string.Join(", ", NumArray));
