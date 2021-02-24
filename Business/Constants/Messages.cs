using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarNameInvalid = "Arabanın ismi geçersiz";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string CarsListed = "Arabalar Listelendi";
        public static string PriceError = "Arabanın fiyatı 0'dan büyük olmalıdır.";
        public static string TimeError = "Araba Henüz Teslim Edilmemiş.";
        public static string CarRented = "Araba Kiralandı";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string AddFailed = "Kullanıcı Gereksinimleri Karşılamıyor.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı Güncellendi.";
    }
}