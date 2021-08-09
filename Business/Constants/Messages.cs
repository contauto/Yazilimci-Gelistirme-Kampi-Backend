using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";

        public static string ProductsListed = "Ürünler listelendi.";

        public static string ProductCountOfCategoryError { get; internal set; }
        public static string ProductNameAlreadyExist { get; internal set; }
        public static string CategoryLimitExceeded { get; internal set; }
        public static string AuthorizationDenied { get; internal set; }
    }
}
