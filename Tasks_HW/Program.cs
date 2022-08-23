

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Console.WriteLine("input size of the array");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// Random num = new Random ();
// for (int i = 0; i < size; i++)
// {
//     array[i] = num.Next(100,1000);

// }
// Console.Write($"[{String.Join(",", array)}]");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]%2 == 0)
//     {
//         count = count + 1;
//     }
// }
// Console.Write($" -> {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] ->  0

// Console.WriteLine("input size of the array");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// Random num = new Random ();
// for (int i = 0; i < size; i++)
// {
//     array[i] = num.Next(0,100);

// }
// Console.Write($"[{String.Join(",", array)}]");
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (0 != i % 2)
//     {
//         sum += array[i];
//     }    
// }
// Console.Write($" сумма элементов с нечетными индексами {sum}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// int[] CreateRandomArray(int lenght, int start, int end)
// {
//     int[] RandomArray = new int[lenght];
//     for (int i = 0; i < lenght; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// Console.WriteLine("input number of array elements ");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input the first number of tne array ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input the end element of the array ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(lenght, min, max);
// Console.Write($"[{String.Join(",", array)}]");

// int maxNum = array[0];
// int minNum = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > maxNum)
//     {
//         maxNum = array[i];
//     }
//     if (array[i] < minNum)
//     {
//         minNum = array[i];
//     }
// }
// int diff = Math.Abs(maxNum) - Math.Abs(minNum);
// Console.Write($" максимальное значение {maxNum}, минимальное значение {minNum}, разница {diff}" );
