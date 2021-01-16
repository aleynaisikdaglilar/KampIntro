﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;
    

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "K";
            kurs2.Egitmen = "Kemal ";
            kurs2.IzlenmeOrani = 74;
           

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "A";
            kurs3.Egitmen = "Ali";
            kurs3.IzlenmeOrani = 80;


            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
