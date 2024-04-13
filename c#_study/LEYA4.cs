using System;


class Program
{
    static void Main()
    {
        Console.WriteLine($"Введите номер строки: ");
        int k = Convert.ToInt32(Console.ReadLine());
        int mult = 1;
        // Количество строк и столбцов в массиве: 
        int rows = 3, cols = 5;
        // Создание двумерного массива: 
        int[,] nums = new int[rows, cols];
        // добавление модуля Random и присвоение к переменной
        Random rnd = new Random();
        // Значение первого элемента в массиве: 
        int value = rnd.Next(0,10);
        // Заполнение и отображение массива.
        // Перебор строк в массиве:
        for(int i = 0; i < nums.GetLength(0); i++) {
            // Перебор столбцов в строке: 
            for (int j = 0; j < nums.GetLength(1); j++) {
                // Присваивание значения элементу массива: 
                nums[i, j] = value;
                // Это будет значение следующего элемента: 
                value = rnd.Next(0,10);;
                // Отображение элемента в строке:
                Console.Write(nums[i, j] + "\t");
            }
            // Переход к новой строке:
            Console.WriteLine();
        }
        for (int j = 0; j < nums.GetLength(1); j++) {
            mult *= nums[k, j]; 
        }
        
        Console.WriteLine($"Произведение {k}-ой строки равно {mult}");
    }
}
