using System;

class Program
{
    static void Main()
    {
        int max = 0;
        // Количество строк и столбцов в массиве: 
        int rows = 3, cols = 5;
        // Создание двумерного массива: 
        int[,] nums = new int[rows, cols];
        // добавление модуля Random и присвоение к переменной
        Random rnd = new Random();
        // Значение первого элемента в массиве: 
        int value = rnd.Next(0,100);
        // Заполнение и отображение массива.
        // Перебор строк в массиве:
        for(int i = 0; i < nums.GetLength(0); i++) {
            // Перебор столбцов в строке: 
            for (int j = 0; j < nums.GetLength(1); j++) {
                // Присваивание значения элементу массива: 
                nums[i, j] = value;
                // Это будет значение следующего элемента: 
                value = rnd.Next(0,100);;
                // Отображение элемента в строке:
                Console.Write(nums[i, j] + "\t");
            }
            // Переход к новой строке:
            Console.WriteLine();
        }
        for(int j = 0; j < nums.GetLength(1); j++) {
            if (nums[0, j] > max) {
                max = nums[0, j];
            }
        }
        Console.WriteLine($"Максимальный el первой строчки равен {max}");
    }
}