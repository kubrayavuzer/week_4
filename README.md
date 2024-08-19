Bu uygulama, bir teknoloji mağazasında Telefon ve Bilgisayar ürünlerini kaydetmek için kullanılan bir konsol tabanlı programdır. Program, kullanıcıdan girdi alarak Telefon ve Bilgisayar sınıflarına ait nesneler oluşturur ve bu nesnelerin bilgilerini saklar. Aşağıda, uygulamanın nasıl çalıştığını ve kullanılan OOP (Nesne Yönelimli Programlama) prensiplerini açıklayan bir rehber bulunmaktadır.

OOP Prensipleri
Inheritance (Kalıtım):

BaseMakine: Telefon ve Bilgisayar sınıfları için ortak özelliklerin tanımlandığı bir base class'tır.
Telefon ve Bilgisayar sınıfları BaseMakine sınıfından miras alır.
Encapsulation (Kapsülleme):

Bilgisayar sınıfında USB giriş sayısı için geçerli değerler kontrol edilmiştir. Geçerli değerler dışında bir değer girildiğinde, uyarı mesajı verilir ve -1 değeri atanır.
Polymorphism (Çok Biçimlilik):

BilgileriYazdir() metodu BaseMakine sınıfında tanımlanmış ve Telefon ile Bilgisayar sınıflarında ezilmiştir. Her sınıf, kendi özel bilgilerini yazdırır.
Abstraction (Soyutlama):

UrunAdiGetir() adında bir abstract metot BaseMakine sınıfında tanımlanmış ve Telefon ile Bilgisayar sınıflarında ezilmiştir. Bu metot, her sınıfın adını kullanıcıya özgü bir mesajla döndürür.
