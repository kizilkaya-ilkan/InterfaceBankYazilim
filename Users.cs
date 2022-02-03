using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi
{
    internal class Users : IUsersDb
    {
        public int ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string TCNO { get; set; }

        public void KullaniciBilgileri()
        {
            Console.WriteLine("Kullanicinin ID:{0} , AD:{1} , SOYAD:{2} , TCNO:{3}" , ID,AD,SOYAD,TCNO);
        }
    }
}
