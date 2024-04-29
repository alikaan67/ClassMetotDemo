using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public void BilgileriYazdir() 
        {
            Console.WriteLine("Musteri Id:",Id,"Musteri Ad:",Ad,"Musteri Soyad",Soyad);
        
        }
    }
}
