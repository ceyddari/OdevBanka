using System;
namespace OdevBanka
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriName = "mehmet ali";
            musteri1.MusteriAge = 13;
            musteri1.MusteriId = 1;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriName = "çağla";
            musteri2.MusteriAge = 24;
            musteri2.MusteriId = 2;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriName = "erdal";
            musteri3.MusteriAge = 50;
            musteri3.MusteriId = 3;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriName = "yasemin";
            musteri4.MusteriAge = 45;
            musteri4.MusteriId = 4;

            Console.WriteLine("MÜŞTERİ LİSTESİ");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşterinin adı: " + musteri.MusteriName);
                Console.WriteLine("Müşterinin yaşı: " + musteri.MusteriAge);  
                Console.WriteLine("Müşterinin IDsi: " + musteri.MusteriId);
                Console.WriteLine("--------------------"); 

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);   
            musteriManager.Add(musteri4);

            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);
            musteriManager.Delete(musteri4);

            musteriManager.Update(musteri1);
            musteriManager.Update(musteri2);
            musteriManager.Update(musteri3);
            musteriManager.Update(musteri4);



        }

    }
}
