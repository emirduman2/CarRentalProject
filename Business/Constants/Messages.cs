using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };
        
        
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
        public static string CarNameAlreadyExists = "Böyle bir araba zaten mevcut. Aynı isimde araba eklenemez.";
        public static string ImageLimitExpiredForCar = "Bir arabaya maximum 5 fotoğraf eklenebilir";
        public static string InvalidImageExtension = "Geçersiz dosya uzantısı, fotoğraf için kabul edilen uzantılar" + string.Join(",", ValidImageFileTypes);
        public static string CarImageMustBeExists = "Böyle bi resim bulunamadı";
        public static string CarHaveNoImage = "Arabaya ait bi resim yok";
    }
}