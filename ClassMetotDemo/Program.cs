

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // MusteriManager sınıfından bir örnek oluşturuyoruz
            MusteriManager musteriManager = new MusteriManager();

            // Örnek müşteriler oluşturuyoruz
            Musteri musteri1 = new Musteri { Id = 1, Ad = "Ahmet", Soyad = "Yılmaz" };
            Musteri musteri2 = new Musteri { Id = 2, Ad = "Ayşe", Soyad = "Kaya" };
            Musteri musteri3 = new Musteri { Id = 3, Ad = "Mehmet", Soyad = "Demir" };

            // Müşteri eklemek için MusteriEkle metodunu kullanıyoruz
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            // Müşterileri listelemek için MusterileriListele metodunu kullanıyoruz
            musteriManager.MusterileriListele();

            // Müşteri silmek için MusteriSil metodunu kullanıyoruz
            musteriManager.MusteriSil(2);

            // Silindikten sonra tekrar müşterileri listeliyoruz
            musteriManager.MusterileriListele();

            Console.ReadLine();
        }
    }
}
