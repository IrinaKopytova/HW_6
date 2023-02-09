// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел в массиве: ");
int M = Convert.ToInt32(Console.ReadLine());

int [] array = new int [M];
for ( int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(string.Join(", ", array));

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");