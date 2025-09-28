# FinancialCrm
Bu proje, finansal danışmanlar veya küçük ölçekli işletmeler için temel Müşteri İlişkileri Yönetimi (CRM) ve finansal takip işlemlerini masaüstü ortamında verimli bir şekilde yönetmek üzere geliştirilmiş bir kavram kanıtı (PoC) uygulamasıdır.

Bu proje, C# Masaüstü Uygulama Geliştirme, MSSQL Veritabanı Yönetimi ve Entity Framework kullanarak modern veri erişim yöntemlerine olan hakimiyetimi sergilemektedir.

✨ Öne Çıkan Özellikler
Bu Finansal CRM sistemi, kullanıcıların ana finansal verilere hızla erişmesini ve temel muhasebe işlemlerini gerçekleştirmesini sağlar.

Ana Kontrol Paneli (Dashboard): MSSQL veritabanından çekilen kritik finansal verilerin (Güncel Bakiye, Son İşlemler, vb.) görsel olarak sunulduğu ana ekran.

Fatura Yönetimi (Billing Form): Ödeme listesine erişim, yeni ödeme kaydı ekleme, mevcut kayıtları silme ve güncelleme gibi tam CRUD (Create, Read, Update, Delete) operasyonları.

Banka Bakiyeleri Takibi (Banks Screen): Farklı banka hesaplarındaki güncel bakiyeleri tek bir ekranda merkezi olarak görüntüleme yeteneği.

Harcama İzleyici: Son 5 harcamanın/işlemin hızlı bir şekilde listelenmesi, hızlı durum değerlendirmesi sağlar.

Formlar Arası Akış: Kullanıcı dostu bir deneyim için ana formlar arasında sorunsuz geçiş (navigation).

🛠️ Kullanılan Teknolojiler
Bu uygulama, tamamen Microsoft'un kurumsal teknolojileri kullanılarak geliştirilmiştir.

Kategori	Teknoloji	Açıklama
Backend & Frontend	C# (.NET Framework)	İş mantığı katmanı ve Masaüstü GUI (Kullanıcı Arayüzü) geliştirmede kullanılan temel dil ve çatıdır.
Veri Erişim Katmanı	Entity Framework (EF)	MSSQL veritabanı ile etkileşim için kullanılan, nesne-ilişkisel eşleme (ORM) aracıdır. Bu, veri işlemlerini basitleştirir ve performansı optimize eder.
Veritabanı	Microsoft SQL Server (MSSQL)	Tüm müşteri, fatura ve banka verilerinin tutulduğu güvenilir ve ölçeklenebilir veritabanı çözümüdür.

E-Tablolar'a aktar
🚀 Kurulum ve Çalıştırma
Bu projeyi yerel ortamınızda çalışır duruma getirmek için aşağıdaki adımları takip edin:

Gereksinimler
Visual Studio (Tercihen 2019 veya üzeri)

.NET Framework (Projenin gerektirdiği sürüm)

Microsoft SQL Server (Yerel veya uzak bir kurulum)

Adım Adım Kurulum
Depoyu Klonlayın:

Bash

git clone [REPO_URL'İNİZİ BURAYA YAPIŞTIRIN]
Veritabanı Kurulumu:

MSSQL Server'ınızda yeni bir veritabanı oluşturun (Örn: FinancialCRMDb).

Projeyi Visual Studio'da açın.

Veritabanı bağlantı dizesini (App.config dosyasında) kendi MSSQL sunucu ayarlarınıza göre güncelleyin.

Entity Framework Migration komutlarını kullanarak veritabanı tablolarını otomatik olarak oluşturun/güncelleyin.

Projeyi Başlatma:

Visual Studio'da projeyi derleyin ve F5 ile çalıştırın.

📄 Lisans
Bu proje MIT Lisansı ile yayınlanmıştır. Daha fazla detay için LICENSE.txt dosyasına bakınız.
