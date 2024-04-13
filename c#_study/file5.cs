// using System;
// class HelloWorld {
//   static void Main() {
//     Random rnd = new Random();
//     int value = rnd.Next(0,100);
//     int m = 7;
//     int n = 5;
    
//     Console.WriteLine( value);
//   }
// }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main()
        {
            // Количество строк и столбцов в массиве: 
            int rows = 3, cols = 5;
            // Создание двумерного массива: 
            int[,] nums = new int[rows, cols];
            // Значение первого элемента в массиве: 
            int value = 1;
            // Заполнение и отображение массива.
            // Перебор строк в массиве:
            for(int i = 0; i < nums.GetLength(0); i++) {
                // Перебор столбцов в строке: 
                for (int j = 0; j < nums.GetLength(1); j++) {
                    // Присваивание значения элементу массива: 
                    nums[i, j] = value;
                    // Это будет значение следующего элемента: 
                    value++;
                    // Отображение элемента в строке:
                    Console.Write(nums[i, j] + "\t");
                }
                // Переход к новой строке:
                Console.WriteLine();
            }
        }
    }
