## QR Kodlu Sipariş Yönetimi Projesi
QR Kodlu Sipariş Yönetimi Projesi, Asp.Net Core Api ve SignalR kullanılarak müşterilerin restorandaki masa QR kodunu tarayarak sipariş ve diğer işlemleri gerçekleştirmeyi hedefler.

## Özellikler
QR Kod ile Sipariş: Kullanıcılar, restorandaki masaların QR kodunu tarayarak hızlı bir şekilde sipariş verebilirler.

Gerçek Zamanlı Mesajlaşma: Kullanıcılar, restoran ile gerçek zamanlı olarak iletişim kurabilir, özel isteklerini iletebilirler.

Menü Detayları: Kullanıcılar, menü detayları sayfasında yemekler hakkında detaylı bilgilere, fotoğraflara ve içeriklere ulaşabilirler.

Rezervasyon Yönetimi: Kullanıcılar, istedikleri masayı rezerve edebilir ve rezervasyonlarını kolayca yönetebilirler.

Admin Paneli: Admin kullanıcıları, menüleri düzenleyebilir, rezervasyonları onaylayabilir ve site ayarlarını yönetebilirler.

## Nasıl Çalışır?
QR Kod ile Sipariş Verme:

Müşteriler, restorandaki masaların QR kodunu tarayarak mobil cihazları üzerinden hızlıca sipariş verebilirler.
Gerçek Zamanlı İletişim:

Kullanıcılar, SignalR üzerinden restoran ile gerçek zamanlı olarak iletişim kurabilir, özel taleplerini iletebilirler.
Menü Detayları:

Menü detayları sayfasında, kullanıcılar seçtikleri yemekler hakkında detaylı bilgilere, görsellere ve içeriklere ulaşabilirler.
Rezervasyon İşlemleri:

Kullanıcılar, rezervasyon sayfasından istedikleri masayı seçebilir ve rezervasyonlarını yönetebilirler.
Admin Kontrol Paneli:

Admin kullanıcıları, menüleri güncelleyebilir, rezervasyonları onaylayabilir ve site ayarlarını düzenleyebilirler.
Bu proje, modern bir restoran deneyimi sunarak hem müşterilere hem de işletmelere pratik ve etkili bir çözüm sağlamayı amaçlamaktadır. Eğer herhangi bir sorunuz veya geri bildiriminiz varsa, lütfen bize bildirin. İyi kullanımlar! 🍽️✨

## Teknolojiler ve Araçlar

- ASP.NET Core 6.0
- Entity Framework Core
- Fluent Validation
- AutoMapper
- SignalR (Real Time)
- HTML, CSS, Bootstrap
- SQL Server
- RapidAPI ve ApiConsume (API entegrasyonu için kullanıldı)
- N-Tier Architecture

## Kurulum ve Çalıştırma

1. Depoyu bilgisayarınıza klonlayın.
2. SQL Server üzerinde bir veritabanı oluşturun.
3. appsettings.json dosyasında veritabanı bağlantı dizesini güncelleyin.
4. `dotnet ef database update` komutunu çalıştırarak veritabanı tablolarını oluşturun.
5. Projeyi çalıştırın ve web uygulamasını tarayıcınızda görüntüleyin.

## RapidAPI ve ApiConsume, API (Application Programming Interface) hizmetlerini kullanmayı kolaylaştıran araçlardır.

RapidAPI, farklı hizmet sağlayıcıların sunduğu API'leri tek bir yerden erişilebilir hale getiren bir platformdur. Bu platform, geliştiricilere geniş bir API koleksiyonuna erişme imkanı sağlar. RapidAPI üzerinden çeşitli kategorilerdeki API'lere erişebilir, bu API'lerin belgelerini ve kullanım kılavuzlarını inceleyebilir ve projelerinizde bu API'leri kullanabilirsiniz. RapidAPI'nin sunduğu avantajlardan biri, API'lere erişmek ve entegrasyonlarınızı yönetmek için tek bir arayüz sağlamasıdır. Böylece farklı API'ler için ayrı ayrı hesaplar oluşturmanıza gerek kalmaz.

## Proje İçeriği

- Restoran için rezervasyon işlemleri
- Dinamik CRUD işlemleri
- Yönetim Paneli (Admin Paneli)
- Identity Kütüphanesi ile Login Register İşlemleri
- Proje uygulama seviyesinde koruma altına alındı ve Authentication işlemi yapılmadan Admin tarafına erişim yapılamıyor.

## Admin Özellikleri

- Admin Login işlemi ile Kontrol paneline erişebilir
- Kullanıcılardan gelen mesajları görüntüleyebilir.
- Dashboard panelinde bazı dinamik istatistik bilgilerini görebilir.
- Menü, Rezervasyonlar, İndirimler, İletişim, İletişim Bilgileri, Kategoriler ve Referanslar gibi tüm işlemleri panel üzerinden yönetebilirler .
## İlişkisel Veri Tabanı Diagramı
![290985868-966bf337-0476-4f97-af2f-d8c19fe2289b](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/ca89c4af-cfaa-4093-ab87-57e7c062436c)


## UI
![index](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/b53e4f0d-0d09-4fe1-81d7-b66c2ab85929)
![index2](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/87b97f22-9f20-41f4-b434-f7dc3d59b37c)
![menu](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/6f030030-b5b5-4a26-8698-f89d1c29b66e)
![basket](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/25fe85c4-13be-46d8-9653-cb36a9be426b)
![basket2](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/7c013f07-dd3f-4a4f-85a8-ff35ffbfa113)
![contact](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/3df07ee4-4595-444b-b09b-de4c8b506fdd)
![register](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/9a6ec1d5-8472-40a0-9311-6cd37d9d0673)
![login](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/5f0bc478-60a6-42b7-8111-9752667f1699)

## Yönetici Paneli ve API
![API](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/a388f32a-c686-4077-8bdc-c4ffd2091267)
![Kategori](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/9de2aff3-aa80-4e76-bc1d-7a46ff97c0c2)
![Urunler](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/79f0b617-9928-41aa-ab72-ba7635a252d8)
![One Cikanlar](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/1eefa4e8-792d-40b8-83a8-9d092d729c75)
![Istatistikler](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/72693c14-d448-4efd-a386-cd0d4e296397)
![image](https://github.com/Cihanmertpeker/SignalRProject/assets/119748061/bddff38c-38bc-4b41-abb9-9e20e54aa3ce)

