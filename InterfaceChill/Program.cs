   using System;

namespace InterfaceChill
{
    class Program
    {
        static void Main(string[] args)
        {
            TasitKrediManager kredi1 = new TasitKrediManager();
            kredi1.Hesapla();

            KonutKrediManager konurkredimanager = new KonutKrediManager();

            IKrediManager kredi2 = new IhtiyacKrediManager();
            kredi2.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konurkredimanager);

        }
    }
}
