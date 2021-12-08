using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceChill
{
    class BasvuruManager
    {
      public  void BasvuruYap(IKrediManager krediManager)
        {
            krediManager.Hesapla();
        }

        
    }
}
