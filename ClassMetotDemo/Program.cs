using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Isım = "Ahmet";
            musteri1.SoyIsım = "Yıldız";
            musteri1.Email = "yldzzahmet1@yandex.com";
            musteri1.TelefonNumara = 511478963;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Isım = "Mert";
            musteri2.SoyIsım = "Anık";
            musteri2.Email = "muzmert@hotmail.com";
            musteri2.TelefonNumara = 528458963;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Isım = "Hasan";
            musteri3.SoyIsım = "Erdem";
            musteri3.Email = "herdem@gmail.com";
            musteri3.TelefonNumara = 539874450;
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriAdd(musteri1);
            musteriManager.MusteriAdd(musteri2);
            musteriManager.MusteriAdd(musteri3);

            Console.WriteLine("........Sistemdeki kayıtlı müşteriler listeleniyor.......");


        }
    }
}
