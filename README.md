# RedisCaching
Docker yardımıyla Asp.Net Core 3.1 üzerinde redis kullanımı

## :one:  Redis nedir?

**Re**mote **Di**ctionary **S**erver (Uzak Sözlük Sunucusu) ifadesinin kısaltması olan Redis; veritabanı, önbellek, ileti aracısı ve kuyruk olarak kullanılabilecek hızlı, açık kaynak, bellek içi anahtar-değer veri deposudur. Proje, Redis’in ilk geliştiricisi olan Salvatore Sanfilippo’nun, İtalya’daki startup şirketinin ölçeklenebilirliğini iyileştirmeye çalışması sırasında başladı. Redis artık bir milisaniyenin altında yanıt süreleriyle gerçek zamanlı Oyun, Reklamcılık Teknolojisi, Finansal Hizmetler, Sağlık Hizmetleri ve IoT uygulamaları için saniyede milyonlarca isteğin işlenmesini sağlıyor. Redis önbelleğe alma, oyun, lider tabloları, oturum yönetimi, gerçek zamanlı analiz, jeo-uzamsal, yolcu taşıma, sohbet/mesajlaşma, medya akışı ve yayımlama/abonelik uygulamaları için popüler bir seçenektir.

## :two: Redis nasıl çalışır?

Verileri disk veya SSD üzerinde depolayan veritabanlarından farklı olarak tüm Redis verileri bellek içinde tutulur. Redis gibi bellek içi veri depoları, disklere erişme gereksinimini ortadan kaldırarak arama süresi nedeniyle gecikme yaşanmasını önler ve verilere mikrosaniye cinsinden ölçülebilecek bir sürede erişebilir. Redis sunduğu çok amaçlı veri yapıları, yüksek erişilebilirlik, jeo-uzamsal, Lua betiği, işlemler, disk üzerinde süreklilik ve küme desteğiyle internet ölçeğinde gerçek zamanlı uygulamalar oluşturmayı kolaylaştırır.

## :three: Redis ile Memcached'in Karşılaştırması

Redis ve MemCached açık kaynak kodlu, bellek içi veri depolarıdır. Redis, geniş bir aralıktaki kullanım örnekleri için etkili olmasını sağlayan zengin bir özellik kümesi sunarken, yüksek performanslı bir dağıtılmış önbellek hizmeti olan Memcached basitliğe yönelik olarak tasarlanmıştır. Bu uygulamalar MySQL, Postgres, Aurora, Oracle, SQL Server ve DynamoDB gibi ilişkisel veya anahtar-değer veritabanlarında performansı iyileştirmek için çalışır. 

## :four: Redis 5.0 sürümündeki yenilikler

Redis 5 ve son olarak Redis 5.0.3, açık kaynak kodlu Redis’in en son GA sürümüdür. İlk sürümü 2009 yılında bir önbellek teknolojisi olarak yayımlanan açık kaynak kodlu Redis, çok yönlü veri yapıları ve bir milisaniyenin altında yanıt süreleri sunan, kullanımı kolay ve hızlı bir bellek içi veri deposuna dönüştü. Redis, çeşitli geliştirmeler ve iyileştirmeler içeren 5.0 sürümüyle önemli bir kilometre taşına ulaştı. Burada en çok dikkat çeken nokta, HyperLogLog’dan beri Redis’teki tamamen yeni ilk veri yapısı olan Akışlar’ın kullanıma sunulması. Bu sürümde ayrıca Sıralanmış Setler için daha fazla komut ve Modül API’leri için yeni özellikler eklendi.

## :five: Redis'in Avantajları

### :large_orange_diamond: Bellek içi veri deposu

Verilerin çoğunu disk veya SSD üzerinde depolayan PostgreSQL, Cassandra, MongoDB ve diğer veritabanlarından farklı olarak tüm Redis verileri sunucunun ana belleğinde tutulur. Çoğu işlem için diskten veri aktarımına ihtiyaç duyan geleneksel disk tabanlı veritabanlarına kıyasla Redis gibi bellek içi veri depoları aynı aktarıma ihtiyaç duymaz. Bu nedenle bu veritabanları daha fazla işlemi ve daha hızlı yanıt sürelerini destekler. Sonuç olarak bir milisaniyeden az ortalama okuma ve yazma operasyonlarına sahip olağanüstü hızlı performans ve saniye başına milyonlarca işlem için destek sunulur.

### :large_orange_diamond: Esnek veri yapıları

Redis, sınırlı veri yapısı sunan basit anahtar-değer veri depolarından farklı olarak uygulamalarınızın ihtiyaçlarına uygun çok çeşitli veri yapılarına sahiptir. Redis veri türleri şunlardır:

- Dizeler – en fazla 512 MB boyutunda metin veya ikili veri
- Listeler – eklendikleri sırada Dize koleksiyonu
- Kümeler – sıralı olmayan dize koleksiyonu; diğer Küme türleriyle kesişim, birleşim ve fark özelliğine sahiptir
- Sıralanmış Kümeler – bir değere göre sıralanmış kümeler
- Karmalar – alan ve değer listesinin depolanması için veri yapısı
- Bit eşlemler – bit düzeyinde işlem sunan veri türü
- HyperLogLogs – bir veri kümesindeki benzersiz öğeleri tahmin eden olasılığa dayalı veri yapısı

### :large_orange_diamond: Basitlik ve kullanım kolaylığı

Redis, uygulamalarınızda veri depolama, erişim ve kullanım amacıyla daha az sayıda kod satırı yazmanızı sağlayarak kodunuzu basitleştirir. Örneğin uygulamanız bir karma eşlemde depolanan verilere sahipse ve bu verileri bir veri deposunda depolamak istiyorsanız Redis karma veri yapısını kullanabilirsiniz. Benzer bir görevin karma veri yapısına sahip olmayan bir veri deposunda gerçekleştirilmesi için verileri bir biçimden başka bir biçime dönüştürmek üzere satırlarca kod yazılması gerekir. Redis, verilerinizi değiştirmek ve onlarla etkileşim kurmak için yerel veri yapılarına ve çeşitli seçeneklere sahiptir. Redis yazılım geliştiricilerinin kullanabileceği yüzün üzerinde açık kaynak istemci vardır. Java, Python, PHP, C, C++, C#, JavaScript, Node.js, Ruby, R ve Go dahil birçok dil desteklenir.

### :large_orange_diamond: Replikasyon ve kalıcılık

Redis, birincil replika mimarisi kullanır ve verilerin birden çok replikasyon sunucusuna çoğaltılabileceği zaman uyumsuz replikasyonu destekler. Bu özellik geliştirilmiş okuma performansı (istekler sunucular arasında bölünebileceğinden) ve birincil sunucuda kesinti olduğunda daha hızlı kurtarma sağlar. Redis, kalıcılık için belirli bir noktaya yedekleme (Redis verileri kümesini diske kopyalama) özelliğini destekler.

### :large_orange_diamond: Yüksek erişilebilirlik ve ölçeklenebilirlik

Redis, tek düğümlü birincil veya kümelenmiş topolojide birincil replika mimarisi kullanır. Bu da tutarlı performans ve güvenilirlik sunan yüksek oranda erişilebilir çözümler oluşturmanızı sağlar. Kümenizin boyutunu ayarlamanız gerektiğinde kullanabileceğiniz birçok ölçek artırma ve azaltma seçeneği vardır. Bu da kümenizin ihtiyaçlarınızla birlikte büyümesini sağlar.

### :large_orange_diamond: Genişletilebilirlik

Redis, aktif bir topluluk tarafından desteklenen açık kaynak projesidir. Redis'in açık standartları temel alması, açık veri biçimlerini desteklemesi ve zengin bir istemci seçeneği yelpazesi sunması sayesinde belirli bir satıcıya veya teknolojiye bağımlı olmazsınız.

## :six: Popüler Redis Kullanım Örnekleri

### :large_orange_diamond:Önbelleğe Alma

Redis; veri erişimi gecikme süresini azaltmak, performansı artırmak ve ilişkisel veya NoSQL veritabanınızın ve uygulamanızın yükünü hafifletmek üzere yüksek oranda erişilebilir bellek içi önbellek uygulaması için harika bir seçenektir. Redis sık istenen öğeleri bir milisaniyenin altındaki yanıt sürelerinde sunabilir ve yüksek maliyetli arka ucu büyütmeden daha yüksek yükler için kolayca ölçeklendirme yapmanızı sağlar. Veritabanı sorgusu sonuçlarını önbelleğe alma, kalıcı oturumu önbelleğe alma, web sayfası önbelleğe alma ve görüntüler, dosyalar ve meta veriler gibi sık kullanılan nesneleri önbelleğe alma, Redis ile gerçekleştirilen popüler önbelleğe alma işlemlerinden bazılarıdır.

### :large_orange_diamond:Sohbet, mesajlaşma ve kuyruklar

Redis desen eşleme ile Pub/Sub desteğinin yanı sıra listeler, sıralanmış kümeler ve karmalar gibi çeşitli veri yapıları sunar. Bu da Redis'in yüksek performanslı [sohbet odalarını](https://aws.amazon.com/blogs/database/how-to-build-a-chat-application-with-amazon-elasticache-for-redis/), gerçek zamanlı yorum akışlarını, sosyal medya akışlarını ve sunucular arası iletişimi desteklemesini sağlar. Redis Liste veri yapısı basit bir kuyruk uygulamanızı kolaylaştırır. Listeler engelleme özelliklerinin yanı sıra atomik operasyonlar sunar ve bu sayede güvenilir mesaj aracısına veya dairesel listeye ihtiyaç duyan çeşitli uygulamalar için uygundur.

### :large_orange_diamond:Oyun puan tabloları

Redis, [gerçek zamanlı puan tablosu](https://aws.amazon.com/elasticache/redis/#Gaming_Leaderboards) oluşturmak isteyen oyun geliştiriciler arasında popüler bir seçenektir. Listeyi kullanıcı puanlarına göre sıralarken öğelerin benzersiz olma durumunu sağlayan Redis Sıralanmış Küme veri yapısını kullanmanız yeterlidir. Gerçek zamanlı sıralı liste oluşturmak, değişen kullanıcı puanını güncellemek kadar kolaydır. Sıralanmış Kümelerde zaman damgalarını puan olarak kullanarak zaman serisi verilerini de işleyebilirsiniz.

### :large_orange_diamond:Oturum deposu

Yüksek erişilebilirlik ve kalıcılık sunan bir bellek içi veri deposu olan Redis, uygulama geliştiriciler arasında internet ölçeğindeki uygulamaların [oturum verilerini](https://aws.amazon.com/blogs/developer/elasticache-as-an-asp-net-session-store/) depolamak ve ölçeklendirmek için popüler seçeneklerden biridir. Redis kullanıcı profilleri, kimlik bilgileri, oturum durumu ve kullanıcıya özgü özelleştirme gibi oturum verilerini yönetmek için gerekli olan bir milisaniyenin altında gecikme süresi, ölçeklendirme ve dayanıklılığı sunar.

### :large_orange_diamond:Zengin medya akışı

Redis, canlı akış kullanım örneklerini desteklemek için hızlı ve bellek içi veri deposu sunar. Redis kullanıcı profilleri ve görüntüleme geçmişleri hakkında meta verileri, milyonlarca kullanıcı için kimlik doğrulaması bilgilerini/belirteçlerini ve CDN'lerin aynı anda milyonlarca mobil ve masaüstü kullanıcısına video akışı yapmasını sağlamak için bildirim dosyalarını depolamak için kullanılabilir.

### :large_orange_diamond:Jeo-uzamsal

Redis, gerçek zamanlı [jeo-uzamsal verileri](https://aws.amazon.com/blogs/database/amazon-elasticache-utilizing-redis-geospatial-capabilities/) uygun ölçekte ve hızda yönetmek için özel olarak oluşturulmuş bellek içi veri yapıları ve operatörler sunar. GEOADD, GEODIST, GEORADIUS ve GEORADIUSBYMEMBER gibi komutlar jeo-uzamsal verilerin gerçek zamanlı olarak depolanmasını, işlenmesini ve analiz edilmesini sağlayarak Redis ile jeo-uzamsal özelliklerin kullanılmasını kolay ve hızlı duruma getirir. Redis'i kullanarak uygulamalarınıza sürüş zamanı, sürüş mesafesi ve ilgi çekici noktalar gibi konum tabanlı özellikler ekleyebilirsiniz.

### :large_orange_diamond:Machine Learning

Modern veri tabanlı uygulamalar miktar, çeşitlilik ve hız açısından uç özelliklerdeki verileri hızlı bir şekilde işlemek ve karar almayı otomatikleştirmek için makine öğrenimine ihtiyaç duyar. Oyunlarda ve finansal hizmetlerde sahtekarlık algılama, reklamcılık teknolojisi alanında gerçek zamanlı teklif verme, arkadaş bulma ve yolculuk paylaşma hizmetlerinde eşleşme yapma gibi kullanım örneklerinde canlı verileri işleme ve milisaniyeler içinde karar alma çok büyük bir öneme sahiptir. Redis, makine öğrenimi modellerini hızlı bir şekilde oluşturmak, eğitmek ve dağıtmak için hızlı bellek içi veri deposu sunar.

### :large_orange_diamond:Gerçek zamanlı analitik

Redis, gerçek zamanlı verileri bir milisaniyenin altında gecikme süresiyle almak, işlemek ve analiz etmek için bellek içi veri deposu olarak Apache Kafka ve Amazon Kinesis gibi akış çözümleriyle birlikte kullanılabilir. Redis sosyal medya analitiği, reklam hedefleme, kişiselleştirme ve IoT gibi [gerçek zamanlı analitik](https://aws.amazon.com/elasticache/redis/#Real-time_Analytics) kullanım örnekleri için ideal bir seçimdir.

## :seven: Redis Dil Desteği

Redis, şunlar dahil olmak üzere önde gelen çoğu [programlama dilini ve protokolü](https://redis.io/clients) destekler:

| Python   | Perl     | C/C#/C++       |
| -------- | -------- | -------------- |
| **Java** | **Go**   | **JavaScript** |
| **PHP**  | **Ruby** | **Node.js**    |

<details>
<summary><b>Kaynaklar</b> :mag: </summary>
<p>

[Kaynak 1](https://aws.amazon.com/tr/redis/) :+1:

<p>bir çok video :eye_speech_bubble: </p>

![YouTube](https://img.shields.io/badge/youtube-%23FF0000.svg?style=for-the-badge&logo=YouTube&logoColor=white)
