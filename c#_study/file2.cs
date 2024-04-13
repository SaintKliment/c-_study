// using System;
// class InputConsoleDemo {
//   static void Main() {
//   string name;
//   Console.Title = "Давайте познакомимся...";
//   Console.WriteLine("Как вас зовут?");
//   name = Console.ReadLine();
//   string txt = "Очень приятно, "+name+"";
//   Console.Title = "Знакомство состоялось";
//   Console.WriteLine(txt);
//   }
// }

/* ЗАДАЧИ НАЧАЛО ЗДЕСЬ ===> */

// using System;
// class UserMessage {
//   static void Main() {
//     string name, surname;
//     Console.Write("Укажите ваше имя: ");
//     name = Console.ReadLine();
//     Console.Write("Укажите вашу фамилию: ");
//     surname = Console.ReadLine();
//     Console.WriteLine("Your name is "+name+" and surname is "+surname+"");
//   }
// }

// using System;
// class UserMessageTwo {
//   static void Main() {
//     string name, age;
//     Console.Write("Укажите ваше имя: ");
//     name = Console.ReadLine();
//     Console.Write("Укажите ваш возраст: ");
//     age = Console.ReadLine();
//     Console.WriteLine($"Your name is {name} and age is {age}");
//   }
// }

// using System;
// class UserDialog {
//   static void Main() {
//     string day, mounth, data;
//     Console.Write("Укажите день: ");
//     day = Console.ReadLine();
//     Console.Write("Укажите месяц: ");
//     mounth = Console.ReadLine();
//     Console.Write("Укажите номер дня: ");
//     data = Console.ReadLine();
//     Console.WriteLine($"Today is {day} in {mounth} and the {data}");
//   }
// }

// using System;
// class UserDialog {
//   static void Main() {
//     string mounth, days;
//     Console.Write("Укажите месяц: ");
//     mounth = Console.ReadLine();
//     Console.Write("Укажите кол-во дней: ");
//     days = Console.ReadLine();
//     int intDays = Convert.ToInt32(days);
//     // Console.WriteLine(intDays is int); 
//     if (0 < intDays && intDays < 32) {
//         Console.WriteLine($"{mounth} has {days} days");
//     }
//     else {
//         Console.WriteLine("Неверное кол-во дней");
//     }
//   }
// }
    
// using System;
// class Ususing System;
// class HelloWorld {
//   static void Main() {
//     Console.Write("Укажите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int b = a % 3;
//     string txt = $"Вы ввели число {a} и оно ";
//     txt += (b==0?"делится целочисленно на 3!":"не делится целочисленно на 3!");
//     Console.WriteLine(txt);
//   }
// }erDialog {
//   static void Main() {
//     string year;
//     Console.Write("Укажите год рождения: ");
//     year = Console.ReadLine();
//     int intYear = Convert.ToInt32(year);
//     Console.WriteLine(2024-intYear);
//   }
// }

// using System;
// class UserDialog {
//   static void Main() {
//     string year, name;
//     Console.Write("Укажите год рождения: ");
//     year = Console.ReadLine();
//     Console.Write("Укажите имя: ");
//     name = Console.ReadLine();
//     int intYear = Convert.ToInt32(year);
//     Console.WriteLine($"ваше имя {name}");
//     Console.WriteLine(2024-intYear);
//   }
// }



// using System;
// class UserDialog {
//   static void Main() {
//     string age;
//     Console.Write("Укажите возраст: ");
//     age = Console.ReadLine();
//     int intAge = Convert.ToInt32(age);
//     Console.WriteLine(2024-intAge);
//   }
// }
    