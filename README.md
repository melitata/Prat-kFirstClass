Açıklama
Bu C# programı, Ad (isim), Soyad (soyisim) ve DgmTarihi (doğum tarihi) gibi özelliklere sahip bireyleri temsil etmek için bir Person (Kişi) sınıfı tanımlar. Program, Person sınıfının birkaç örneğini oluşturur ve bu bireylerin bilgilerini formatlı bir şekilde ekrana yazdırır.

Özellikler
Kapsülleme: Person sınıfı, veriyi kapsüllemek için özel alanlar ve genel özellikler kullanır.
Tarih İşleme: DgmTarihi özelliği DateTime türündedir ve bu sayede tarih işlemleri ve formatlamaları yapılabilir.
Konsol Çıktısı: Program, birden fazla Person örneğinin bilgilerini yazdırır.
Kod Yapısı
Person Sınıfı
Alanlar:

private string ad: Kişinin ismini saklar.
private string soyad: Kişinin soyadını saklar.
private DateTime dgmTarihi: Kişinin doğum tarihini saklar.
Özellikler:

public string Ad: ad alanı için getter ve setter.
public string Soyad: soyad alanı için getter ve setter.
public DateTime DgmTarihi: dgmTarihi alanı için getter ve setter.
Main Metodu
Main metodu, farklı Ad, Soyad ve DgmTarihi değerlerine sahip beş adet Person örneği oluşturur ve ardından bu bilgileri konsola yazdırır.
