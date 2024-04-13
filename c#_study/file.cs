using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите сумму в рублях, а затем нажмите Enter");
    //Получение строки
    string sumString = Console.ReadLine();
    //Преобразование строки в число (в тип int)
    int intSum = Convert.ToInt32(sumString);
    Console.WriteLine("Введите знак валюты, в которую надо конвертировать, а затем нажмите Enter");
    char znak;
    znak = Console.ReadLine();
    char charZnak = Convert.ToChar(znak);
    if (znak == '$') {
    Console.WriteLine(intSum*90);
    }
  }
}
