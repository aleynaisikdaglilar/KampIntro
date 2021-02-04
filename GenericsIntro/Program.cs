using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Aleyna");

            //Console.WriteLine(isimler.Length);

            isimler.Add("Burak");

            //Console.WriteLine(isimler.Length);
        }
    }
}
