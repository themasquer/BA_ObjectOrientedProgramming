using System;

namespace _011_InterfaceSegregation.Extras.AracExample
{
    class AracExampleProgram
    {
        public void Run()
        {
            Araba araba = new Araba()
            {
                Marka = "Mini",
                Model = "Cooper S",
                TekerlekSayisi = 4,
                BeygirGucu = 184,
                KasaTipi = KasaTipiEnum.Hatchback,
                YakitTipi = YakitTipiEnum.Elektrik,
                DireksiyonSoldaMi = true,
                MotorHacmi = 1600
            };

            Motorsiklet motorsiklet = new Motorsiklet
            {
                TekerlekSayisi = 2,
                YakitTipi = YakitTipiEnum.Benzin,
                MotorHacmi = 250,
                BeygirGucu = 70,
                Marka = "Yamaha",
                Model = "Racing Z70"
            };

            //IArac kamyon = new Kamyon();
            //kamyon.DireksiyonSoldaMi = true; // DireksiyonSoldaMi özelliğine IArac interface'i içinde olmadığından ulaşılamaz.
            // IArac tipinde bir obje oluşturulduğundan DireksiyonSoldaMi özelliğine ulaşılamaz.

            IArac kamyon = new Kamyon() // Kamyon tipinde bir obje oluşturulduğundan DireksiyonSoldaMi özelliğine ulaşılabilir.
            {
                DireksiyonSoldaMi = true,
                Marka = "Mercedes",
                Model = "Axor",
                BeygirGucu = 200,
                YakitTipi = YakitTipiEnum.Dizel,
                TekerlekSayisi = 6,
                MotorHacmi = 3500
            };

            Console.WriteLine("*** ARABA ***");
            Console.WriteLine(araba.AracBilgileriniGetir("\n"));

            Console.WriteLine("*** MOTORSİKLET ***");
            Console.WriteLine(motorsiklet.AracBilgileriniGetir("\n"));

            Console.WriteLine("*** KAMYON ***");
            Console.WriteLine(kamyon.AracBilgileriniGetir("\n"));
        }
    }
}
