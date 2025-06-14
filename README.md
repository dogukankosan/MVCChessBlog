
![indir](https://github.com/user-attachments/assets/4e7e3926-ffcd-46c8-a0b7-22011b1ee25f)

# ♟️ MVCChessBlog

## Genel Bakış

**MVCChessBlog**, ASP.NET MVC mimarisiyle geliştirilmiş bir satranç temalı blog platformudur. Kullanıcıların satrançla ilgili yazılar paylaşabileceği, analizler ve eğitim içerikleri sunabileceği esnek ve modern bir altyapı sağlar.

---

## Özellikler

- Satranç temalı blog altyapısı
- Modern ASP.NET MVC mimarisi
- Çoklu model, kontrolcü ve view desteği
- Kullanıcı yönetimi, blog yazıları, yorumlar ve analizler
- Kapsamlı içerik ve tema dosya sistemi
- Gelişmiş hata sayfaları ve özel fontlar
- Modern uygulama ikonu ![App Icon](https://github.com/dogukankosan/MVCChessBlog/raw/main/favicon.ico)

---

## Teknik Altyapı

| Katman/Yapı        | Açıklama                                       |
|--------------------|------------------------------------------------|
| **Platform**       | ASP.NET MVC                                    |
| **Proje Dosyası**  | `ChessProject.csproj`                          |
| **Çözüm Dosyası**  | `ChessProject.sln`                             |
| **Ana Diziler**    | `Controllers/`, `Models/`, `Views/`            |
| **Statik Dosyalar**| `Content/`, `Scripts/`, `fonts/`, `favicon.ico`|
| **Yapılandırma**   | `Web.config`, `Web.Debug.config`, `Web.Release.config` |
| **Hata Yönetimi**  | `errorpage/`                                   |
| **Kütüphaneler**   | `packages/`, `packages.config`                 |
| **Diğer**          | `App_Start/`, `Global.asax`, `bin/`, `obj/`    |

### Temel Dosya ve Dizinler

```
MVCChessBlog/
│
├── ChessProject.csproj
├── ChessProject.sln
├── Global.asax
├── Global.asax.cs
├── Web.config
├── Web.Debug.config
├── Web.Release.config
├── favicon.ico
├── packages.config
│
├── App_Start/     # Uygulama başlangıç ayarları
├── Content/       # CSS ve medya dosyaları
├── Controllers/   # MVC Controller dosyaları
├── Models/        # Veri modelleri
├── Views/         # Razor view’lar
├── Scripts/       # JS dosyaları
├── Properties/
├── bin/           # Derlenmiş dosyalar
├── obj/           # Geçici derleme dosyaları
├── fonts/         # Özel fontlar
├── errorpage/     # Hata sayfaları
├── packages/      # NuGet paketleri
├── web/           # Web ile ilgili yardımcı dizin
├── weblogin/      # Giriş modülü
```
> Not: Bu liste API kısıtı nedeniyle ilk 10+ dosya/klasör ile sınırlıdır. [Tüm dosya ve klasörleri görmek için tıklayın.](https://github.com/dogukankosan/MVCChessBlog/tree/main)

---

## Kurulum & Kullanım

1. Repoyu indir veya klonla.
2. Visual Studio ile aç.
3. Gerekli NuGet paketlerini yükle (`packages.config`).
4. Projeyi derle ve çalıştır.
5. Satranç blogunu kullanmaya başla!

---

## Katkı Sağlama

Katkıda bulunmak için repoyu forklayabilir ve pull request gönderebilirsin.

---

## Lisans

MIT Lisansı ile sunulmuştur.

---

<p align="center">
  <img src="https://img.shields.io/badge/ASP.NET-MVC-blue?logo=dotnet" alt="ASP.NET MVC" />
  <img src="https://img.shields.io/badge/Chess-Blog-green" alt="Chess Blog" />
</p>
