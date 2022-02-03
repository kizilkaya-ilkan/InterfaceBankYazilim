using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager KonutKredisi = new KonutKredisi();
            IKrediManager TasitKredisi = new TasitKredisi();
            IKrediManager ihtiyacKredisi = new ihtiyacKredisi();
            ILogService VeritabaninaLogKaydet = new Database();
            KredinfoSystem kredinfo = new KredinfoSystem();
            ILogService Smsgönder = new Sms();
            List<ILogService> logServices = new List<ILogService> { new Database(), new Sms() };
            List<IKrediManager> krediler = new List<IKrediManager> { KonutKredisi, TasitKredisi, ihtiyacKredisi };
            Console.WriteLine("Hangi Tür İşlem Yapmak İstediniz ? ");
            Console.WriteLine("1)Konut Kredisi  \n2)Taşıt Kredisi \n3)İhtiyaç Kredisi \n4)Genel Kredi Bilgi Al \n5)Başvuru Yap");

            int secenek = int.Parse(Console.ReadLine());

            if (secenek == 1)
            {
                KonutKredisi.Ekle();
            }
            if (secenek == 2)
            {
                TasitKredisi.Ekle();
            }
            if (secenek == 3)
            {
                ihtiyacKredisi.Ekle();
            }

            if (secenek == 4)
            {
                kredinfo.KrediBilgilendirmeSistemi(krediler);
            }
            if (secenek == 5)
            {
                Users users = new Users();
                users.ID = 1;
                Console.WriteLine("Kredi Başvurucak Kişinin Adı: ");
                users.AD = Console.ReadLine();
                Console.WriteLine("Kredi Başvurucak Kişinin Soyadı: ");
                users.SOYAD = Console.ReadLine();
                Console.WriteLine("Kredi Başvurucak Kişinin TCNO: ");
                users.TCNO = Console.ReadLine();
                Console.WriteLine("Kredi Başvuru Türü \n1)Konut Kredisi  \n2)Taşıt Kredisi \n3)İhtiyaç Kredisi ");
                int sonuc = int.Parse(Console.ReadLine());

                if (sonuc == 1)
                {
                    kredinfo.BasvuruYapiki(KonutKredisi, logServices, users);
                   
                }
                if (sonuc == 2)
                {
                    kredinfo.BasvuruYapiki(TasitKredisi, logServices, users);
                ;
                }
                if (sonuc == 3)
                {
                    kredinfo.BasvuruYapiki(ihtiyacKredisi, logServices, users);
                   
                }
                
            }

            Console.ReadKey();
        }
    }
}
