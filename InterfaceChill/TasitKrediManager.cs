﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceChill
{
    class TasitKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı"); 
        }
    }
}
