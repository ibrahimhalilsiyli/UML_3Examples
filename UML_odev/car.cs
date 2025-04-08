using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_odev
{
    internal class car
    {
        public class Araba
        {
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Plaka { get; set; }
            public int Yil { get; set; }
            public string YakitTuru { get; set; }
            public int Hiz { get; private set; } = 0;
            public bool CalisiyorMu { get; private set; } = false;

            public void Calistir()
            {
                CalisiyorMu = true;
                Console.WriteLine($"{Marka} {Model} çalıştırıldı.");
            }

            public void Durdur()
            {
                CalisiyorMu = false;
                Hiz = 0;
                Console.WriteLine($"{Marka} {Model} durduruldu.");
            }

            public void Hizlan(int artis)
            {
                if (CalisiyorMu)
                {
                    Hiz += artis;
                    Console.WriteLine($"{Marka} {Model} {artis} km/h hızlandı. Şu anki hız: {Hiz} km/h");
                }
                else
                {
                    Console.WriteLine("Araba çalışmıyor. Hızlanamaz.");
                }
            }
        }

    }
}
