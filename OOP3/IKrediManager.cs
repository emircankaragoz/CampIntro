using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // INTERFACE = ŞABLON 
    interface IKrediManager // Interface şablon görevi görür.
        //Eğer ki birisi bu interface'i kullanırsa aşağıda yazılmış+
        // method şablonları kullanabilir. (Kullanacağı methodun işlevine göre)

        //Birbirinin alternatifi olan ama kod içerikleri farklı olan örnekler için kullanırız.
    {
        void Hesapla();
        void BiseyYap();
    }
}
