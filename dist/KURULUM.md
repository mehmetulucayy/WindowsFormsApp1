# Kütüphane Yönetim Sistemi - Kurulum

## 📦 İçerik
- `WindowsFormsApp1.exe` - Ana uygulama (80 KB)
- `WindowsFormsApp1.exe.config` - Yapılandırma

## 🚀 Hızlı Başlangıç

### 1. Gereksinimler
- Windows 7+
- .NET Framework 4.7.2+ ([İndir](https://dotnet.microsoft.com/download/dotnet-framework/net472))
- SQL Server

### 2. Veritabanı
SQL Server'da `KütüphaneOtomasyonuu` veritabanını oluşturun:

```sql
CREATE TABLE UYE (
    tc VARCHAR(11) PRIMARY KEY,
    adsoyad VARCHAR(100),
    yas INT,
    cinsiyet VARCHAR(10),
    telefon VARCHAR(15),
    adres VARCHAR(200),
    email VARCHAR(100),
    okukitapsayisi INT DEFAULT 0
);

CREATE TABLE Kitap (
    barkodno VARCHAR(50) PRIMARY KEY,
    kitapadi VARCHAR(200),
    yazari VARCHAR(100),
    yayınevi VARCHAR(100),
    sayfasayisi INT,
    turu VARCHAR(50),
    stoksayisi INT,
    rafno VARCHAR(20),
    aciklama VARCHAR(500)
);

CREATE TABLE EmanetKitaplar (
    tc VARCHAR(11),
    adsoyad VARCHAR(100),
    yas INT,
    telefon VARCHAR(15),
    barkodno VARCHAR(50),
    kitapadi VARCHAR(200),
    yazari VARCHAR(100),
    yayinevi VARCHAR(100),
    sayfasayisi INT,
    kitapsayisi INT,
    teslimtarihi DATE,
    iadetarihi DATE
);

CREATE TABLE sepet (
    barkodno VARCHAR(50),
    kitapadi VARCHAR(200),
    yazari VARCHAR(100),
    yayinevi VARCHAR(100),
    sayfasayisi INT,
    kitapsayisi INT,
    teslimtarihi DATE,
    iadetarihi DATE
);
```

### 3. Bağlantı Ayarı
`WindowsFormsApp1.exe.config` dosyasını düzenleyin:

```
Data Source=SIZIN_SERVER;Initial Catalog=KütüphaneOtomasyonuu;Integrated Security=True;
```

### 4. Çalıştır
`WindowsFormsApp1.exe` dosyasına çift tıklayın!

## ⚠️ Sorun Giderme

**SQL Bağlantı Hatası**: SQL Server'ın çalıştığından emin olun  
**.NET Hatası**: .NET Framework 4.7.2 yükleyin  
**Veritabanı Hatası**: Tabloların oluşturulduğunu kontrol edin

## 📞 Destek
GitHub Issues
