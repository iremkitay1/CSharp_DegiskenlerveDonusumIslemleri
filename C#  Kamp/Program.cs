using System;
// Kullanmadığım kütüphaneleri kaldırdım

namespace _1.video // Projeye verdiğimiz isim
{
    internal class Program // İnternal bir erişim belirleyici, class da sınıf
    {
        static void Main(string[] args) // Komutlarımızı(kodlarımızı) main metodunun içine yazıcaz
        {
            #region Yazdırma Komutları
            //Console.Write("Merhaba Dunya!"); // Write ile yazdığımız ifade satırın sonuna imleç koyar ve sonraki yazılana aynı satırdan devam eder
            //Console.WriteLine("Ben İrem"); // WriteLine ile yazdığımız ifade imleci bir satır aşağı koyar
            //Console.WriteLine("Selam");
            //Console.Read(); // Read yazdıklarımızı konsolda okur

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine(); // Bir satır boşluk
            //Console.WriteLine("*** Çorbalar ***");
            //Console.WriteLine("-------------------");
            //Console.WriteLine("1- Mercimek Çorbası");
            //Console.WriteLine("2- Ezogelin Çorbası");
            //Console.WriteLine("3- Düğün Çorbası");
            //Console.WriteLine();
            //Console.WriteLine("*** Ana Yemekler ***");
            //Console.WriteLine("--------------------");
            //Console.WriteLine("1- İmam Bayıldı");
            //Console.WriteLine("2- Karnıyarık");
            //Console.WriteLine("3- Şakşuka");
            //Console.WriteLine();
            //Console.WriteLine("*** Salatalar ***");
            //Console.WriteLine("--------------------");
            //Console.WriteLine("1- Çoban Salatası");
            //Console.WriteLine("2- Mevsim Salatası");
            //Console.WriteLine();
            //Console.WriteLine("*** Tatlılar ***");
            //Console.WriteLine("--------------------");
            //Console.WriteLine("1- Tiramisu");
            //Console.WriteLine("2- Trileçe");
            //Console.WriteLine("3- Soğuk Baklava");
            //Console.WriteLine();
            //Console.WriteLine("*** İçecekler ***");
            //Console.WriteLine("--------------------");
            //Console.WriteLine("1- Su");
            //Console.WriteLine("2- Ayran");
            //Console.WriteLine("3- Çay");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.Read();
            #endregion

            #region String Değişkenler 

            // string değişkenler
            // Değisken_türü değişken_adı;

            //string name; // Alfabetik türde verilerimizi tutabilmek için kullandığımız değişken türü
            //name = "İrem";
            //Console.Write(name); // name i çift tırnak içine almıyoruz çünkü alırsak ekrana name yazar, bu şekilde ise ekrana name de saklanan ifadeyi yazıcaz

            //string customerName; // İsimlendirme standartlarından Camel Case'i kullanarak isimlendirdik. Customer = Müşteri
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city; // Bu satırda şunu görebiliyoruz, bir satırda aynı türde birden fazla değişken tanımlanabilir. district = ilçe 

            //customerName = "Ali";
            //customerSurname = "KITAY";
            //customerPhone = "+90 555 555 5555";
            //customerEmail = "deneme@gmail.com";
            //district = "Merkez";
            //city = "Bingöl";

            //Console.WriteLine("*** Rezervasyon Kartı ***");
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Mail adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "KAYA";
            //customerPhone = "+90 400 500 4050";
            //customerEmail = "test@gmail.com";
            //district = "Tuşba";
            //city = "Van";

            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Mail adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------");

            #endregion

            #region İnt Değişkenler

            // int değişkenler
            // sayısal türdeki, tamsayı türündeki değişkenlerdir
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300; // Price = Fiyat
            int cokePrice = 35; // coke = kola
            int waterPrice = 10;
            int friesPrice = 50; // fries = kızartma
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*** Restoran Menü ***");
            Console.WriteLine();
            Console.WriteLine("-----> Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("-----> Kola: " + cokePrice + "TL");
            Console.WriteLine("-----> Su: " + waterPrice + "TL");
            Console.WriteLine("-----> Kızartma: " + friesPrice + "TL");
            Console.WriteLine("-----> Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-----> Limonata: " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("------------------------------");
            Console.WriteLine("  Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("  Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("  Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("  Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("  Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("  Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("+_____________________________");

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("  Toplam Tutar: " + totalPrice);

            #endregion

            Console.Read();

            // variable = değişken
            // string, int, char, double, decimal, float, bool, var...
        }
    }
}