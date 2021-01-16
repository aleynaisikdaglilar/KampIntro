using System;

namespace etrade_hmw
{
    class Program
    {
        static void Main(string[] args)
        {

            Etrade etrade1 = new Etrade();
            etrade1.Categori = "Elbise";
            etrade1.Price = 11.99;
            etrade1.Name = "Trendyolmilla";

            Etrade etrade2 = new Etrade();
            etrade2.Categori = "Elbise";
            etrade2.Price = 89.95;
            etrade2.Name = "Armonika";

            Etrade etrade3 = new Etrade();
            etrade3.Categori = "Elbise";
            etrade3.Price = 84.91;
            etrade3.Name = "Janes";

            Etrade[] etrade = new Etrade[] { etrade1, etrade2, etrade3 };

            foreach (var e in etrade)
            {
                Console.WriteLine(e.Name + " " + e.Price + " " + e.Categori);
            }
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < 3; i++)
            {
                //Console.WriteLine(e.Name + " " + e.Price + " " + e.Categori);
                Console.WriteLine(etrade[i].Name + " " + etrade[i].Price + " " + etrade[i].Categori);
            }
            Console.WriteLine("----------------------------------");
            int k = 0;
            while (k<3)
            {
                Console.WriteLine(etrade[k].Name + " " + etrade[k].Price + " " + etrade[k].Categori);
                k++;
            }
        }
    }
    class Etrade
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Categori { get; set; }
    }
}
