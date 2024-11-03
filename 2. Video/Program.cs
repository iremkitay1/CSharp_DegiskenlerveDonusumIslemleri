using System;
using System.Globalization;

namespace _2.video
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            #region Double Değişkenler

            ////double number;
            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("****************************  ALIŞVERİŞ  FİYAT  LİSTESİ  ****************************");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("  -----> Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("  -----> Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("  -----> Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("  -----> Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("  -----> Domates Birim Fiyatı: " + tomatoPrice + "TL");
            //Console.WriteLine();

            //Console.WriteLine("*************************************************************************************");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("---------------------------------- Alınan  Ürünler ----------------------------------");

            //Console.WriteLine("   Elma -> " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("   Portakal -> " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("   Çilek -> " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("   Patates -> " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("   Domates -> " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("+____________________________________________________________________________________");
            //Console.WriteLine("   Alışveriş Toplam Tutar: " + shoppingTotalPrice + "TL");

            #endregion

            #region Char Değişkenler

            //// ABCDEFGH
            //// Sezar Şifreleme: Her bir karakter yerine ondan 3 sonraki kaarakteri yazar örenğin A yerine D, B yerine E, C yerine F gibi (DEF)
            //// Örneğin; Toplantı saat 20:00'de    dediğimizde bunu şifreli bir şekilde göndermek istersek her bir karaktere tek tek erişmemiz gerekir ve burada devreye char değişkenler giriyor.
            //// Normal string değişkenler " kullanılaark tanımlanırken, char değişkenler ' ile tanımlanır.

            //char symbol;
            //symbol = 'a';
            //// symbol = "a"; // Yaparsak hata verir çünkü char olaarak tanımlama yaptığımızda ' kullanırız.

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Yolcu: " + passengerIdentityNumber + " " + passengerName + " " + passengerSurname + " " + passengerAge + " " 
            //    + passengerDistrict + "/" + passengerCity);

            #endregion

            #region Klavyeden Tamsayı Girişleri ve Dönüşümler

            //// Örneğin; Aldığınız uçak biletinin rezervasyon kodu ABC12D burdaki 1 ve 2 yi program sayı olark algılamıyor bir karakter olarak okuyor. Bu şekilde kullanacaksak bir sıkıntı olmaz
            //// Ama kaç kişilik uçak bileti almak istediğimiz vs. gibi ifadelerde string kullanmak doğru olmaz bu tür anlarda yapmamız gereken şey sayı dönüşümleridir.
            //// Şimdi bir e-ticaret için basit bir satış paneli oluşturmayı deneyelim

            //// Önce birkaç ürün fiyatı belirleyelim
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //// Şimdi ürünlerden kaçar adet alındığını belirleyelim
            //int shoeCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("Lütfen aldığınız ayakkabı adedini giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Lütfen aldığınız bilgisayar adedini giriniz: ");
            //computerCount = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız sandalye adedini giriniz: ");
            //chairCount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız televizyon adedini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 +  exam2 + exam3) / 3;
            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet (E/K): " + gender);

            #endregion

            Console.Read();
        }
    }
}