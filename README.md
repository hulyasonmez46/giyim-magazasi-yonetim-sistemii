Proje Raporu: Giyim Mağazası Yönetim Sistemi

Bu proje, C# dilinde geliştirilen bir giyim mağazası yönetim sistemidir. Proje iki ana bölümden oluşur: Bir kütüphane (mağaza işlevselliklerini içeren sınıflar ve metotlar) ve bu kütüphaneyi kullanan bir konsol uygulaması. Proje, Nesne Yönelimli Programlama (OOP) kavramlarını uygulamalı bir şekilde göstermektedir.

1.	Sınıflar ve Nesneler: Projede Customer, Item, Order ve StoreManager gibi sınıflar oluşturulmuştur. Bu sınıflar, mağaza müşterilerini, ürünleri ve siparişleri temsil eder. Her sınıfın kendi özellikleri ve işlevleri vardır.

2.	Kalıtım (Inheritance): Person sınıfı, Customer sınıfının temelini oluşturur. Bu sayede, müşteri sınıfı temel özellikleri Person sınıfından devralır ve kendi özel işlevlerini ekler.

3.	Polimorfizm (Polymorphism): StoreManager sınıfı, farklı sipariş türlerini aynı yöntemle yönetir. Örneğin, AddItem metodu hem tekil ürünleri hem de siparişleri işleyebilir.

4.	Kapsülleme (Encapsulation): Sınıfların verileri ve metotları özel (private) veya korumalı (protected) erişim belirleyicileri ile gizlenmiştir. Örneğin, Order sınıfının içindeki ürün listesine sadece ilgili metodlar üzerinden erişilebilir.

5.	Soyutlama (Abstraction): Kullanıcılar, sistemin detaylarını bilmeden yüksek seviyeli metotları (örneğin AddItem, PlaceOrder) kullanarak işlemlerini gerçekleştirebilir.

6.	Dinamiklik ve Esneklik: StoreManager sınıfı, ürünler ve siparişler arasındaki ilişkiyi yönetir. Kullanıcılar, ürün ekleme, sipariş oluşturma ve listeleme gibi işlemleri dinamik olarak yapabilir.

Bu proje, kullanıcıların kolayca bir giyim mağazası yönetmesine olanak sağlar. Konsol uygulaması aracılığıyla, ürünlerin eklenmesi, siparişlerin oluşturulması ve müşterilerin yönetimi gibi işlemler gerçekleştirilebilir. Sistem, güçlü bir nesne yönelimli yapıya dayanarak genişletilebilir ve sürdürülebilir bir altyapı sunar.

