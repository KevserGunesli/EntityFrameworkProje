ASP.NET Core 9.0 MVC + Entity Framework Core ile basit öğrenci-ders kayıt uygulaması.
Özellikler: Öğrenci ve ders CRUD, ders kayıt ilişkisi, temel doğrulamalar, Razor View’lar ve Bootstrap 5 arayüzü.
Başlangıç: dotnet restore, ardından dotnet ef database update (ya da hazır DB yoksa migration oluşturmak için dotnet ef migrations add InitialCreate), sonra dotnet run.
Yapı: Controllers (Home, Student), Data (DbContext ve varlıklar), Models (ViewModel/DTO), Views (Razor sayfaları), wwwroot (statik dosyalar).
Yapılandırma: appsettings.json ve appsettings.Development.json içinde bağlantı dizesini güncelle.
Geliştirme: Hot reload için dotnet watch run; yeni tablo/değişiklikler için dotnet ef migrations add <Ad> + dotnet ef database update.
