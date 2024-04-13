// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите первое слагаемое: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Укажите первое слагаемое: ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(a + b);
//   }
//}

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Введите число, пожалуйста: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Число 1: {number - 1}");
//     Console.WriteLine($"Число 2: {number}");
//     Console.WriteLine($"Число 3: {number + 1}");
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите первое число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Укажите первое число: ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Сумма: {a + b}");
//     Console.WriteLine($"Разность: {a - b}");
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int b = a % 3;
//     string txt = $"Вы ввели число {a} и оно ";
//     txt += (b==0?"делится целочисленно на 3!":"не делится целочисленно на 3!");
//     Console.WriteLine(txt);
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int b = a % 5;
//     int c = a % 7;
//     if (b == 2 && c == 1) {
//         Console.WriteLine("да");
    
//     } else {
//         Console.WriteLine("нет");
//     }
    
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int b = a % 4;
//     int c = 10;
//     if (b == 0 && a < c) {
//         Console.WriteLine("да");
    
//     } else {
//         Console.WriteLine("нет");
//     }
    
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int b = 5;
//     int c = 10;
//     if (b <= a && a <= c) {
//         Console.WriteLine("да");
    
//     } else {
//         Console.WriteLine("нет");
//     }
    
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int c = 0;
//     do {
//         a -= 1000;
//         c = c + 1;
//     }
//     while (a >= 1000);
//     Console.Write(c);
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine((a >> 2) % 2);
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int result = (a & 56) >> 3;
//     Console.WriteLine($"Вторая цифра восьмеричного представления числа: {result}");
    
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int n = 3; 
//     a |= 1<< n; 
//     Console.WriteLine(a);
    
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int n = 4; 
//     a &= ~(1<< n); // установит n-ый бит в 1
//     Console.WriteLine(a);
    
//   }
// }
