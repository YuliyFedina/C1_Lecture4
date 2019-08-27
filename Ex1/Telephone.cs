using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Telephone
    {
        public readonly string PhoneCode;
        public readonly string PhoneNubmer;

        public Telephone(string phoneCode, string phoneNumber)
        {
            PhoneCode = phoneCode;
            PhoneNubmer = phoneNumber;
        }

        public string GetPhone()
        {
            if (PhoneCode == null)
            {
                return PhoneNubmer;
            }
            else
            {
                return '(' + PhoneCode + ')' + PhoneNubmer;
            }
        }
    }
}
