Mediator Pattern(Mediatr Library) ve CQRS ile WebAPI projesi gerçekleştirildi.
![image](https://user-images.githubusercontent.com/62504339/189774561-384afb3b-113c-430d-9072-2d9e712857d8.png)

# Mediator Design Pattern(Behavioral Design Pattern)

## Behavioral Design Patterns Nedir?
Behavioral Pattern’ler özetle nesneler arasındaki iletişimi tasarımlayan ve böylece iletişimin daha esnek yapılarda yapılmasını sağlayan tasarım kalıplarıdır.

## Mediator Design Pattern Nedir?
Mediator Pattern ile nesnelerin iletişimi ortak bir noktadan sağlanmakta, nesnelerin birbirleriyle doğrudan iletişime girmesi yerine bir aracıyla iletişime girip haberleşmesini tasarımlamaktadır.

## Neden Mediator Pattern?
En basitinden Kule-Uçak haberleşmesini örnek verebiliriz. Aynı havaalanına inmeye ya da kalkışa hazırlanan pilotlar doğrudan birbirleriyle haberleşseydi eğer büyük bir karışıklık ve dolayısıyla kaos olurdu. Bu duruma sebebiyet vermemek adına pilotlar doğrudan birbirleriyle haberleşmek yerine kule ile irtibata geçip verdiği direktif doğrultusunda pilotlar birbirlerinden habersiz şekilde süreç sağlıklı bir şekilde ilerletilebilmekte.

[Dokümanı hazırlanmış projenin branchi](https://github.com/omertayhan/DesignPatterns/tree/newBranch011122)
## Genel Proje Dosya Hiyerarşisi 
 ![solution](https://user-images.githubusercontent.com/62504339/199627437-6fe619e3-643a-49a1-a886-57cf0fbfcb95.png)

## ChatroomMediator Projesi
Bu örneğimizde kullanıcılar konuşma odasında doğrudan birbirleriyle haberleşmek yerine bir aracı görevi gören mediator üzerinden iletişimlerini sağlamaktadır. 

![mediatorconsoleapp](https://user-images.githubusercontent.com/62504339/199627473-8804b859-d17f-46f4-a975-905323045211.png)

#### Program Çıktısı:
 ![consolçıktı](https://user-images.githubusercontent.com/62504339/199627508-1baa1d8e-18bb-4a47-9692-017bb805745e.png)

## MediatrWebApi Projesi

Bu projemizde mediator implementasyonlarımızı daha kolay gerçekleştirebileceğimiz mediatr kütüphanesinden faydalanarak çarpma işlemi yapmamızı sağlayan bir web api projesi gerçekleştirilmiştir.

![web api projesi](https://user-images.githubusercontent.com/62504339/199627602-b88b2516-9782-41d9-9ae5-ce0621211365.png)

Yeni bir .Net Web API projesi oluşturuyoruz.

![mediatr yükleme](https://user-images.githubusercontent.com/62504339/199627631-f7bc93a3-53fb-4bc0-b023-00a6ef426311.png)

Mediatr paketimizi Solutiona sağ tıklayarak Manage Nuget Packages diyerek projemize dahil ediyoruz.

![multiplyhandler](https://user-images.githubusercontent.com/62504339/199627886-60ee5b04-7e27-4b0a-bb8d-ba499aaa4aa1.png)

Handler sınıfı, gelen request’in işlendiği, sonucun döndürüldüğü ve tüm diğer işlemleri içeren kodları içeren sınıftır. Biz çarpma işlemi yapacağımızdan burada çarpma işlemi içeren kod satırı bulunmakta.
 
![controllerwebapi](https://user-images.githubusercontent.com/62504339/199627908-fbdba6eb-0e40-4207-aa3a-924d5a14b019.png)
Controller sınıfımızı mediatR kütüphanemizi ekleyerek gerekli işlemleri sağlıyoruz.
Görüldüğü üzere çarpma işleminin yapıldığı sınıfa doğrudan ulaşmadan mediatr ile tüm işlemi gerçekleştiriyoruz. mediator.Send() ile request nesnesi mediatr’a gönderiliyor ve mediator da ilgili handler’ın çalıştırılmasını sağlıyor. 
#### Program Çıktısı:
![webapiçıktı](https://user-images.githubusercontent.com/62504339/199627928-acf14e16-0cab-479b-9e06-be344e6f95dc.png)

## MediatrCqrsWebApi Projesi 
Mediator Pattern ile CQRS pattern in beraber kullanıldığı ürün ekleme ve listeleme işlemlerinin gerçekleştirildiği bir Web API projesi yapılmıştır.
#### CQRS (Command Query Responsibility Segregation) Nedir?
Komut ve sorgulama işlemlerinin ayrılması prensibini temel alır. Komutları veri üzerinde değişiklik yapan kod blokları(create, update, delete), sorguları ise veriyi okuyan kod blokları olarak düşünebilirsiniz.
#### Artıları ve Eksileri Neler?
- Kompleks ve değişken iş kurallarının, veri yapılarının olduğu projelerde kullanılabilir.Zira bizi karmaşık yapılardan, domain logic işlemlerinden kurtaracaktır.
- Performans ölçümünü ve optimizasyonunu kolaylaştırır.Kod okunabilirliğini, ölçeklenebilirliği artırır.
- Command-Query ayrımı sayesinde daha performanslı sonuçlar elde edilebilir.
- Takım halinde geliştirilen projeler için iş bölümünü kolaylaştırır.
- Sistemin tasarımında davranışlar arasında ayrıma, daha modüler, bakımı daha kolay ve loose couple yapılar kurmanıza yönlendirir.
- Kod yükünü arttırır. Daha fazla satır kod, daha çok sınıf yazılmasına neden olur.
- Modellerin çift olarak tanımlanması, veya dbcontext gibi yapıların birden çok üretilmesi gibi klasik veya aşina olduğumuz duruma pek uygun olmayan kullanımlara neden olabilir.

MediatR ile kullanılacak Handler sınıflarını register etmek için Program.cs sınıfına aşağıdaki kod bloğunu ekliyoruz.Bu sayede “Project.Core” katmanındaki mediatR sınıflarını tek seferde register etmiş oluyoruz.

![program](https://user-images.githubusercontent.com/62504339/199628099-9563154b-08fb-4341-97dd-8c77e066eb37.png)

(MediatrWebApi projesinde farklı bir kullanım var dilediğinizi kullanabilirsiniz.)

![cqrs handler](https://user-images.githubusercontent.com/62504339/199628115-1086f5da-9b05-453f-ad82-e86d5428cdf8.png)

Bütün handler sınıfları, IRequestHandler interface’ini implemente eder.Bu interface’in içerisine, kullanacağı model sınıfını(GetAllProductQuery) ve dönüş tipini(GetProductViewModel) belirtiyoruz.

![controllerwebapi](https://user-images.githubusercontent.com/62504339/199628159-b4ed3c9d-0d2a-43de-939e-74d337606ceb.png)

Controller sınıfımıza gereken implementasyonlarımızı yaptıktan sonra bütün ürünlerimizi görüntüleyebileceğimiz methodumuzu yazıyoruz. Ve çıktımız şu şekilde oluyor.
 
Aynı işlemleri ürün ekleyebileceğimiz bir Command için de gerçekleştirelim.
 ![commandcqrs](https://user-images.githubusercontent.com/62504339/199628190-7c97621a-2744-4a6e-ac84-c25126ca4e79.png)
 ![command cqrs post](https://user-images.githubusercontent.com/62504339/199628223-5204e7e8-1896-4ed5-a2c5-b7b83ae1f060.png)

#### Program Çıktımız şu şekilde oluyor:
 ![çıktı2cqrs](https://user-images.githubusercontent.com/62504339/199628242-f4591f23-2c74-40ff-b299-485844537ba6.png)

#### Proje Dosya Hiyerarşisi

 ![solcqrs](https://user-images.githubusercontent.com/62504339/199628496-d07890cd-06bb-4d4f-83b1-f40d06ecea10.png)
