using Core.Entities.Concrete;
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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";

        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürün listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 15 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded = "Kategori limitini aştığınız için eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string UserRegistered = "Kullanıcı kayıt oldu.";
        public static string AccessTokenCreated = "Erişim tokenı oluşturuldu.";
        
    }
}
