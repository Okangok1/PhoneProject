using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhoneManager phoneManager = new IPhoneManager(new InMemoryPhoneDal());

            foreach (var phone in phoneManager.GetAll())
            {
                Console.WriteLine(phone.PhoneName);
            }

           
        }
    }
}
