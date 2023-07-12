// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine());
if (num < 100) 
{
Console.Write("У данного числа третьей цифры нет");
}
else
{
    int[] arr = num.ToString().ToCharArray().Select(x => x - '0').ToArray();
    Console.WriteLine(arr[2]);
}