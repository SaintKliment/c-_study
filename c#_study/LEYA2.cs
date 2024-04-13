using System;


class Program
{
    static void Main()
    {
        int counterMinus = 0;
        int counterPlus = 0;
        int counterZero = 0;
        // Количество строк и столбцов в массиве: 
        int rows = 3, cols = 5;
        // Создание двумерного массива: 
        int[,] nums = new int[rows, cols];
        // добавление модуля Random и присвоение к переменной
        Random rnd = new Random();
        // Значение первого элемента в массиве: 
        int value = rnd.Next(-100,100);
        // Заполнение и отображение массива.
        // Перебор строк в массиве:
        for(int i = 0; i < nums.GetLength(0); i++) {
            // Перебор столбцов в строке: 
            for (int j = 0; j < nums.GetLength(1); j++) {
                // Присваивание значения элементу массива: 
                nums[i, j] = value;
                // Это будет значение следующего элемента: 
                value = rnd.Next(-100,100);;
                // Отображение элемента в строке:
                Console.Write(nums[i, j] + "\t");
            }
            // Переход к новой строке:
            Console.WriteLine();
        }
        for (int i = 0; i < nums.GetLength(0); i++) {
            for (int j = 0; j < nums.GetLength(1); j++) {
                if ( nums[i, j] < 0) {
                    counterMinus += 1;
                } else if (nums[i, j] > 0) {
                    counterPlus += 1;
                } else if (nums[i, j] == 0) {
                    counterZero += 1;
                }
            }
        }
        Console.WriteLine($"Количество нулей равно {counterZero}");
        Console.WriteLine($"Количество отрицательных равно {counterMinus}");
        Console.WriteLine($"Количество положительных равно {counterPlus}");
    }
}