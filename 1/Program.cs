// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Text(string text)
{
    System.Console.WriteLine(text);
    string message = Console.ReadLine();
    int result = Convert.ToInt32(message);
    return result;
}

int[] Array(int length)
{
    int[] array = new int[length];
    for (int i=0; i < array.Length; i++)
    {
        array [i]= Text($"Введите {i+1}-й элемент");
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}] = {array [i]}");
    }
}

int CountPositiveNumbers (int[] array)
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

int length = Text("Введите количество элементов:");
int[] array;
array = Array(length);
PrintArray(array);
System.Console.WriteLine($"Количество чисел >0 - {CountPositiveNumbers(array)}");