using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes.ZarExample
{
    class ZarManager
    {
        Zar[] _zarlar;
        Random _random = new Random();
        int _zarAdedi;
        int _tekrarSayisi;

        public void ZarlariAt(int zarAdedi = 1)
        {
            _zarAdedi = zarAdedi;
            _tekrarSayisi = 1;
            _zarlar = new Zar[_zarAdedi];
            for (int i = 0; i < _zarlar.Length; i++)
            {
                _zarlar[i] = new Zar();
                _zarlar[i].ZarAt(_random);
            }
        }

        public void ZarlariAt(int tekrarSayisi, int zarAdedi = 1)
        {
            _zarAdedi = zarAdedi;
            _tekrarSayisi = tekrarSayisi;
            int i = 0;
            int toplamZarSayisi = _tekrarSayisi * _zarAdedi;
            _zarlar = new Zar[toplamZarSayisi];
            while (i < toplamZarSayisi)
            {
                _zarlar[i] = new Zar();
                _zarlar[i].ZarAt(_random);
                i++;
            }
        }

        public void ZarlariGoster()
        {
            int zarSirasi = 1;
            if (_tekrarSayisi == 1)
            {
                foreach (var zar in _zarlar)
                {
                    Console.WriteLine((zarSirasi++) + ". Zar: " + zar.ZariSayisiniGetir());
                }
            }
            else
            {
                int i = 0;
                int tekrar = 1;
                do
                {
                    if (zarSirasi > _zarAdedi)
                    {
                        zarSirasi = 1;
                        tekrar++;
                    }
                    Console.WriteLine("Tekrar: " + tekrar + ", " + zarSirasi + ". Zar: " + _zarlar[i].ZariSayisiniGetir());
                    zarSirasi++;
                    i++;
                } while (i < _zarlar.Length);
            }
        }
    }
}
