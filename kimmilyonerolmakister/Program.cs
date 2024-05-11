using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace kimmilyonerolmakister
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region

            oyun oyun = new oyun();

            oyun.soruekle("Hasbihal, ne demektir? ", new string[] { "gürültü ", "geçmiş", "sohbet", "özlem" }, "c",10);
            oyun.soruekle("Hangi klasik eserin yazarı Yakup Kadri Karaosmanoğlu'dur? ", new string[] { "Dokuzuncu Hariciye Koğuşu ", "Dokuzuncu Hariciye Koğuşu", "Sodom ve Gomore", " Ateşten Gömlek" }, "c",20);
            oyun.soruekle("Azı dişi hangisinin eş anlamlısıdır? ", new string[] { "Sindirici diş ", "Öğütücü diş", "Koparıcı diş", "Kesici diş" }, "b",50);
            oyun.soruekle("Siklamen adlı bitkinin diğer adı nedir? ", new string[] { "Tavşankulağı", "Aslanağzı", " Kasımpatı", "Kaynanadili" }, "a",40);
            oyun.soruekle("Hangisi atletizmde dekatlon'da yarışan sporcuların mücadele ettikleri dallardan biri değildir?", new string[] { "Cirit atma", "Yüzme", " 100 metre koşusu", "Sırıkla atlama" }, "b",100);
            oyun.soruekle("Siklamen adlı bitkinin diğer adı nedir? ", new string[] { "Tavşankulağı", "Aslanağzı", " Kasımpatı", "Kaynanadili" }, "a",30);

            oyun.sorugoster();

            #endregion








        }

    }
}
