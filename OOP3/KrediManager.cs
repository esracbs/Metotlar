using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interfaceleri birbitinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız 
    //kredi türlerinin hepsinde hesaplma işlemi ortaktır ama her kredi türününn hesaplama işlemi değişkenlik gösterir
    interface IKrediManager
    {
        void Hesapla();
        
    }
}
