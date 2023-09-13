namespace _1denFazlaTurHesaplayanAdimOlcer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Giris();
            Console.WriteLine();
            int[] kosuSonuclari = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(i + 1 + ". tur için bilgileri giriniz : ");

                int adimBoyu = AdimBoyuSor();

                int adimSayi = AdimSayisiSor();

                int saat = KosuSuresiSaatGir();

                int dakika = KosuSuresiDakikaGir();


                Console.WriteLine();
                Console.WriteLine("Koşu özeti : " + MesafeHesapla(adimBoyu, adimSayi, saat, dakika) + " " + "metredir.");

                kosuSonuclari[i] = MesafeHesapla(adimBoyu, adimSayi, saat, dakika);
            }
            Console.WriteLine();
            Array.Sort(kosuSonuclari);
            Array.Reverse(kosuSonuclari);

            Console.WriteLine("Koşu sıralamanız aşağıdaki gibidir");

            foreach (int item in kosuSonuclari)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine();
            Console.WriteLine("Görüşmek üzere, iyi günler...");



        }






        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*METOTLAR*/


        /// <summary>
        /// Uygulama hakkında bilgi veren giriş metodu 
        /// </summary>
        private static void Giris()
        {
            string msg = "Merhaba, bu program günlük koşu/yürüyüş mesafenizi bulmak için geliştirilmiştir. \n" +
                         "Programın yönlendirmesine göre lütfen sizden istediği bilgileri giriniz.";
            Console.WriteLine(msg);

        }




        /// <summary>
        /// Kullanıcının console dan giriş yaptığı değerin bir sayı olup olamadığını kontrol eden, eğer sayı ise true değeri döndüren ve sayıya mevcut değeri atayan, sayı değilse false değeri döndüren ve kullanıcıya uyarı veren metottur.
        /// </summary>
        /// <param name="strSayı"></param>
        /// <param name="sayı"></param>
        /// <returns></returns>


        private static bool BuBirSayiMi(string strSayi, out int sayi)
        {
            sayi = 0;

            bool sayiMi = int.TryParse(strSayi, out sayi);

            if (!sayiMi)
            {
                Console.WriteLine("Hatalı değer girişi yaptınız!");
            }
            return sayiMi;
        }



        /// <summary>
        /// Kullanıcıya adım boyunu soran metottur.
        /// </summary>
        /// <param name="adimBoyu"></param>
        /// <returns></returns>
        public static int AdimBoyuSor()
        {
            Console.WriteLine();
            int adimMesafesi = 0;
            bool sayiMi;

            try
            {
                do
                {
                    Console.Write("Lütfen adım boyunuzu santimetre(cm) olarak giriniz : ");
                    string stradimMesafesi = Console.ReadLine().Trim();
                    sayiMi = BuBirSayiMi(stradimMesafesi, out adimMesafesi);

                } while (!sayiMi);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return adimMesafesi;

        }



        /// <summary>
        /// Kullanıcıya adım sayısını soran metottur.
        /// </summary>
        /// <param name="adimSayisi"></param>
        /// <returns></returns>
        public static int AdimSayisiSor()
        {
            Console.WriteLine();
            int adimMiktari = 0;
            bool sayiMi;

            try
            {
                do
                {
                    Console.Write("Lütfen dakikadaki adım sayınızı giriniz : ");
                    string stradimMiktari = Console.ReadLine().Trim();
                    sayiMi = BuBirSayiMi(stradimMiktari, out adimMiktari);


                } while (!sayiMi);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return adimMiktari;

        }




        /// <summary>
        /// Kullanıcıya koştuğu saati soran metottur.
        /// </summary>
        /// <param name="kosuSuresiSaat"></param>
        /// <returns></returns>
        public static int KosuSuresiSaatGir()
        {
            {
                Console.WriteLine();
                int sureSaat = 0;
                bool sayiMi;

                try
                {
                    do
                    {
                        Console.Write("Lütfen koşu saatinizi giriniz : ");
                        string strsureSaat = Console.ReadLine().Trim();
                        sayiMi = BuBirSayiMi(strsureSaat, out sureSaat);

                    } while (!sayiMi);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                return sureSaat;

            }


        }




        /// <summary>
        /// Kullanıcıya koştuğu dakikayı soran metottur.
        /// </summary>
        /// <param name="kosuSuresiSaat"></param>
        /// <returns></returns>
        public static int KosuSuresiDakikaGir()
        {
            {
                Console.WriteLine();
                int sureDakika = 0;
                bool sayiMi;

                try
                {
                    do
                    {
                        Console.Write("Lütfen koşu dakikanızı giriniz : ");
                        string strsureDakika = Console.ReadLine().Trim();
                        sayiMi = BuBirSayiMi(strsureDakika, out sureDakika);

                    } while (!sayiMi);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                return sureDakika;

            }

        }




        /// <summary>
        /// Girilen bilgilere göre mesafeyi hesaplayan metottur.
        /// </summary>
        /// <param name="adimBoyu"></param>
        /// <param name="adimSayi"></param>
        /// <param name="saat"></param>
        /// <param name="dakika"></param>
        /// <returns></returns>
        public static int MesafeHesapla(int adimBoyu, int adimSayi, int saat, int dakika)
        {
            return (((adimBoyu * adimSayi / 100) * 60 * saat) + ((adimBoyu * adimSayi / 100) * dakika));
        }



        /// <summary>
        /// Kullanıcıya devam etmek için soru soran metottur.
        /// </summary>
        /// <param name="soru"></param>
        /// <returns></returns>
        private static bool DevamEdilecekMiSor(string soru)
        {
            Console.WriteLine();
            Console.Write(soru);
            string cevap = Console.ReadLine().Trim();
            return cevap == "1";
        }
    }
}