using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.Name + " " + musteri.LastName);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi. " + musteri.Name + " " + musteri.LastName);
        }

        public void MusteriListele() 
        {
            Console.WriteLine("Müşteriler Listelendi.");
        }
    }
}
