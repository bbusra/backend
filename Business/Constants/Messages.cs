using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages //static yazdığımız için her seferinde new'lenmeyecek
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="Sistem bakımda.";
        public static string ProductsListed="Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExist="Bu isimde başka bir ürün var.";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
