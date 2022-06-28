using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Demo2
{
    public interface ICustomerDal // Dal: data access layer. veritabanında crud işlemlerini yani create (insert), read (get), update ve delete işlemlerini data access layer'lar üzerinden yaparız.
                           // interface'i farklı imlementasyonlar için kullanırız. örneğin veritabanımız bir projede SQL Server, diğerinde Oracle olabilir.
                           // bunun için her bir veritabanı için bu interface ayrı ayrı implemente edilmelidir.
                           // kullanılması gereken temel method'ları tanımlıyoruz.
                           // class'larda olduğu gibi interface'lerin default tanımı için de:
                           // C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\ItemTemplates\CSharp\Code\1033\Interface altındaki Interface.cs dosyasını edit'leyip
                           // başına public ekleyebiliriz
    {
        void Add();
        void Update();
        void Delete();
    }
}
