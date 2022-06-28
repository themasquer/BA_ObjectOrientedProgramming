using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_SingletonDesignPattern
{
    class Program
    {
        // Singleton Design Pattern:
        // Bir uygulamanın yaşam döngüsü boyunca bir class'tan sadece tek bir nesne türetilmesini ve bu nesneye global erişimi sağlar
        // Singleton'lar instance oluşturulurken parametre almaz. Çünkü yeni bir singleton'ın farklı parametrelerle oluşturulması tekillik konusunda problem oluşturacaktır

        static void Main(string[] args)
        {
            var singletonInstance = SingletonClass.Instance;
            Console.WriteLine(singletonInstance.IsSingletonInstanceInitialized());
            Console.ReadLine();
        }
    }

    public sealed class SingletonClass // class sealed olmalı: sealed mühürlenmiş demektir ve class'tan inheritance'ı engellemeyi sağlar
    {
        private SingletonClass() // constructor private olmalı
        {

        }
        private static SingletonClass _instance = null; // bu class'ın instance'ı için bu class tipinde private static bir değişken tanımlanmalı
        public static SingletonClass Instance // bu class'ın instance'ına erişebilmek için bu class tipinde public static bir property tanımlanmalı 
        {
            get // get method'u içinde eğer bu class tipindeki instance henüz yoksa yeni bir instance oluşturulup geri dönülmeli. eğer varsa zaten daha önce oluşturulan instance geri dönecektir
            {
                if (_instance == null)
                    _instance = new SingletonClass();
                return _instance; 
            }
        }

        // other fields, properties or methods
        // example:
        public bool IsSingletonInstanceInitialized()
        {
            if (_instance == null)
                return false;
            return true;
        }
    }
}
