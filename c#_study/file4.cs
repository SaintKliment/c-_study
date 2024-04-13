// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int n = 2; 
//     a = a ^ (1<< n); 
//     Console.WriteLine(a);
    
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     if (a % 3 == 0 && a % 7 == 0) {
//         Console.WriteLine("DA");
//     } else {Console.WriteLine("NET");}
    
//   }
// }


// using System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите первое число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Укажите второе число: ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     if (a == b) {
//         Console.WriteLine($"{a} = {b}");
//     }
//     if (a > b) {
//         Console.WriteLine($"{a} > {b}");
//     }
//     if (a < b) {
//         Console.WriteLine($"{a} < {b}");
//     }
//   }
// }


// using System;
// class HelloWorld {
//   static void Main() {
//     int a = 1;
//     int b = 0;
//     while (a != 0) {
//         Console.WriteLine("Укажите число: ");
//         a = Convert.ToInt32(Console.ReadLine());   
//         b += a;
//         Console.WriteLine($"сумма чисел = {b}");
//     }
    
//   }
// }


// using System;
// class HelloWorld {
//   static void Main() {
//         Console.WriteLine("Укажите номер дня: ");
//         int a = Convert.ToInt32(Console.ReadLine());   
//         if (1 <= a && a <= 7) {
//             switch (a) {
//                 case 1:
//                     Console.WriteLine("пн");
//                     break;
//                 case  2:
//                     Console.WriteLine("вт");
//                     break;
//                 case  3:
//                     Console.WriteLine("ср");
//                     break;
//                 case  4:
//                     Console.WriteLine("чт");
//                     break;
//                 case  5:
//                     Console.WriteLine("пт");
//                     break;
//                 case  6:
//                     Console.WriteLine("сб");
//                     break;
//                 case  7:
//                     Console.WriteLine("вс");
//                     break;

// }

//         }
//         else {
//     Console.WriteLine("число не входит в диапозон");
// }
    
//   }
// }


// using System;
// class HelloWorld {
//   static void Main() {
//         Console.WriteLine("Укажите день: ");
//         string name = Console.ReadLine();
//             switch (name) {
//                 case "пн":
//                     Console.WriteLine("1");
//                     break;
//                 case  "вт":
//                     Console.WriteLine("2");
//                     break;
//                 case  "ср":
//                     Console.WriteLine("3");
//                     break;
//                 case  "чт":
//                     Console.WriteLine("4");
//                     break;
//                 case  "пт":
//                     Console.WriteLine("5");
//                     break;
//                 case  "сб":
//                     Console.WriteLine("6");
//                     break;
//                 case  "вс":
//                     Console.WriteLine("7");
//                     break;
//                     default:
//                     Console.WriteLine("нет такого дня!");
//                     break;

// }

        
    
//   }
// }
// using System;
// class HelloWorld {
//   static void Main() {
//     int a = 1;
//     int b = 0;
//     while (a != 0) {
//         Console.WriteLine("Укажите число: ");
//         int c = Convert.ToInt32(Console.ReadLine());   
//         if (c % 2 != 0) {
//             b += c;
//         } else {
//             a -= 1;
//         }        
//         Console.WriteLine($"сумма нечетных чисел чисел = {b}");
//     }
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     int a = 1;
//     int b = 0;
//     while (a != 0) {
//         Console.WriteLine("Укажите число: ");
//         int c = Convert.ToInt32(Console.ReadLine()); 
//         if (c > 0) {
//             b += c*c;
//         } else {
//             a -= 1;
//         }
//     } 
//     Console.WriteLine($"{b} равна сумма квадратов");
//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     Console.WriteLine("Укажите первое число: ");
//     int a = Convert.ToInt32(Console.ReadLine()); 
//     Console.WriteLine("Укажите второе число: ");
//     int b = Convert.ToInt32(Console.ReadLine()); 
//     for (Console.WriteLine("Начало выполнения цикла"); a <= b; a++){
//         Console.WriteLine(a);
//     }

//   }
// }

// using System;
// class HelloWorld {
//   static void Main() {
//     int a = 1;
//     int sum = 0;
//     while (a != 0) {
//         Console.WriteLine("Укажите первое число: ");
//         int number = Convert.ToInt32(Console.ReadLine()); 
//         if (number % 5 == 2 || number % 3 == 1) {
//             sum += number;
//         }
//         else {
//             Console.WriteLine("Число не удовлетворяет условиям");
//             a -= 1;
//         }
//     }
//         Console.WriteLine(sum);
//   }
// }
