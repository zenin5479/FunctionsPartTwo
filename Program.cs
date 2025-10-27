using System;

// Функции продолжение
// Задача: Задайте массив заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество чётных чисел в массиве
// Задача: Задайте одномерный массив, заполненный случайными числами
// Найдите сумму элементов, стоящих на нечётных позициях
// Задача: Задайте массив вещественных чисел
// Найдите разницу между максимальным и минимальным элементов массива
// Задача:  Задан массив из случайных цифр на 15 элементов на вход подаётся трёхзначное натуральное число
// Напишите программу, которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом
// {0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
// {4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет
// Задача: На вход подаются два числа случайной длины
// Найдите произведение каждого разряда первого числа на каждый разряд второго
// Ответ запишите в массив
// 24, 132 -> {2, 6, 4, 4, 12, 8}
// - Задача: Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений
// Подсчитайте их количество 
// - Задача: Дан массив массивов, состоящих из натуральных чисел, размер которого 5
// Для каждого элемента массива требуется найти сумму его элементов и вывести массив с наибольшей суммой
// Если таких массивов несколько, вывести массив с наименьшим индексом -

namespace FunctionsPartTwo
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("---------------------------------------");
         Console.WriteLine("Поиск чётных чисел в одномерном массиве");
         Console.WriteLine("---------------------------------------");
         Console.WriteLine("Массив случайных положительных трехзначных чисел:");
         int a = new Random().Next(10, 21);
         int[] chance = new int[a];
         // Метод заполнения массива случайными трехзначными положительными числами
         void FillArrayInt(int[] series)
         {
            Random aimless = new Random();
            int i = 0;
            while (i < series.Length)
            {
               series[i] = aimless.Next(100, 1000);
               i++;
            }
         }

         FillArrayInt(chance);

         // Метод распечатки массива
         void PrintArrayInt(int[] group)
         {
            int i = 0;
            while (i < group.Length)
            {
               Console.Write(group[i] + " ");
               i++;
            }

            Console.WriteLine();
         }

         PrintArrayInt(chance);

         // Метод подсчета кол четных значений в массиве
         int PrintArrayEvenInt(int[] set)
         {
            int count = 0;
            int i = 0;
            while (i < set.Length)
            {
               if (set[i] % 2 == 0)
               {
                  count++;
               }

               i++;
            }

            return count;
         }

         int itemize = PrintArrayEvenInt(chance);
         Console.WriteLine("Количество четных чисел в массиве = {0}", itemize);

         Console.WriteLine("----------------------------------------------------------------------------------");
         Console.WriteLine("Нахождение суммы элементов одномерного массива, расположенных по нечётным индексам");
         Console.WriteLine("----------------------------------------------------------------------------------");

         Console.WriteLine("Массив случайных положительных чисел:");
         int b = new Random().Next(10, 21);
         int[] assortment = new int[b];
         FillArrayInt(assortment);

         PrintArrayInt(assortment);

         // Метод вычисления суммы значений элементов массива расположенных по нечётным индексам
         int ArraySumOddIndex(int[] cluster)
         {
            int amount = 0;
            int i = 0;
            while (i < cluster.Length)
            {
               if (i % 2 != 0)
               {
                  amount += cluster[i];
               }

               i++;
            }

            return amount;
         }

         int group = ArraySumOddIndex(assortment);
         Console.WriteLine("Сумма значений элементов одномерного массива расположенных по нечётным индексам = {0}", group);

         Console.WriteLine("-------------------------------------------------------------------------------");
         Console.WriteLine("Нахождение разницы между максимальным и минимальным значением элементов массива");
         Console.WriteLine("-------------------------------------------------------------------------------");
         Console.WriteLine("Массив случайных вещественных чисел:");
         int c = new Random().Next(1, 20);
         double[] stochastic = new double[c];
         // Метод заполнения массива случайными вещественными числами
         void FillArrayDouble(double[] array)
         {
            Random arbitrary = new Random();
            int i = 0;
            while (i < array.Length)
            {
               array[i] = Math.Round(arbitrary.NextDouble() + arbitrary.Next(-1000000, 1000000), 3);
               i++;
            }
         }

         FillArrayDouble(stochastic);

         // Метод распечатки массива
         void PrintArrayDouble(double[] array)
         {
            int i = 0;
            while (i < array.Length)
            {
               Console.WriteLine(array[i]);
               i++;
            }

            Console.WriteLine();
         }

         PrintArrayDouble(stochastic);

         // Метод нахождения разности максимального и минимального значений элементов массива
         void DifferenceExtremesArray(double[] array)
         {
            double max = array[0];
            double min = array[0];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < array.Length)
            {
               if (array[i] > max)
               {
                  max = array[i];
                  j = i;
               }
               if (array[i] < min)
               {
                  min = array[i];
                  k = i;
               }

               i++;
            }

            Console.WriteLine("array[" + j + "]  max = " + max + ";  array[" + k + "]  min = " + min);
            Console.WriteLine("max - min = " + (max - min)); Console.WriteLine("");
         }

         DifferenceExtremesArray(stochastic);

         Console.WriteLine("---------------------------------------------------------------");
         Console.WriteLine("Определение наличия в массиве чисел заданной последовательности");
         Console.WriteLine("---------------------------------------------------------------");
         // Метод заполнения массива случайными трехзначными положительными числами
         int[] series = new int[15];

         void RealizationArray(int[] range)
         {
            Random probabilistic = new Random();
            int i = 0;
            while (i < range.Length)
            {
               range[i] = probabilistic.Next(0, 10);
               i++;
            }
         }

         RealizationArray(series);

         // Метод распечатки массива
         void PrintingArray(int[] compilation)
         {
            int i = 0;
            while (i < compilation.Length)
            {
               Console.Write(compilation[i] + " ");
               i++;
            }

            Console.WriteLine();
         }

         PrintingArray(series);

         // Заменить на ручной ввод последовательности
         Random desultory = new Random(); 
         int numberH = desultory.Next(100, 1000);
         Console.WriteLine("Введите последовательность для поиска: " + numberH);

         // Метод определения есть в массиве последовательность из трех элементов
         void Sequence(int[] selection, int number)
         {
            int num = number / 10;
            int a3 = number - num * 10;
            int a2 = num - num / 10 * 10;
            int a1 = num / 10;
            int i = 0;
            int f = 0;
            int L = selection.Length;
            while (i < L)
            {
               if (selection[i] == a1 && (L - i) > 2)
               {
                  i++;
                  if (selection[i] == a2)
                  {
                     i++;
                     if (selection[i] == a3)
                     {
                        f = 1;
                     }
                  }
               }
               i++;
            }
            if (f != 1)
            {
               Console.WriteLine("Последовательность " + number + " НЕТ в массиве");
            }
            else
            {
               Console.WriteLine("Последовательность " + number + " ЕСТЬ в массиве");
            }
         }

         Sequence(series, numberH);

         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Произведение разрядов первого и второго числа");
         Console.WriteLine("---------------------------------------------");
         // Задание чисел
         Random fortuitous = new Random();
         int L1 = fortuitous.Next(-1000, 1000);
         int L2 = fortuitous.Next(0 - 1000, 1000);
         // Метод определения кол цифр в числе
         int KolNumber(int L)
         {
            int count = 0;
            L = Math.Abs(L);
            while (L > 0)
            {
               L = L / 10;

               count++;
            }
            return count;
         }
         int L3 = KolNumber(L1) * KolNumber(L2);
         int[] arrayL1L2 = new int[L3];
         // Задается размер массива с помощью метода определения кол цифр в числе
         int[] arrayL1 = new int[KolNumber(L1)];
         int[] arrayL2 = new int[KolNumber(L2)];
         // Метод заполнения массива цифрами из числа
         void FillArrayN(int[] array, int L)
         {
            for (int i = array.Length - 1; i >= 0; i--)
            {
               array[i] = L - L / 10 * 10;
               L = L / 10;

            }
         }

         FillArrayN(arrayL1, L1);
         FillArrayN(arrayL2, L2);

         // Метод распечатки массива
         void PrintArrayN(int[] array)
         {
            for (int i = 0; i < array.Length; i++)
            {
               Console.Write(array[i] + " ");
            }
            Console.WriteLine();
         }
         // Распечатка массива, состоящий из цифр числа
         PrintArrayN(arrayL1);
         PrintArrayN(arrayL2);

         // Метод перемножения элементов массива, состоящих из цифр числа
         void ArrayL1L2(int[] arrayL1, int[] arrayL2, int[] arrayL1L2)
         {
            int k = 0;
            for (int i = 0; i < arrayL1.Length; i++)
            {
               for (int j = 0; j < arrayL2.Length; j++)
               {
                  arrayL1L2[k] = arrayL1[i] * arrayL2[j];
                  k++;
               }
            }
         }
         // Задается массив с перемноженными элементами исходныъх двух массивов

         ArrayL1L2(arrayL1, arrayL2, arrayL1L2);
         Console.WriteLine("Массив с перемноженными элементами");
         PrintArrayN(arrayL1L2);
      }
   }
}