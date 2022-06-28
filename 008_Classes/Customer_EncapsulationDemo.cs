using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes
{
    public class Customer_EncapsulationDemo
    {
        #region Encapsulation
        // Encapsulation: bir class'ın field'larına public accessibility modifier'ı ile doğrudan erişmek yerine private ile önce alanları oluşturup
        // daha sonra gerekli set ve get methodları üzerinden bu alanları değiştirmek ve bu alanlara ulaşmak
        // Örneğin cüzdanınızı ortaya bırakıp herkesin alabilmesini mi istersiniz yoksa cüzdanınızı alabilmek için sizden izin istenmesini mi?
        // Diğer bir örnek kredi kartı numarası tutacağız class'ımızda ve biz buna dışarıdan ulaşacağımızda sadece son 4 rakamı görünsün istiyoruz.
        public string kartNo_public; // eğer bu şekilde tanımlarsak yukarıda yapmak istediğimizi başaramayız ve
        // programın her noktasından direkt olarak kart numarasına erişim sağlanabilir ki bu da risk oluşturur
        private string _kartNo; // bu yüzden önce private field'ımızı oluşturuyoruz
        public void SetKartNo(string kartNo) // bu alan için setter methodumuzu yazıyoruz
        {
            _kartNo = kartNo;
        }
        public string GetKartNo() // bu alan için getter methodumuzu yazıyoruz. yukarıda yapmak istediğimiz işlemin algoritmasını yazıyoruz.
                                  // bu şekilde kart numarası programın neresinden çağrılırsa çağrılsın her zaman maskelenmiş şekilde geri dönecektir
                                  // ve _kartNo alanına bu class'tan başka hiç bir yerden erişim sağlanamayacaktır
        {
            string result = "**** **** **** ";
            result += _kartNo.Substring(15);
            return result;
        }

        // Property kullanımları ise:
        private string _kartNo1; // veya string _kartNo;
        public string KartNo1
        {
            get { return "**** **** **** " + _kartNo1.Substring(15); }
            set { _kartNo1 = value; }
        }

        private string _kartNo2;

        public string KartNo2
        {
            get => "**** **** **** " + _kartNo2.Substring(15); // SOLID prensiplerinden Single Responsibility'e uymaz
                                                               // çünkü bu class'ın tek amacı Customer bilgilerini tutmak, bu bilgiler üzerinde değişiklik yapmak değil.
                                                               // Bu değişiklikler başka bir class'ta gerçekleştirilmelidir
            set => _kartNo2 = value;
        }
        #endregion

        #region Encapsulation Demo
        public bool ErkekMi { get; set; }

        private string _adSoyad;
        public string AdSoyad
        {
            get
            {
                if (ErkekMi)
                    return "Bay " + _adSoyad;
                return "Bayan " + _adSoyad;
            }
            set
            {
                _adSoyad = value;
            }
        }
        #endregion
    }
}
