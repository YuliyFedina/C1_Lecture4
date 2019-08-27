using System;

namespace Ex1
{
    //Создать класс “Телефон”, который содержит следующие данные: 
    //код города, номер телефона, которые не могут быть изменены.
    //Добавить метод, который возвращает строку вида “(999) 999999” или “999999”,
    //если код города отсутствует.
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = new Telephone("999", "999999");
            Console.WriteLine(number1.GetPhone());
            var number2 = new Telephone(null, "999999");
            Console.WriteLine(number2.GetPhone());
        }
    }
}
