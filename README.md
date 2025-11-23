# Kütüphane Yönetim Sistemi

Modern ve profesyonel bir Windows Forms kütüphane yönetim uygulaması.

## 🎨 Özellikler

### Modern UI Tasarımı
- **Profesyonel Renk Paleti**: Koyu mavi header (#2C3E50), mavi butonlar (#3498DB), yeşil/kırmızı aksiyon butonları
- **Segoe UI Font**: Tüm formlarda modern tipografi
- **Modern DataGridView**: Mavi header, 35px satır yüksekliği, düzgün Türkçe kolon başlıkları
- **Flat Butonlar**: BorderSize=0, modern görünüm

### Modüller
1. **Üye Yönetimi**
   - Üye ekleme, listeleme, güncelleme, silme
   - TC kimlik no ile arama
   - Okunan kitap sayısı takibi

2. **Kitap Yönetimi**
   - Kitap ekleme, listeleme, güncelleme, silme
   - Barkod no ile arama
   - Stok takibi

3. **Emanet İşlemleri**
   - Kitap emanet verme (max 3 kitap/üye)
   - Emanet kitap listeleme (tümü/gecikmiş/zamanında)
   - Kitap iade işlemleri

4. **Raporlama**
   - Grafik: Üyelerin okuduğu kitap sayısı
   - Sıralama: En çok/az kitap okuyan üyeler

## 🎯 Modernize Edilen Formlar

### ✅ Tamamlanan (7 Form)
1. **UyeListelefrm** - Üye listeleme ve düzenleme
2. **UyeEklefrm** - Yeni üye ekleme
3. **KitapListelefrm** - Kitap listeleme ve düzenleme
4. **KitapEklefrm** - Yeni kitap ekleme
5. **EmanetKitapListelefrm** - Emanet kitap listeleme
6. **EmanetKitapİadefrm** - Kitap iade işlemleri
7. **Grafikfrm** - İstatistik grafikleri
8. **Sıralamafrm** - Üye sıralaması

### ⚠️ Eski Tasarım
- **EmanetKitapVerfrm** - Emanet kitap verme (karmaşık yapı nedeniyle)

## 🎨 Tasarım Standartları

### Renk Paleti
```
Header:         #2C3E50 (Koyu mavi-gri)
Primary Button: #3498DB (Mavi)
Success Button: #27AE60 (Yeşil)
Danger Button:  #E74C3C (Kırmızı)
Background:     #ECF0F1 (Açık gri)
White Panels:   #FFFFFF
```

### DataGridView
- **Header**: Mavi (#3498DB), Beyaz text, 40px yükseklik, Segoe UI 10pt Bold
- **Satırlar**: Beyaz, 35px yükseklik, Segoe UI 10pt
- **Seçili**: Açık gri (#ECF0F1)
- **Kolon Başlıkları**: Büyük harf, boşluklarla (TC KIMLIK NO, AD SOYAD, vs.)

## 🗄️ Veritabanı

**SQL Server**: `MEHMET\SQLEXPRESS`  
**Veritabanı**: `KütüphaneOtomasyonuu`

### Tablolar
- `UYE` - Üye bilgileri
- `Kitap` - Kitap bilgileri
- `EmanetKitaplar` - Emanet kayıtları
- `sepet` - Geçici emanet sepeti

## 🚀 Kurulum

1. SQL Server'da `KütüphaneOtomasyonuu` veritabanını oluşturun
2. Gerekli tabloları oluşturun
3. `WindowsFormsApp1.sln` dosyasını Visual Studio ile açın
4. Connection string'i kendi SQL Server bilgilerinize göre güncelleyin
5. F5 ile çalıştırın

## 📋 Gereksinimler

- .NET Framework 4.7.2 veya üzeri
- SQL Server (Express veya üzeri)
- Visual Studio 2019 veya üzeri

## 🎯 Kullanım

1. **Giriş**: Kullanıcı adı ve şifre ile giriş yapın
2. **Ana Menü**: İstediğiniz modülü seçin
3. **İşlemler**: Ekleme, listeleme, güncelleme, silme işlemlerini yapın

## 📸 Ekran Görüntüleri

Modern formlar:
- Koyu mavi top panel
- Beyaz form panelleri
- Renkli aksiyon butonları
- Düzgün Türkçe kolon başlıkları

## 🔧 Teknik Detaylar

- **Platform**: Windows Forms (.NET Framework)
- **Dil**: C#
- **Veritabanı**: SQL Server
- **UI Framework**: Windows Forms
- **Font**: Segoe UI

## 📝 Notlar

- Emanet kitap limiti: 3 kitap/üye
- Kolon başlıkları SQL kolon isimlerinden otomatik düzenlenir
- Tüm formlar Segoe UI font kullanır
- DataGridView satır yüksekliği 35px (rahat okuma)

## 👨‍💻 Geliştirici

Mehmet Uluçay

## 📄 Lisans

Bu proje eğitim amaçlıdır.
