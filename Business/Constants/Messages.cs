using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime="Sistem bakımda";
        internal static string ProductsListed="Ürünler listelendi";
        public static string CategoriesListed = "Ürünler listelendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string UnitPriceInvalid = "Birim fiyatı geçersiz";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductUpdated = "Ürünler güncellendi";
        internal static string ProductNameAlreadyExists = "Ürün ismi zaten var";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldı.";
    }
}
