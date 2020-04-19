        using System;

namespace KopiCappocino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat Menikmati Kopi Cappocino");


            BubukKopi bubuk = new BubukKopi(100);
            AirPanas air = new AirPanas(1000);
            Susu susu = new Susu(100);
            KopiCappocino yummyCoffe = new KopiCappocino(bubuk, air, susu);

            //1st cup coffe
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            String result = yummyCoffe.makeKopiCappocino();
            Console.WriteLine("result " + result);

            //2nd cup coffe
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeKopiCappocino();
            Console.WriteLine("result " + result);

            //3nd cup coffe
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeKopiCappocino();
            Console.WriteLine("result " + result);

            //4nd cup coffe
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeKopiCappocino();
            Console.WriteLine("result " + result);

            //5nd cup coffe
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeKopiCappocino();
            Console.WriteLine("result " + result);

            //6nd cup coffe
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeKopiCappocino();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummyCoffe.checkAvailability());
        }
    }
}
