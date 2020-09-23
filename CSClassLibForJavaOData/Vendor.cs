using System;
using System.Collections.Generic;
using System.Text;

namespace CSClassLibForJavaOData
{
    public class Vendor
    {
        public int Id { get; set; }

        public string Nev { get; set; }
        public string Kategoria { get; set; }
        public string SzekhelyOrszag { get; set; }
        public string SzekhelyRegio { get; set; }
        public string SzekhelyVaros { get; set; }
        public string SzekhelyCim { get; set; }
        public string SzolgaltatasiTerulet { get; set; }
        public string Telefon { get; set; }
        public string WhatsApp { get; set; }
        public string Email { get; set; }
        public DateTime SzerzodesKezdeteTelefon { get; set; }
        public DateTime SzerzodesVegeTelefon { get; set; }
        public long TeljesitettSzerzodesekSzama { get; set; }
        public long AktivSzerzodesekSzama { get; set; }
        public double OsszesSzerzodesErteke { get; set; }
        public double TeljesitettSzerzodesErteke { get; set; }
        public double AktivSzerzodesErteke { get; set; }
        public double FizetettJutalek { get; set; }
        public double RendezetlenJutalek { get; set; }
        public bool EloSzerzodes { get; set; }

    }
}
