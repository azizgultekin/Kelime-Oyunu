-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: yaz_lab_proje
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `harf_sayisi_10`
--

DROP TABLE IF EXISTS `harf_sayisi_10`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `harf_sayisi_10` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Soru` varchar(300) NOT NULL,
  `Cevap` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `harf_sayisi_10`
--

LOCK TABLES `harf_sayisi_10` WRITE;
/*!40000 ALTER TABLE `harf_sayisi_10` DISABLE KEYS */;
INSERT INTO `harf_sayisi_10` VALUES (1,'“İmece”nin kurumsallaşıp sermayeli ortaklığa dönüşmüş hali','KOOPERATİF'),(2,'“Tüm hava koşullarında, yaz kış kullanılabilen” gereçlere yönelik bir tabir','DÖRTMEVSİM'),(3,'“Kefeni yırtmayı adet haline getirmiş kişiler” için kullanılan bir söz','DOKUZCANLI'),(4,'Psikolojik denge','RUHSAĞLIĞI'),(5,'Esintinin yönünü, bazen de adını gösteren levhalara verilen ad','RÜZGARGÜLÜ'),(6,'Ayakkabı yapan veya satan kimse, başmakçı, pabuççu','AYAKKABICI'),(7,'Karşılığını sonra vermek şartıyla birinden para veya bir şey almak, istikraz etmek','BORÇLANMAK'),(8,'Cephanenin saklanmasına yarar kapalı ve korunmuş yer','CEPHANELİK'),(9,'Yakıldığında dönerek kıvılcım saçan donanma fişeği','ÇARKIFELEK'),(10,'Bir acının etkisiyle veya bir baskıdan kurtulmak için çırpınmak','DEBELENMEK'),(11,'Vücutta damar, doku, kanal veya boşluk içine enjektör aracılığıyla sıvı veya ilaç verme, zerk etme','ENJEKSİYON'),(12,'Başkalarının duyamayacağı kadar alçak sesle konuşmak, fıslamak','FISILDAMAK'),(13,'Vücudun bazı yerlerine dokunarak ürperme veya gülerek kaçınma ile beliren bir sinir tepkisi uyandırmak','GIDIKLAMAK'),(14,'Hareket etmeyen, yerinden kımıldamayan, durgun, durağan','HAREKETSİZ'),(15,'Kurşun kalemlerin ucunu açmak için kullanılan türlü biçimlerdeki keski, kalem açacağı','KALEMTIRAŞ'),(16,'Kaptaki sıvı akarken `lık lık` diye ses çıkarmak','LIKIRDAMAK'),(17,'Fabrika yapımı her türlü kumaş, bez vb. dokuma','MANİFATURA'),(18,'Bir çiftin evlenme işinin kararlaştığına belirti olarak parmaklarına yüzük takmak, yavuklamak','NİŞANLAMAK'),(19,'Türk üniversitelerinde 1960 öncesinde, en az beş yıl profesörlük yapmış, bilimsel çalışmalarıyla kendini tanıtmış öğretim üyeleri arasından seçilerek bir kürsünün yönetimiyle görevlendirilen kimselere verilen unvan','ORDİNARYÜS'),(20,'Bir şeyden, bir yerden veya kimseden ayrılıp uzağa gitmek','UZAKLAŞMAK'),(21,'Bir İslam topluluğu olarak kalmak amacını güdenlerin görüşü','ÜMMETÇİLİK'),(22,'Bir şeyin yapılmasını veya getirilmesini, bu işlerle uğraşan birine söylemek, sipariş etmek','ISMARLAMAK'),(23,'Birkaç öğretim basamağından oluşan örgün eğitim sisteminin temel bilgi ve becerileri kazandıran sekiz yıllık ilk basamağı, ilköğrenim, zorunlu öğrenim','İLKÖĞRETİM'),(24,'Çok şaşırmak, şaşkınlıktan ne yapacağını bilememek','ŞAŞAKALMAK'),(25,'Özellikle veremli hastaların iyileştirilmesi için kurulmuş sağlık kuruluşu','SANATORYUM'),(26,'Neler üzerinde durulacağını hatırlayıp bir araya getirmeye çalışmak','TOPARLAMAK'),(27,'Bir yazı veya konuşmada sürekli olarak öne sürülen, önemle belirtilmek istenen düşünceye dikkati çekmek, belli bir noktayı altını çizerek belirtmek','VURGULAMAK'),(28,'Bir şeyin yapılmamasını buyurmak veya istemek, menetmek','YASAKLAMAK'),(29,'Boş ve anlamsız sözler söylemek, saçmalamak','ZIRVALAMAK'),(30,'Verilen emeğe ve yapılan masrafa oranla üretilen miktar, ürün verme gücü, prodüktivite','ÜRETKENLİK'),(31,'Seçkin, sivrilmiş, önde gelen','KALBURÜSTÜ'),(32,'Örgütleme işleriyle uğraşan kimse','TEŞKİLATÇI'),(33,'Vurucu ağırlığın, mekanik olarak yükselmesi ve düşmesi sonucu dövme işlemi yapan makine','ŞAHMERDAN ');
/*!40000 ALTER TABLE `harf_sayisi_10` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `harf_sayisi_4`
--

DROP TABLE IF EXISTS `harf_sayisi_4`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `harf_sayisi_4` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Soru` varchar(300) NOT NULL,
  `Cevap` varchar(4) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `harf_sayisi_4`
--

LOCK TABLES `harf_sayisi_4` WRITE;
/*!40000 ALTER TABLE `harf_sayisi_4` DISABLE KEYS */;
INSERT INTO `harf_sayisi_4` VALUES (1,'“Ulvi” sözünün Türkçe kökenli eş anlamlısı','YÜCE'),(2,'Ruhi yaşam ve bedenle uyumlu olmayı amaçlayan kültürfizik ve felsefe sistemi','YOGA'),(3,'Çabuk ve kolay kavrayan, zeyrek','ZEKİ'),(4,'Temel niteliği bir olan dil, hayvan veya bitki topluluğu','AİLE'),(5,'“Filiz, sürgün” anlamına gelen bir kadın adı','AJDA'),(6,'Akla ve gerçeğe aykırı','ABES'),(7,'Gelecekteki olayları kaçınılmaz bir biçimde belirleyen ilahi iradenin insan ve toplum için çizdiği yaşayış biçimi, kader, talih','BAHT'),(8,'Güçlü bir kimsenin yasaya veya vicdana aykırı olarak başkasını uğrattığı kötü durum, kıygı, eziyet','CEFA'),(9,'İçinde yük taşınan aracın boş durumdaki ağırlığı','DARA'),(10,'Bir toplumda saygın ve etkin mevkilerde bulunan ve toplumun eğitim, ekonomi, siyaset, askeriye, din, sanat vb. alanlarıyla ilgili etkinliklerin denetimini elinde tutan kişi veya grup','ELİT'),(11,'Bir malı sahibinin izni ve haberi olmadan zorla alma','GASP'),(12,'Aynı ülkede yaşayan, aynı kültür özelliklerine sahip olan, aynı uyruktaki insan topluluğu, folk','HALK'),(13,'Hukuki sonuç doğuracak bir suç işleyen kimse','FAİL'),(14,'Evrenin düzene girmeden önceki biçimden yoksun, uyumsuz ve karışık durumu','KAOS'),(15,'Kirliliği gösteren iz','LEKE'),(16,'Birine, görevi karşılığı olarak veya geçimi için her ay ödenen para','MAAŞ'),(17,'Mutlu olmaktan doğan ve dışa vurulan sevinç, şetaret','NEŞE'),(18,'Balık avlamada kullanılan, ucuna çengelli iğne takılı, çoğunlukla naylon tellerden veya at kuyruğu kılından yapılmış iplik','OLTA'),(19,'Ucundaki lüle içine tütün konulan ve yakılarak dumanı çekilen kısa, çubuk biçimindeki tütün içme aracı','PİPO'),(20,'Boşa çıkarma, rast getirememe','ISKA'),(21,'Borçlunun alacaklıya karşı yapmak veya ödemekle yükümlü bulunduğu bir şeyi adli bir kuruluş aracılığıyla yerine getirme','İCRA'),(22,'Bir mal veya paranın, belirli bir süre içinde emek verilmeksizin sağladığı gelir','RANT'),(23,'Süsü, gösterişi olmayan, yalın, gösterişsiz','SADE'),(24,'Avrupa\'da soylu kimselerin oturduğu, çevresi hendek, sur ve kulelerle çevrili konak','ŞATO'),(25,'Hükümdarların oturduğu büyük, süslü koltuk','TAHT'),(26,'Bir işin yapılması veya bir borcun ödenmesi için tanınan süre, mühlet, mehil','VADE'),(27,'Bir başarı karşılığında verilen armağan, mükâfat','ÖDÜL'),(28,'Yüksek ve alçaktan mermi atabilen kısa namlulu top','OBÜS'),(29,'Fiyatı yüksek olmayan, pahası az, düşük fiyatlı. ','UCUZ'),(30,'Amaç edinilen, ulaşılmak istenen şey, ideal','ÜLKÜ'),(31,'Bir makinenin dönme hareketini öteki parçalara aktaran ve ucuna dişli çarklar, tekerlekler veya pervane bağlanan demir mil','ŞAFT'),(32,'Yarışma, sınav vb. etkinliklerde başarılı, üstün olanları seçmek amacıyla oluşturulmuş geçici kuru','JÜRİ'),(33,'dasda sdadsa','DADA');
/*!40000 ALTER TABLE `harf_sayisi_4` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `harf_sayisi_5`
--

DROP TABLE IF EXISTS `harf_sayisi_5`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `harf_sayisi_5` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Soru` varchar(300) NOT NULL,
  `Cevap` varchar(5) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `harf_sayisi_5`
--

LOCK TABLES `harf_sayisi_5` WRITE;
/*!40000 ALTER TABLE `harf_sayisi_5` DISABLE KEYS */;
INSERT INTO `harf_sayisi_5` VALUES (1,'Haber toplama, yayma ve üyelerine dağıtma işiyle uğraşan kuruluş','AJANS'),(2,'Gelişen teknolojiyle birçok alanda insanın yerini alabileceği düşünülen elektromekanik araç','ROBOT'),(3,'Karanın deniz boyunca uzanan bölümü','SAHİL'),(4,'Kişinin kendine taktığı simgesel isim','RUMUZ'),(5,'Dar alanlarda kendini tekrarlayan gezinti','VOLTA'),(6,'Bir işin yabancısı olan, eli işe alışmamış, bir işi beceremeyen','ACEMİ'),(7,'Birinin beslenme, giyinme vb. gereksinimlerini üstlenme ve sağlama işi','BAKIM'),(8,'Erkeklerin ve kadınların giydiği, genellikle önden düğmeli, kalçayı örten, kollu üst giysisi','CEKET'),(9,'Toprak, metal vb. bir maddeden yapılmış yayvan, çukurca kap','ÇANAK'),(10,'Bir ülkede baskı kurarak, zor kullanarak veya demokratik yollardan yararlanarak hükûmeti istifa ettirme veya rejimi değiştirecek biçimde yönetimi devirme işi','DARBE'),(11,'Vücut kemiklerinin uç uca veya kenar kenara gelip birleştiği yer, mafsal','EKLEM'),(12,'Toplanan süprüntüleri alıp atmak için kullanılan teneke veya plastikten yapılmış kısa saplı bir kürek türü','FARAŞ'),(13,'Bir düzey üstündeki yıkık, çatlak veya aralık, rahne','GEDİK'),(14,'İki ağaç veya direk arasına asılarak kurulan, içine yatılarak sallanılabilen, ağ, bez vb.nden yapılmış yatak, ağ yatak','HAMAK'),(15,'Gemilerde, uçaklarda, uzay gemilerinde küçük bölme','KABİN'),(16,'Bir şeyi yerinden oynatmak, kaldırmak, harekete geçirmek, gevşetmek vb. için kullanılan, kaldıraca benzer araç','LEVYE'),(17,'Herkesçe bilinen ancak dile getirilemeyen','MALUM'),(18,'Belli bir kurallara göre düzenlenmiş, kulağa hoş gelen ses dizisi, haz','NAME'),(19,'İçinde su biriken çukur yer, doğal kuyu','OBRUK'),(20,'Birim kabul edilen herhangi bir şeyin alabildiği kadar ölçü','ÖLÇEK'),(21,'Kendini akıllı ve bilgili sanan, bilgiçlik taslayan (kimse)','UKALA'),(22,'Kiralanan veya satın alınan bir şey için ödenen para','ÜCRET'),(23,'Ağır, korkulu, çok tehlikeli, vahametli','VAHİM'),(24,'Hayvanların su içtikleri taş veya ağaçtan oyma kap','YALAK'),(25,'Çift süren hayvanların koşulduğu demir uçlu tarım aracı','SABAN'),(26,'Acımasız ve haksız davranan, zulmeden','ZALİM'),(27,'Güneş sistemi içinde hareket ederken Dünya atmosferinin üst katmanlarına girip sürtünme sonucu ateş külçesi durumuna dönüşen küçük nesne, ağma','ŞAHAP'),(28,'İnsanlardaki hastalıkları teşhis ve onları ilaçlarla veya bazı araçlarla tedavi eden kimse','TABİP'),(29,'Kötü bir olaydan alınması gereken ders, uyarıcı sonuç','İBRET'),(30,'Kimse bulunmayan veya az kimse bulunan, tenha, yaban','ISSIZ'),(31,'Midenin arkasında, diyaframın altında, sol böbreğin üstünde, yassı, uzunca, akyuvar üreten ve yıpranmış alyuvarları toplayan, damarlı, gevşek bir dokudan oluşmuş organ','DALAK'),(32,'Sağlık kurumları, müzeler vb. yerlerde özel bölümlere girerken ayakkabıya geçirilen ince ve şeffaf kılıf','GALOŞ');
/*!40000 ALTER TABLE `harf_sayisi_5` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `harf_sayisi_6`
--

DROP TABLE IF EXISTS `harf_sayisi_6`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `harf_sayisi_6` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Soru` varchar(300) NOT NULL,
  `Cevap` varchar(6) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `harf_sayisi_6`
--

LOCK TABLES `harf_sayisi_6` WRITE;
/*!40000 ALTER TABLE `harf_sayisi_6` DISABLE KEYS */;
INSERT INTO `harf_sayisi_6` VALUES (1,'Yakınma ve hafifseme yoluyla “Şimdiki devir” anlamında kullanılan sözcük','ZAMANE'),(2,'Argoda, “Aldatarak parasını çekmek”','SAĞMAK'),(3,'“Güncel” anlamına gelen Fransızca kökenli sözcük','AKTÜEL'),(4,'“Eklemek, katmak, ilave etmek” anlamında bir söz','ULAMAK'),(5,'Dikiş nakış işlerinde kullanılan parmak korumalığı','YÜKSÜK'),(6,'Işığı bir yere toplamak, doğrudan doğruya gözlere vurmasını önlemek için kullanılan, kâğıt, kumaş, maden veya renkli camdan yapılmış lamba siperi','ABAJUR'),(7,'Bir şeyin gerçek sebebi gizlenerek ileri sürülen uydurma sebep','BAHANE'),(8,'Tel,ip, at,motosiklet, bisiklet vb. üzerinde dengeye dayanan, tehlikeli,akrobatik, heyecan verici gösteriler yapan kimse, akrobat.','CAMBAZ'),(9,'Bir şeyin kenarından kesilerek veya kırılarak açılan küçük kertik, tırtık','ÇENTİK'),(10,'Bir tarikata girmiş, onun kurallarına ve törelerine bağlı kimse, alperen','DERVİŞ'),(11,'ir kitabın veya derginin kişi, konu, yer adı vb. bakımından içindekileri yer numarasıyla belirten ve eserin arkasında yer alan alfabetik liste','ENDEKS'),(12,'Genel bir olguyu, bir kuralı veya ilkeyi açıklayan simgeler takımı','FORMÜL'),(13,'Tahıl unlarından nişasta çıkarıldıktan sonra geri kalan albüminli madde','GLÜTEN'),(14,'Geçmeye engel olacak biçimde uzunlamasına kazılmış derin çukur','HENDEK'),(15,'Bazı ilaçların, kolay yutulmak üzere içine konulduğu, ilacın yapısını etkilemeyen jelatinden kap','KAPSÜL'),(16,'Deri ve saç bakımında kullanılan alkollü veya alkolsüz, kokulu sıvı','LOSYON'),(17,'Genellikle modaevlerinde giysileri alıcılara gösterme işiyle görevli kimse, model','MANKEN'),(18,'İncelemek veya denemek üzere insan ve hayvan vücudunun, bitkinin veya nesnenin herhangi bir yerinden alınan doku parçası','NUMUNE'),(19,'Hızlı bir trafik akımı sağlamak amacıyla yapılan, çok şeritli, çift yönlü, geniş yol, otoban','OTOBAN'),(20,'ir işin ilerisini kestirme veya bir işin nasıl bir yol alacağını önceden anlayabilme ve ona göre davranma','ÖNGÖRÜ'),(21,'Köyler, şehirler, ülkeler arasında bir yerden bir yere gidiş geliş, münakale, muvasala, temas','ULAŞIM'),(22,'Gerçekleştirilmesi imkânsız tasarı veya düşünce','ÜTOPYA'),(23,'Yer silmekte kullanılan, özel olarak yapılmış bir sopa ve onun ucuna geçirilmiş bezden oluşan temizlik aracı','PASPAS'),(24,'Bir şeyi halka tanıtmak, beğendirmek ve böylelikle sürümünü sağlamak için denenen her türlü yol','REKLAM'),(25,'Çarpma veya vurma sonucunda vücutta hafifçe kazınmış, zedelenmiş, soyulmuş, kanamış yer','SIYRIK'),(26,'Ulaşım yollarının yayalar ve her türlü taşıt tarafından kullanılması, gidiş geliş, seyrüsefer','TRAFİK'),(27,'Bitkisel ve hayvansal ürünlerin üretilmesi, kalite ve verimlerinin yükseltilmesi, uygun koşullarda korunması, işlenip değerlendirilmesi ve pazarlanması','ZİRAAT'),(28,'Bir düşünce veya kararı benimsemeyerek karşı çıkma','İTİRAZ'),(29,'Sıcaklığı çok yüksek veya çok düşük olmayan (yer, iklim), mutedil','ILIMAN'),(30,'İstenilen yere veya aygıta, isteğe göre elektrik akımının geçmesini sağlamak için kullanılan düzen','ŞALTER'),(31,'Sütun başlığının üstüne yatay olarak konan ve kenarlarından biraz dışarı taşan taş blok','ABAKÜS'),(32,'Hukuk ve adalet işlerini gören devlet kuruluşları','ADLİYE');
/*!40000 ALTER TABLE `harf_sayisi_6` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `harf_sayisi_7`
--

DROP TABLE IF EXISTS `harf_sayisi_7`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `harf_sayisi_7` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Soru` varchar(300) NOT NULL,
  `Cevap` varchar(7) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `harf_sayisi_7`
--

LOCK TABLES `harf_sayisi_7` WRITE;
/*!40000 ALTER TABLE `harf_sayisi_7` DISABLE KEYS */;
INSERT INTO `harf_sayisi_7` VALUES (1,'Çok zorluk çekerek sürekli çalışma','DİDİNME'),(2,'Bir yere ağırlanmak üzere çağrılmış kişi','DAVETLİ'),(3,'Yapılması istenmeyen bir davranışı engellemek için söylenen, iki farklı ünlemden oluşan sözcük dizisi','SAKINHA'),(4,'“Birbiri arkasından” anlamında bir söz dizisi','ÜSTÜSTE'),(5,'Duvar veya asma tavan yapımında kullanılan, iki tarafı kağıt kaplı olan levha','ALÇIPAN'),(6,'Bir bütünün önemce ikinci derecede olan ögelerinden her biri, teferruat, tafsilat, detay','AYRINTI'),(7,'Doğal bir süreçte birdenbire oluşan aykırılık, bunluk, buhran, kriz','BUNALTI'),(8,'Ateşli silahlarla atılmak için hazırlanan her türlü patlayıcı madde, mühimmat','CEPHANE'),(9,'Hayatı boyunca birçok sıkıntı ve üzüntü çekmiş (kimse)','ÇİLEKEŞ'),(10,'Herhangi bir sorumluluk yerine getirilmediğinde karşı tarafça el konulacak olan para','DEPOZİT'),(11,'İnsanların yaşayabilmek için üretme, ürettiklerini bölüşme biçimlerinin ve bu faaliyetlerden doğan ilişkilerin bütünü, iktisat','EKONOMİ'),(12,'Giysi, çanta vb. yerlerde kullanılan, karşılıklı dişler ve bunların üzerinde yürüyen kapatıcıdan oluşan düzenek, cırcır, carcur','FERMUAR'),(13,'Bir toplumda, bir toplulukta eskiden kalmış olmaları dolayısıyla saygın tutulup kuşaktan kuşağa iletilen, yaptırım gücü olan kültürel kalıntılar, alışkanlıklar, bilgi, töre ve davranışlar, anane, tradisyon','GELENEK'),(14,'Çalışkan, becerikli, elinden iyi iş gelen','HAMARAT'),(15,'Uygunsuz hareket, çirkin, yakışıksız davranış, suç, kusur, töhmet','KABAHAT'),(16,'Yemek pişirilip satılan yer, aşevi, restoran','LOKANTA'),(17,'Eğlendirici, sevimli, güldürücü, soytarı, hoş (kimse)','MASKARA'),(18,'Attığı kurşun, taş vb. ile hedefi vurmakta ustalık kazanmış olan','NİŞANCI'),(19,'Yapıları veya tren, vapur vb. ulaşım araçlarını aydınlatmak, havalandırmak amacıyla yapılan, çerçeve, cam, panjur, perde gibi eklentilerle daha kullanışlı bir duruma getirilen açıklık','PENCERE'),(20,'Herhangi bir organın durumunu tespit etmek için çekilen film','RÖNTGEN'),(21,'Kesilmiş hayvanın yürek, karaciğer, böbrek, işkembe, beyin, vb. iç organlarıyla baş ve ayakları','SAKATAT'),(22,'Kendi türünde mükemmel olan, üstün ve kalıcı nitelikte eser, başyapıt, başeser','ŞAHESER'),(23,'Bir kimsenin ölümünden sonra yapılmasını istediği şey','VASİYET'),(24,'Elektrik akımının olumsuz etkilerini önlemek için iletkeni kauçuk, lastik, porselen vb. ile kaplama, yalıtma, tecrit, izolasyon','YALITIM'),(25,'Çok sert alümin billurları kapsayan ve aşındırıcı olarak kullanılan doğal kaya','ZIMPARA'),(26,'Umudu olmayan, hiç umudu kalmayan, ümitsiz, nevmit','UMUTSUZ'),(27,'Kendinde bir gevşeklik duyarak bir işi yapmaya isteği olmamak, erinmek','ÜŞENMEK'),(28,'Bozulmuş, eskimiş olan bir şeyi düzeltip işler veya kullanılır duruma sokmak, işe yarar duruma getirmek, tamir etmek','ONARMAK'),(29,'Ölümle sona erme ihtimali olan veya ölümle sona eren','ÖLÜMCÜL'),(30,'İslam inanışına göre kıyamet gününü, boru öttürerek bildirmekle görevli melek','İSRAFİL'),(31,'Bir üniversitenin, öğrenim alanı veya uzmanlık konusu bakımından ayrılmış kollarından her biri','FAKÜLTE'),(32,'Bir halatla makaralardan oluşturulan, ağır cisimleri kaldırmaya, sağa sola döndürmeye yarayan düzenek','PALANGA');
/*!40000 ALTER TABLE `harf_sayisi_7` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `harf_sayisi_8`
--

DROP TABLE IF EXISTS `harf_sayisi_8`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `harf_sayisi_8` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Soru` varchar(300) NOT NULL,
  `Cevap` varchar(8) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `harf_sayisi_8`
--

LOCK TABLES `harf_sayisi_8` WRITE;
/*!40000 ALTER TABLE `harf_sayisi_8` DISABLE KEYS */;
INSERT INTO `harf_sayisi_8` VALUES (1,'“Acınmak, yazıklanmak, teessüf etmek” anlamlarındaki söz','YERİNMEK'),(2,'Alacakların toplanması','TAHSİLAT'),(3,'Kendini tutamayıp çökmek, bayılıp düşmek','YIĞILMAK'),(4,'“Üretim fiyatının altında yapılan satışları” niteleyen söz','ZARARINA'),(5,'“Orkestra için bestelenmiş, birkaç bölümden oluşan uzun müzik eserleriyle ilgili” anlamında bir söz','SENFONİK'),(6,'Bir nesneyi veya durumu olduğundan daha önemli, daha büyük veya daha çok göstermek, mübalağa etmek','ABURTMAK'),(7,'Ateşli silahlarda barut gazının basıncı ile fırlayıp hedefe varıncaya kadar merminin havadaki hareketini inceleyen bilim','BALİSTİK'),(8,'Yeryüzünü fiziksel, ekonomik, beşerî, siyasal yönlerden inceleyen bilim','COĞRAFYA'),(9,'Suç sayılan bir işi veya bu işi yapanı ortaya çıkarmakla görevli kimse, hafiye, polis hafiyesi','DEDEKTİF'),(10,'Davranışlar, düşünceler ve kavramlar arasında yer ve zaman birliğinin etkisiyle kurulan bağlantılar sonucu, bilinç alanına bunlardan birisi girdiğinde ötekini de bilince çekmesi olayı, tedai','ÇAĞRIŞIM'),(11,'Bir insanı, bir eseri, bir konuyu doğru ve yanlış yanlarını bulup göstermek amacıyla inceleme işi, tenkit','ELEŞTİRİ'),(12,'Dönemi, yapıldığı çevre, katılanların sayısı veya niteliği programla belirtilen ve özel önemi olan sanat gösterisi','FESTİVAL'),(13,'İki kişi türlü oyunlarla birbirinin sırtını yere getirmeye çalışmak','GÜREŞMEK'),(14,'Yaşlanmış kimselerin bakımlarının yapıldığı ve barındığı kurum','HUZUREVİ'),(15,'Kâğıt, kumaş vb. nesneleri üst üste kat oluşturacak biçimde bükmek','KATLAMAK'),(16,'Çıkış yeri kolay bulunamayacak kadar karışık koridorları olan yapı','LABİRENT'),(17,'Boyna zincirle takılan, genellikle değerli metalden yapılmış, içine küçük resim gibi şeyler konulan, türlü biçimde süs eşyası','MADALYON'),(18,'Torba biçiminde dikilmiş, yorgana geçirilen kılıf','NEVRESİM'),(19,'Mekanik yollarla hareket ettirilen veya kendi kendini yöneten (alet)','OTOMATİK'),(20,'Herhangi bir kısıtlamaya, zorlamaya bağlı olmaksızın düşünme veya davranma, herhangi bir şarta bağlı olmama durumu, serbestî','ÖZGÜRLÜK'),(21,'Bir ülkenin, bir toplumun, maddi ve manevi varlıklarının, fikir, sanat çalışmalarıyla ilgili niteliklerinin tümü, medeniyet','UYGARLIK'),(22,'Aynı işi yapanların giydikleri, tüzükle belirtilmiş, bir örnek giysi','ÜNİFORMA'),(23,'Deneylerle henüz yeter derecede doğrulanmamış ancak doğrulanacağı umulan teorik düşünce, faraziye, hipotez','VARSAYIM'),(24,'Gerçek değeri ve miktarı değil, ondan az fazla veya eksik bir niceliği gösteren, aşağı yukarı bir değerlendirme yapılarak bulunan, ortalama, takribî','YAKLAŞIK'),(25,'Genellikle pişirilerek yenen bitkiler veya bunların taneleri','ZERZEVAT'),(26,'Karşılıklı ağır sözler söyleyerek yapılan çekişme, atışma, ağız dalaşı, dil dalaşı, dil kavgası, ağız kavgası, münakaşa','TARTIŞMA'),(27,'Girişilecek bir işin hayırlı olup olmadığını rüyadan anlamak için abdest alıp dua okuyarak uyuma','İSTİHARE'),(28,'Suç işleyen çocukları ıslah etmek, eğitmek ve topluma kazandırmak amacıyla açılmış kurum, ıslahhane','ISLAHEVİ'),(29,'Kendine özgü namus kurallarını esas alıp toplum kurallarının dışına çıkarak zorbalık yapan kimse','KABADAYI'),(30,'Çalıştırılan, işletilen, bakılan bir şeyin verdiği sonuç veya bu sonucun niceliği','RANDIMAN'),(31,'Tadını aldığı, hoşlandığı bir şeyi sık sık istemek','DADANMAK'),(32,'`Teşekkür ederim` anlamında kullanılan bir söz.','EYVALLAH');
/*!40000 ALTER TABLE `harf_sayisi_8` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `harf_sayisi_9`
--

DROP TABLE IF EXISTS `harf_sayisi_9`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `harf_sayisi_9` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Soru` varchar(300) NOT NULL,
  `Cevap` varchar(9) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `harf_sayisi_9`
--

LOCK TABLES `harf_sayisi_9` WRITE;
/*!40000 ALTER TABLE `harf_sayisi_9` DISABLE KEYS */;
INSERT INTO `harf_sayisi_9` VALUES (1,'Lükse ve gösterişten uzak, yalın bir bakış açısıyla sürdürülen hayat','SADEYAŞAM'),(2,'“Adını söylemek, sözünü söylemek, anmak” anlamlarında bir tabir','ZİKRETMEK'),(3,'“Bu işle ilgilenmem, buna karışmam” anlamında bir tabir','NEMELAZIM'),(4,'Genellikle ev işlerinde çalışan, işverenlerin isteklerini yerine getiren emekçi','HİZMETKAR'),(5,'Bir cismi bir yöne doğru ansızın, çabucak fırlatmak','ATIVERMEK'),(6,'Hekimlikte damarları daraltma, bronşları açma, kanamaları kesme vb. amaçlarla kullanılan, kan şekerinin yükselmesine yol açan böbrek üstü bezlerinin salgısı','ADRENALİN'),(7,'Gidenlerin dolandırıldığı veya kötü bir durumda bırakıldığı yer','BATAKHANE'),(8,'İyi arkadaşlık eden, saygılı, görgülü, kibar (erkek)','CENTİLMEN'),(9,'Birine karşı gelmek, sert cevap vermek','ÇEMKİRMEK'),(10,'Vücudun belli bölgelerinden hoş olmayan kokuların çıkmaması için sıkılarak kullanılan güzel kokulu madde','DEODORANT'),(11,'Bir malın niteliğini belirtmek, özelliklerini göstermek amacıyla parasız verilen veya gönderilen mal','EŞANTİYON'),(12,'Aklını kaçırmak, delirmek, aklını yitirmek, çıldırmak','FITTIRMAK'),(13,'Karanlık ve ıssız yerlerde, insanın gördüğünü sandığı korkunç hayalet','GULYABANİ'),(14,'Otoritenin en geniş ölçüde en üst mertebede olmak üzere değişik önem sıraları arasında katı ve kesin bir biçimde dağıldığı toplumsal teşkilatlanış biçimi)','HİYERARŞİ'),(15,'Kimyasal tepkimenin olmasını veya hızının değişmesini molekül yapısını değiştirmeden sağlayan, katalitik etkiye yol açan madde','KATALİZÖR'),(16,'Bir bilim kolunun türlü konuları üzerine yazılmış yazı ve eserlerin hepsi','LİTERATÜR'),(17,'Bir gemideki malları göstermek için kaptan tarafından boşaltma işlemlerinin yapılacağı gümrük idaresine verilen liste','MANİFESTO'),(18,'Bir şeye nitelik bakımından üstünlük kazandıran, kaliteli','NİTELİKLİ'),(19,'Asıl görevi ordu komutanlığı olan rütbesi en yüksek general','ORGENERAL'),(20,'Canlı varlıklar, dışarıdan aldıkları besinleri, değişikliğe uğratarak yeni bir birleşimle, organizmanın gereksinim duyduğu maddeler durumuna getirmek, temsil etmek','ÖZÜMLEMEK'),(21,'Gideni esenlik ve sevgi dilekleriyle geçirmek, yolcu etmek, teşyi etmek','UĞURLAMAK'),(22,'İnceliklerine inmeden, özen göstermeden, gelişigüzel, baştan savma yapılan','ÜSTÜNKÖRÜ'),(23,'Büyüklüğü, görünüşü ve güzelliğiyle görenleri etkileyen','İHTİŞAMLI'),(24,'Bir şeyin gerçekleşmesini uzak görmek, olacağına pek inanmamak, istibat etmek','IRAKSAMAK'),(25,'Eskiden beri yapmakta olduğu bir şeyi artık yapmaz olmak','VAZGEÇMEK'),(26,'Birinden ısrarlı bir biçimde, kendine acındıracak sözlerle, saygılı bir biçimde bir şey istemek','YALVARMAK'),(27,'Olması gerekme, olduğundan başka olmama, zorunlu olma','ZARURİLİK'),(28,'Tankları hedef olarak seçen ve onları etkisiz hâle getirmek için kullanılan silah','TANKSAVAR'),(29,'Dostluğu ve bağlılığı içten olan, sadık','SADAKATLİ'),(30,'Yorgan yerine veya yorgan üstünde kullanılan, çoğu yünden dokunmuş kalınca örtü','BATTANİYE'),(31,'Bilinip unutulan bir şeyi akla getirmek, hatırlamak','ANIMSAMAK'),(32,'Bir konuda kendini yoracak kadar çok uğraşmak','YIRTINMAK');
/*!40000 ALTER TABLE `harf_sayisi_9` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `siralama`
--

DROP TABLE IF EXISTS `siralama`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `siralama` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ad_soyad` varchar(100) NOT NULL,
  `puan` int NOT NULL,
  `sure` varchar(45) NOT NULL,
  `oynanilan_zaman` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `siralama`
--

LOCK TABLES `siralama` WRITE;
/*!40000 ALTER TABLE `siralama` DISABLE KEYS */;
INSERT INTO `siralama` VALUES (2,'AZİZ GÜLTEKİN',5200,'01:22','12.04.2021 15:45:48'),(3,'ADS ADA',2700,'02:37','12.04.2021 16:07:08'),(4,'ALİ VAROL',2700,'00:01','13.04.2021 21:49:14'),(5,'ASDFG SDFG',4500,'00:37','13.04.2021 22:05:31'),(6,'ASDDSSADA DSADA',3400,'01:39','13.04.2021 23:07:54'),(7,'DDSADSAD DSAASD',0,'02:48','13.04.2021 23:12:06'),(8,'DFDS FDSFS',4400,'02:26','13.04.2021 23:27:01');
/*!40000 ALTER TABLE `siralama` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-13 23:28:58
