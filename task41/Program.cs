/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3
*/


int countOfDigitGreaterThan0 (int[] array)
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
return count;
}

Console.Write("Введите элементы(через пробел): ");
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); // Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int countOfDigit = countOfDigitGreaterThan0(numbers);
Console.WriteLine($"Кол-во элементов > 0: {countOfDigit}");
