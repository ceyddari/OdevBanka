using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBanka
{

    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + ". müşteri eklendi.");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + ". müşteri silindi");
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + ". müşteri güncellendi");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + ". müşteri listelendi");
        }


    }
}
