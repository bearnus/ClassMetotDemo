using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriAdd(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri sisteme eklendi. Müşteri adı : " + musteri.Isım  + musteri.SoyIsım + " " + "Müşteri ID : " + musteri.Id);
        }

        public void MusteriUptade(Musteri musteri1)
        {
            Console.WriteLine("Müşteri bilgisi düzenlendi. Yeni müşteri ad soyad: " + musteri1.Isım + " " + musteri1.SoyIsım);
        }

        public void List(List<Musteri> listMusteri)
        {
            foreach (Musteri musteri in listMusteri)
            {
                Console.WriteLine("Müşteri listeleri: \n\n" + musteri.Id + "\n" + musteri.Isım + "\n" + musteri.SoyIsım + "\n" + musteri.Email + "\n" + musteri.TelefonNumara);
            }
        }
    }
}



