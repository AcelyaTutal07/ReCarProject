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
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı Kayıt Başarılı!";
        public static string UserNotFound = "Kullanıcı Bulunamadı!";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";

        //carImage

        public static string AddCarImageMessage = "Araç resmi başarıyla eklendi";
        public static string EditCarImageMessage = "Araç resmi başarıyla güncellendi";
        public static string DeleteCarImageMessage = "Araç resmi başarıyla silindi";
        public static string AboveImageAddingLimit = "Araç maksimum resim sayısına ulaştı. Resim ekleyemezsiniz";
        public static string IncorrectFileExtension = "Kabul edilmeyen dosya uzantısı";
        

        //User
        public static string AddUserMessage = "Üye başarıyla eklendi.";
        public static string DeleteUserMessage = "Üye başarıyla silindi.";
        public static string EditUserMessage = "Üye başarıyla güncellendi.";
        public static string GetSuccessUserMessage = "Üye bilgisi / bilgileri getirildi.";
        public static string GetErrorUserMessage = "Üye bilgisi / bilgileri getirilemedi.";

    }
}
