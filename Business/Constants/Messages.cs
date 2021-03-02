using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductUpdated = "Ürünler güncellendi";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten var";
        public static string CategoriesListed = "Ürünler listelendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string UnitPriceInvalid = "Birim fiyatı geçersiz";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı.";
        public static string CategoriesAdded = "Kategori eklendi";
        public static string CategoriesDeleted = "Kategori silindi";
        public static string CategoriesUpdated = "Kategori güncellendi";
        public static string MaintenanceTime="Sistem bakımda";
        public static string CustomersAdded = "Müşteri eklendi";
        public static string CustomersDeleted = "Müşteri silindi";
        public static string CustomersUpdated = "Müşteri güncellendi";
        public static string OrderAdded = "Sipariş eklendi";
        public static string OrderDeleted = "Sipariş silindi";
        public static string OrderUpdated = "Sipariş güncellendi";
        public static string OrdersListed = "Siparişler listelendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
