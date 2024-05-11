using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Linq;

namespace kimmilyonerolmakister
{
    internal class oyun
    {
        public ArrayList Sorular=new ArrayList();
        public double toplam;
        public double kesinpara;
        public oyun()
        {
            Sorular = new ArrayList();
            toplam = 0;
        } 
        public void soruekle(string metin,string[]secenekler,string dogrusecim,double sorudegeri)
        {
            sorusinifi s=new sorusinifi(metin,secenekler,dogrusecim,sorudegeri);
            Sorular.Add(s);
        }
        public void sorugoster() 
        {
            for (int i = 0; i < Sorular.Count; i++)
            {
                Console.WriteLine("toplam para"+toplam+"tl");
                sorusinifi soru=(sorusinifi)Sorular[i];
                Console.WriteLine((i+1)+".soru:"+soru.metin);
                                                   
                
                for (int j = 0; j < soru.secenekler.Length; j++) 
                {

                    string secenekler = " ";
                    switch (j)
                    {
                        case 0:
                            secenekler = "a";
                            break;
                        case 1:
                            secenekler = "b";
                            break;
                        case 2:
                            secenekler = "c";
                            break;
                        case 3:
                            secenekler = "d";
                            break;
                    }
                    Console.Write(secenekler + ") " + soru.secenekler[j]+" ");

                }
                Console.WriteLine();

                string gelencevap = Console.ReadLine();

                if (gelencevap == soru.dogrusecim)
                {
                    Console.WriteLine("mal değilmişin");
                    toplam += soru.sorudegeri;
                    kesinpara = toplam;
                }
                else
                {
                    Console.WriteLine("gg");
                    Console.WriteLine("0 tl");
                    break;
                }
                Console.WriteLine("para mı? devam mı?");
                Console.WriteLine("Evet :parayı al kaç");
                Console.WriteLine("Hayır :devamke ");
                string devam = Console.ReadLine();

                if (devam == "Evet")
                {
                    kesinpara = toplam;
                }else if(devam == "Hayır")
                {
                    Console.WriteLine("kazanılan para:"+kesinpara);
                    break;
                }
            }
            


        }





    }
}
