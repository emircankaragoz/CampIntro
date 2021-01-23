using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
            // IKrediManager => Tüm kredilerin referansını tutuyor.
        {
            // Başvuran bilgilerini değerlendirme
            // ...
            // Hangi kredi türü gönderilirse onun referansı üzerinden işlem gerçekleştirilecek.
            krediManager.Hesapla();
            loggerService.Log();
            
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
