using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NokiaPhone nokiaPhone = new NokiaPhone();
            PhoneUser user = new PhoneUser(nokiaPhone);

            user.UsePhone();
        }
    }

    class PhoneUser
    {
        private IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            this._phone = phone;
        }
        public void UsePhone()
        {
            this._phone.Call();
            this._phone.Receive();
        }
    }

    interface IPhone
    {
        void Call();
        void Receive();
    }

    class NokiaPhone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Nokia is calling...");
        }
        public void Receive()
        {
            Console.WriteLine("Nokia received.");
        }
    }
    class ApplePhone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("ApplePhone is calling...");
        }
        public void Receive()
        {
            Console.WriteLine("ApplePhone received.");
        }
    }
}
