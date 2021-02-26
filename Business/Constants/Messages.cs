using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //constans demek sabit demek o yüzden statik veriyoruz ve new lemiyoruz
    public static class Messages
    {
        public static string Added = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün adı geçersiz.";
        public static string CarDaily = "Günlük fiyat giriniz.";
        public static string Deleted = "Ürün silindi.";
        public static string Updated = "Ürün güncellendi.";
        public static string ProductList = "Ürün listelendi.";
        public static string MaintenanceTime = "Sistem Bakımda";
       
    }
}
