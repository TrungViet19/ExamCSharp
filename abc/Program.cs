﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone phone = new MobilePhone();
            phone.PhoneName = "Xiaomi";
            phone.PhonePrice = 1.912f;
            Console.WriteLine(phone.Display());
            Console.ReadLine();


        }
    }
}
