Singleton Design Pattern , Creational Design Pattern grubunda yer alır.

Singleton design pattern çalışma zamanında yalnızca 1 object yaratılmasını garanti eden tasarım desenidir.

Kullanımına ihtiyaç duyulan durum şudur :

- Birden çok sınıfın aynı instance’ı kullanması gerekmektedir.
- Tüm uygulama için yalnızca bir nesne olması gerekmektedir.
- Sadece bir nesne olduğu (unique) garanti edilmelidir.
Bu gereklilikler için bir sınıf yaratırız ve sınıfın kendi instance’ını yönetmesini sağlarız.

Before Develop:

![singleton1](https://user-images.githubusercontent.com/62504339/224274020-20f68b5c-05c3-4273-9f3d-efa27cd25c25.png)

After Develop:

![singleton2](https://user-images.githubusercontent.com/62504339/224274027-879e58b0-db30-4583-91f1-7732c827a554.png)
