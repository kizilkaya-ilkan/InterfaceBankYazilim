﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi
{
    internal class Sms : ILogService
    {
        public void log()
        {
            Console.WriteLine("SMS Gönderimi Başarılı");
        }
    }
}
