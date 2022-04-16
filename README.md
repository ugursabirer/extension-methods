# C# Extension Methods
Genişletme metodları bir tip (integer veya string vb.) üzerinde herhangi bir değişiklik yapmadan o tipi kolayca genişletmemize olanak sağlayan bir yapıdır. 
Daha basit olarak anlatacak olursak tanımladığımız bu Genişletme Metodları özünde bildiğimiz static metodlardır. 
.Net Framework 3.5 ile kullanıma gelmişlerdir, .Net Frameworkte içerisinde bulunan ve tanımlamış olduğumuz her tip için uygulanabilmektedir.

**Eğer bir tip için var olan öz metodlar ile aynı isimde extension metod oluşturursanız, derleyici (compiler) metod çağırımında yazmış olduğunuz extension metodu değil öz metodu çalıştıracaktır. 
Extension metodlar sadece aynı isimde öz metod olmadığı zaman çalışırlar.**

*Unutmamak gerekir ki Object tipine tanımladığınız bir extension metod, sadece String, Integer ve List’ler için kısıtlı kalmayıp .Net Framework içerisindeki her tip için geçerli olacaktır.*

## Nasıl Genişleme Metodu Oluşturulur?
Genişletme metodlarını basit bir şekilde tanımlayacak olursak yapmamız gereken adımlar aşağıdaki gibi olacaktır.

1. Public static bir sınıf oluşturulur.
2. Yapmak istediğiniz işlemleri gerçekleştirecek metod yazılır.
3. Fonksiyon genişleme metoduna dönüştürülür.
