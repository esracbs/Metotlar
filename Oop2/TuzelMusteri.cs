using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    /// <summary>
    /// tuzel:coorporate
    /// </summary>
    class TuzelMusteri:Musteri//<==tüzel müşteri bir müşteridir şeklinde miras aldık inheritance öğrendik müsterinin içinde olan tüm özellikler 
        //tüzel müşteride de var kabul edilir
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
