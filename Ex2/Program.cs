using System;

namespace Ex2
{
    //Преобразовать класс “Телефон” на работу со свойствами
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = new Telephone("1999", "1999999");
            Console.WriteLine(number1.OutputPhone);
            var number2 = new Telephone(null, "1999999");
            Console.WriteLine(number2.OutputPhone);
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

        public string OutputPhone
        {
            get
            {
                if (_phoneCode == null) return _phoneNumber;

                return $"({PhoneCode}){PhoneNumber}";
            }
        }
    }
}
