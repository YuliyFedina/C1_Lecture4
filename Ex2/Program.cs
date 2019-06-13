using System;

namespace Ex2
{
    //Преобразовать класс “Телефон” на работу со свойствами
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = new Telephone("999", "999999");
            Console.WriteLine(number1.OutputPhone());
            var number2 = new Telephone(null, "999999");
            number2.OutputPhone();
            Console.WriteLine(number2.OutputPhone());
        }
    }
    public class Telephone
    {
        private readonly string _phoneCode;
        private readonly string _phoneNumber;

        public string PhoneCode
        {
            get
            {
                return _phoneCode;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
        }

        public Telephone(string phoneCode, string phoneNumber)
        {
            _phoneCode = phoneCode;
            _phoneNumber = phoneNumber;
        }

        public string OutputPhone()
        {
            if (PhoneCode == null)
            {
                return PhoneNumber;
            }
            else
            {
                return '(' + PhoneCode + ')' + PhoneNumber;
            }
        }
    }
}
