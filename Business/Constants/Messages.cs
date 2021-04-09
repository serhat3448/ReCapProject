using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDailyPriceInvalid = "Araç günlük ücreti geçersiz";
        public static string CarDeleted = "Araba silindi";
        public static string CarsListed = "Arabalar Listelendi";
        public static string CarUpdated = "Araba Güncellendi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka adı geçersiz. Lütfen 2 karakterden daha uzun bir isim giriniz.";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string BrandUpdated = "Marka Güncellendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string ColorUpdated = "Renk Güncellendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalInvalid = "Araç kiralama bilgileri geçersiz, lütfen tekrar kontrol ediniz.";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalsListed = "Kiralamalar Listelendi";
        public static string RentalUpdated = "Kiralama Güncellendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string CarImageLimitExceeded = "More than 5 images cannot be added";
        public static string NoCarImages = "The car does NOT have any images";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
