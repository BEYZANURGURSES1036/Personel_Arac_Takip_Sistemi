# Personel-Araç-Takip-Sistemi
*Devlet Su İşleri Genel Müdürlüğü Teknoloji Daire Başkanlığındaki Staj Projem*

## Projenin Amacı
*Şirkette çalışan personellerin araç talebinde bulunup bulunmadığını takip etmek için kullanılan bir web uygulamasıdır.* 

## Projede Kullanılan Programlama Dili
 *- C#*
 *- ASP.NET*
 
## Projede Kullanılan  Veri Tabanı Sistemi
 *- MySQL*

## Proje Nasıl Kullanılır ?
  *- **Database** kısmındaki .sql isimli dosya indirilir. **MySQL Workbench** adlı uygulama da import işlemi gerçekleştirilir.*
  *- **ASP.NET** kısmındaki .aspx uzantılı dosyalar indirilir.*
  *- **C#** kısmındaki .cs uzantılı dosyalar indirilir.*
  *-**Application_Images** kısmındaki resimler indirilir.* 
 *İndirilen ASP.NET ,C# ,Application_Images kısımları bir klasörde birleştirilir. **Microsoft Visual Studio** adlı uygulamada MySQL Workbench ile veri tabanı bağlantısı* *yapılır. Daha sonra uygulama kullanılabilir hale gelmektedir.*

## Nasıl Çalışır ?
*Uygulamanın giriş ekranı mevcuttur bu ekrandan personeller, birim amirleri ve şoförler giriş yapabilir.(Kullanıcı adı ve şifre=1234 girip uygulamaya giriş yapılabilir.)*
*![](/images/giris.png)*
*Giren kişinin personel mi birim amir mi şofor mü oldukları veri tabanından kontrolu sağlanır.* 
 *- Giren personel ise personel ekranı gelmektedir. Personel ekranından personelin adı-soyadı ve unvanı otomatik olarak ekrana gelir, diğer boşluklarda ise personel gitmek* *istediği yeri ve gideceği zamanı girerek araç talebinde bulunabilir.* 
*![](/images/aractalebi.png)*
*Araç talebinde bulunduktan sayfanın alt kısmına doğru ilerdiğinde araç talebinde bulunduğu yerler için birim amirinin onayından geçtiğini veya şoförün onayının beklenip* *beklenmediği konusunda bilgi edinebilmektedir.*
*![](/images/talepsonuc.png)*
*Bunları kontrol ettikten sonra sistemden çıkış yapabilir.*
   *- Giren birim amir ise kendi himayesinde bulunan personellerinin araç isteğini uygun gördüğü zaman onay verebilir.*
*![](/images/birimamir.png)*
*Onay  verdikten sonra sayfa yenilenir ve onay vermedikleri sayfada yer alır.Daha sonra sistemden çıkış yapabilir.*
*![](/images/birimamir1.png)*
   *- Giren şoför ise personellerin araç taleplerine  birim amirin onay verdikleri sayfada yer alır. Şoför bunlara uygun araç yönlendirmek için araç seçme butonuna basmaktadır.*
*![](/images/sofor.png)*
*Araç seçme sayfasına gittiğinde şoför ve araç seçimi yapar. Seçilen aracın hangi kuruluşa ait olduğu veri tabanından otomatik olarak çekilmektedir. Onayla işlemini* *gerçekleştirdikten sonra diğer personellerin araç taleplerine bakmak için kendi sayfasına yönlendirilir. Yapacağı işlemleri tamamladıktan sonra çıkış yapabilir.*
*![](/images/arac.png)*

## Projeyi Yapan
>***[Beyzanur GÜRSES](https://github.com/BEYZANURGURSES1036)***
