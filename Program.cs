// // Задача 34: Задайте массив заполненный случайными положительными 
// // трёхзначными числами. Напишите программу, 
// // которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2


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

//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// double[] array = new double[5];
//   for (int i = 0; i < array.Length; i++ )
//   {
//     array[i] = new Random().Next(1, 100);
//     Console.Write(array[i] + " ");
//   }

// double maxNumber = array[0];
// double minNumber = array[0];

//   for (int i = 1; i < array.Length; i++)
//   {
//     if (maxNumber < array[i])
//     {
//       maxNumber = array[i];
//     }
//         if (minNumber > array[i])
//     {
//       minNumber = array[i];
//     }
//   }

//   double decision = maxNumber - minNumber;

//   Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами равна: {decision}");

///////////////// Конец третьей задачи ///////////
