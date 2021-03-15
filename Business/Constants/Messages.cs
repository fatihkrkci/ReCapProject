using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Başarıyla Eklendi!";
        public static string DailyPriceInvalid = "Kiralama Bedeli 0'dan Büyük Olmalı!";
        public static string CarDeleted = "Araç Başarıyla Silindi!";
        public static string CarUpdated = "Araç Başarıyla Güncellendi!";
        public static string MaintenanceTime = "Sistem Şu Anda Bakımda!";
        public static string CarsListed = "Araçlar Listelendi!";

        public static string BrandAdded = "Marka Başarıyla Eklendi!";
        public static string BrandNameInvalid = "Marka İsmi En Az 2 Karakter Olmalı!";
        public static string BrandDeleted = "Marka Başarıyla Silindi!";
        public static string BrandUpdated = "Marka Başarıyla Güncellendi!";
        public static string BrandsListed = "Markalar Başarıyla Listelendi!";
        public static string BrandNameAlreadyExists = "Bu Marka Zaten Mevcut!";

        public static string CategoryAdded = "Kategori Başarıyla Eklendi!";
        public static string CategoryDeleted = "Kategori Başarıyla Silindi!";
        public static string CategoryUpdated = "Kategori Başarıyla Güncellendi!";
        public static string CategoriesListed = "Kategoriler Başarıyla Listelendi!";
        public static string CategoryNameAlreadyExists = "Bu Kategori Zaten Mevcut!";

        public static string ColorAdded = "Renk Başarıyla Eklendi!";
        public static string ColorDeleted = "Renk Başarıyla Silindi!";
        public static string ColorUpdated = "Renk Başarıyla Güncellendi!";
        public static string ColorsListed = "Renkler Başarıyla Listelendi!";

        public static string CustomerAdded = "Müşteri Başarıyla Eklendi!";
        public static string CustomerDeleted = "Müşteri Başarıyla Silindi!";
        public static string CustomerUpdated = "Müşteri Başarıyla Güncellendi!";
        public static string CustomersListed = "Müşteriler Başarıyla Listelendi!";

        public static string RentalAddedSuccess = "Kiralama İşlemi Başarıyla Eklendi!";
        public static string RentalAddedError = "Kiralama İşlemi Başarısız: Araç Kullanımda!";
        public static string RentalDeleted = "Kiralama İşlemi Başarıyla Silindi!";
        public static string RentalUpdated = "Kiralama İşlemi Başarıyla Güncellendi!";
        public static string RentalsListed = "Kiralama İşlemleri Başarıyla Listelendi!";

        public static string UserAdded = "Kullanıcı Başarıyla Eklendi!";
        public static string UserDeleted = "Kullanıcı İşlemi Başarıyla Silindi!";
        public static string UserUpdated = "Kullanıcı İşlemi Başarıyla Güncellendi!";
        public static string UsersListed = "Kullanıcılar Başarıyla Listelendi!";

        public static string CarImageAdded = "Araç Resmi Başarıyla Eklendi!";
        public static string CarImageDeleted = "Araç Resmi Başarıyla Silindi!";
        public static string CarImageUpdated = "Araç Resmi Başarıyla Güncellendi!";
        public static string CarImagesListed = "Araç Resimleri Başarıyla Listelendi!";
        public static string FailAddedImageLimit = "Bir Aracın En Fazla 5 Resmi Olabilir!";
        
        public static string AuthorizationDenied = "Yetkiniz Yok!";
        public static string UserRegistered = "Kayıt Olundu!";
        public static string UserNotFound = "Kullanıcı Bulunamadı!";
        public static string PasswordError = "Şifre Hatalı!";
        public static string SuccessfulLogin = "Başarılı Giriş!";
        public static string UserAlreadyExists = "Kullanıcı Mevcut!";
        public static string AccessTokenCreated = "Token Oluşturuldu!";
    }
}
