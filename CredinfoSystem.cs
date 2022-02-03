using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi
{
    internal class KredinfoSystem
    {

        public void BasvuruYap(IKrediManager krediTürü , ILogService KayitTürü )
        {
            Console.WriteLine("*****");
            krediTürü.Ekle();
            KayitTürü.log();
        }

        public void BasvuruYapiki(IKrediManager krediTürü, List<ILogService> KayitTürüiki, IUsersDb gelenbilgi )
        {
            Console.WriteLine("*****");
            krediTürü.Ekle();
            foreach (var databasesystem in KayitTürüiki)
            {
                databasesystem.log();
            }
            gelenbilgi.KullaniciBilgileri();
        }

        public void KrediBilgilendirmeSistemi(List<IKrediManager> krediler)
        {
            foreach (var bilgidöndür in krediler)
            {
                Console.WriteLine("****************");
                bilgidöndür.Ekle();
            }
        }
    }
}
