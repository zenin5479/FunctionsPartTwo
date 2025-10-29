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
// Задача: На вход подаются два числа случайной длины
// Найдите произведение каждого разряда первого числа на каждый разряд второго
// Ответ запишите в массив
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
         Console.WriteLine("Количество четных чисел в массиве: {0}", itemize);

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
         Console.WriteLine("Сумма значений элементов одномерного массива расположенных по нечётным индексам: {0}", group);

         Console.WriteLine("-------------------------------------------------------------------------------");
         Console.WriteLine("Нахождение разницы между максимальным и минимальным значением элементов массива");
         Console.WriteLine("-------------------------------------------------------------------------------");
         Console.WriteLine("Массив случайных вещественных чисел:");
         int c = new Random().Next(10, 20);
         double[] stochastic = new double[c];
         // Метод заполнения массива случайными вещественными числами
         void FillArrayDouble(double[] array)
         {
            Random arbitrary = new Random();
            int i = 0;
            while (i < array.Length)
            {
               array[i] = Math.Round(arbitrary.NextDouble() + arbitrary.Next(-999, 1000), 3);
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

            Console.WriteLine("Элемент массива по индексу [" + j + "] имеет максимальное значение: " + max);
            Console.WriteLine("Элемент массива по индексу [" + k + "] имеет минимальное значение: " + min);
            Console.WriteLine("Разница между максимальным и минимальным значением элементов массива: " + (max - min));
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

         // Получение случайной последовательности для поиска
         Random desultory = new Random();
         int numeral = desultory.Next(100, 1000);
         Console.WriteLine("Введите последовательность для поиска: " + numeral);

         // Метод определения есть в массиве последовательность из трех элементов
         void Sequence(int[] selection, int edition)
         {
            int crowd = edition / 10;
            int digitthree = edition - crowd * 10;
            int digittwo = crowd - crowd / 10 * 10;
            int digitone = crowd / 10;
            int i = 0;
            int j = 0;
            int k = selection.Length;
            while (i < k)
            {
               if (selection[i] == digitone && k - i > 2)
               {
                  i++;
                  if (selection[i] == digittwo)
                  {
                     i++;
                     if (selection[i] == digitthree)
                     {
                        j = 1;
                     }
                  }
               }

               i++;
            }

            if (j == 1)
            {
               Console.WriteLine("Последовательность " + edition + ": имеется в массиве");
            }
            else
            {
               Console.WriteLine("Последовательность " + edition + ": отсутствует в массиве");
            }
         }

         Sequence(series, numeral);

         Console.WriteLine("------------------------------------------------");
         Console.WriteLine("Поразрядное произведение первого и второго числа");
         Console.WriteLine("------------------------------------------------");
         // Задание чисел
         Random fortuitous = new Random();
         int issueone = fortuitous.Next(10, 1000000);
         int issuetwo = fortuitous.Next(10, 1000000);
         // Метод определения кол цифр в числе
         int NumberDigits(int tracker)
         {
            int indicator = 0;
            tracker = Math.Abs(tracker);
            while (tracker > 0)
            {
               tracker /= 10;

               indicator++;
            }

            return indicator;
         }

         int composition = NumberDigits(issueone) * NumberDigits(issuetwo);
         int[] setcomposition = new int[composition];
         // Задается размер массива с помощью метода определения количества цифр в числе
         int[] setone = new int[NumberDigits(issueone)];
         int[] settwo = new int[NumberDigits(issuetwo)];
         // Метод заполнения массива цифрами из числа
         void LoadArray(int[] array, int register)
         {
            int i = array.Length - 1;
            while (i >= 0)
            {
               array[i] = register - register / 10 * 10;
               register /= 10;
               i--;
            }
         }

         LoadArray(setone, issueone);
         LoadArray(settwo, issuetwo);

         // Метод распечатки массива
         void PublicationArray(int[] array)
         {
            int i = 0;
            while (i < array.Length)
            {
               Console.Write(array[i] + " ");
               i++;
            }

            Console.WriteLine();
         }

         // Распечатка массива, цифр числа
         Console.WriteLine("Массив цифр первого числа:");
         PublicationArray(setone);
         PublicationArray(settwo);

         // Метод перемножения элементов массива, состоящих из цифр числа
         void MultiplicationArray(int[] massifone, int[] massiftwo, int[] calculationarray)
         {
            int k = 0;
            int i = 0;
            while (i < massifone.Length)
            {
               int j = 0;
               while (j < massiftwo.Length)
               {
                  calculationarray[k] = massifone[i] * massiftwo[j];
                  k++;
                  j++;
               }

               i++;
            }
         }

         // Задается массив с перемноженными элементами исходных двух массивов
         MultiplicationArray(setone, settwo, setcomposition);
         Console.WriteLine("Массив с перемноженными элементами:");
         PublicationArray(setcomposition);

         Console.WriteLine("------------------------------------------------------------");
         Console.WriteLine("Массив цифр сумма которых в три раза меньше их произведений:");
         Console.WriteLine("------------------------------------------------------------");
         int counter = 0;
         int i = 1;
         while (i <= 1000000)
         {
            int reference = i;
            int total = 0;
            int product = 1;
            bool ifzero = false;
            while (reference > 0)
            {
               int character = reference % 10;
               total += character;
               product *= character;
               reference /= 10;
               if (character == 0)
               {
                  ifzero = true;
                  break;
               }
            }

            if (!ifzero && product == 3 * total)
            {
               counter++;
               Console.Write(i + " ");
            }

            i++;
         }

         Console.WriteLine("Количество чисел: {0}", counter);
      }
   }
}