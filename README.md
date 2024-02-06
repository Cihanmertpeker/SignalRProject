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

![alt text](290985868-966bf337-0476-4f97-af2f-d8c19fe2289b.png)

## UI

![alt text](index.jpg)
![alt text](index2.jpg)
![alt text](menu.jpg)
![alt text](basket.jpg)
![alt text](basket2.jpg)
![alt text](contact.jpg)
![alt text](login.jpg) 
![alt text](register.jpg)

## Yönetici Paneli ve API
![api](image.png)
![Kategori](image-1.png)
![Ürünler](image-2.png)
![Öne Çıkanlar](image-3.png)
![Anlık istatistik sayfası](image-4.png)
![QR](image-5.png)






