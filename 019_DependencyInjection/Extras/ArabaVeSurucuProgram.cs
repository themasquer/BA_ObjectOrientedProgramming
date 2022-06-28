using System;

namespace _019_DependencyInjection.Extras
{
    class ArabaVeSurucuProgram
    {
        public void Run()
        {
            SurucuBase surucu = new Surucu()
            {
                Isim = "Çağıl Alsaç"
            };
            Araba araba = new Araba(surucu);
            araba.Sur();
        }
    }

    class Araba
    {
        private readonly SurucuBase _surucu;

        public Araba(SurucuBase surucu)
        {
            _surucu = surucu;
        }

        public void Sur()
        {
            Console.WriteLine("Araba " + _surucu.Isim + " tarafından sürülüyor.");
        }
    }

    abstract class SurucuBase
    {
        public string Isim { get; set; }
    }

    class Surucu : SurucuBase
    {

    }
}
