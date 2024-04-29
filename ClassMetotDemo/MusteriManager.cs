using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public List<Musteri> musteriler = new List<Musteri>();
        public void MusteriEkle (Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine("Müşteri başarıyla eklendi");

        }
        public void MusterileriListele()
        {
            if (musteriler.Count > 0)
            {
                Console.WriteLine("Mevcut müşteriler:");
                foreach (var musteri in musteriler)
                {
                    Console.WriteLine("Müşteri ID:",musteri.Id, "Adı:", musteri.Ad ,"Soyadı:", musteri.Soyad);
                }
            }
            else
            {
                Console.WriteLine("Henüz hiç müşteri yok.");
            }
        }
        public void MusteriSil(int musteriId)
        {
            int index = -1; 

            
            for (int i = 0; i < musteriler.Count; i++)
            {
                if (musteriler[i].Id == musteriId)
                {
                    index = i; 
                    break;
                }
            }

            
            if (index != -1)
            {
                musteriler.RemoveAt(index); 
                Console.WriteLine("Müşteri başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip müşteri bulunamadı.");
            }
        }

    }
}
