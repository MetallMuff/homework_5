// // Задача 34: Задайте массив заполненный случайными положительными 
// // трёхзначными числами. Напишите программу, 
// // которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

/*
Console.WriteLine("Введите количество трехзначных чисел в массиве (например 3 или 5)");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
addedNumbers (numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int j = 0; j < numbers.Length; j++)
if (numbers[j] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void addedNumbers (int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/

//////////////Конец первой задачи /////////



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// num_random_array(numbers);
// Console.WriteLine("Вот наш массив: ");
// print_array(numbers);
// int sum = 0;

// for (int i = 0; i < numbers.Length; i+=2)
//     sum += numbers[i];

//     Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

// void num_random_array(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void print_array(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

//////////////////// Конец второй задачи ///////////////