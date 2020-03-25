using System;

namespace CoronaBilgiYarismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************************
            ** SAKARYA ÜNİVERSİTESİ
            ** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
            ** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
            ** NESNEYE DAYALI PROGRAMLAMA DERSİ
            ** 2019-2020 BAHAR DÖNEMİ
            **
            ** ÖDEV NUMARASI..........: 1
            ** ÖĞRENCİ ADI............: Umut Özgenç 
            ** ÖĞRENCİ NUMARASI.......: b191200039
            ** DERSİN ALINDIĞI GRUP...:
            ****************************************************************************/

            /*Günümüzde ki asıl sorun tüm dünyayı etkisi altına alan coronavirus olduğu için insanları
             hem eğlendirip hemde bilinçlendirmek adına bir bilgi yarışması düzenlemek istedim
             umarım beğenirsiniz*/

            Console.Title = ("Coronavirus Bilgi Yarışması");
            Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bilgi Yarışmasına Hoşgeldiniz");

            string ad, soyad , meslek;
            int yas;
            Console.WriteLine("Adınızı Giriniz");
            ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soyadınızı Giriniz");
            soyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Mesleğinizi Giriniz");
            meslek = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Yaşınızı Giriniz");
            yas = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Bilgi Yarışmasına Hoşgeldiniz");
            Console.WriteLine("Adınız |{0,5}| Soyadınız |{1,5}| Mesleğiniz |{2,5}| Yaşınız |{3,5}|", ad, soyad, meslek, yas);
            Console.WriteLine("Doğru Bildiğiniz Her Soru Başına 1000 Puan Kazanacaksınız ve Yanlış Bildiğiniz Her Soru Başına 500 Puan Kaybedeceksiniz");
            Console.WriteLine("Lütfen Cevaplarınızı Verirken Caps Lock Tuşunu Açmayı Unutmayınız");
            Console.WriteLine("Başlamak için her hangi bir tuşa basınız");

            Console.ReadKey();

            int dogru, yanlis, puan;
            dogru = 0;
            yanlis = 0;
            puan = 0;

            string soru1;
            Console.WriteLine("Soru 1 - Ülkemizdeki ilk  açıklanan coronavirus vakası hangi tarihte olmuştur?");
            soru1 = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("A) 8 Mart B) 9 Mart C) 11 Mart D) 13 Mart");
            string cevap1;
            cevap1 = Console.ReadLine();

            if (cevap1 == "C")
            {
                Console.WriteLine("DOĞRU CEVAP !");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.Read();
                dogru++;
                puan=puan+1000;
            }
            else
            {
                Console.WriteLine("YANLIŞ CEVAP");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadLine();
                yanlis++;
                puan = puan - 500;
            }

            Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
            Console.ReadLine();

            string soru2;
            Console.WriteLine("Soru 2 -Coronavirus ilk olarak hangi şehirden dünyaya yayılmaya başlamıştır");
            soru1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("A) Wuhan B) Tokyo C) Torino D) Yunnan");
            string cevap2;
            cevap1 = Console.ReadLine();

            if (cevap1 == "A")
            {
                Console.WriteLine("DOĞRU CEVAP !");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.Read();
                dogru++;
                puan=puan+1000;

            }
            else
            {
                Console.WriteLine("YANLIŞ CEVAP");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadLine();
                yanlis++;
                puan = puan - 500;
            }

            Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
            Console.ReadLine();

            string soru3;
            Console.WriteLine("Soru 3 - Hangisi Ülkemizde virüse dair alınan önlemlerden biri değildir?");
            soru1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("A) 65 Yaş Üstü İnsanların Sokağa Çıkmasının Yasaklanması B) Bankların Kaldırılması C) Okulların Tatil Edilmesi D) Sokağa Çıkma Yasağı");
            string cevap3;
            cevap3 = Console.ReadLine();

            if (cevap3 == "D") 
            {
                Console.WriteLine("DOĞRU CEVAP !");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.Read();
                dogru++;
                puan=puan+1000;

            }
            else
            {
                Console.WriteLine("YANLIŞ CEVAP");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadLine();
                yanlis++;
                puan = puan - 500;
            }

            Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
            Console.ReadLine();

            string soru4;
            Console.WriteLine("Soru 4 - Aşağıdakilerden hangisi coronaviruse karşı alınabilcek kişisel önlemlerden değildir ?");
            soru1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("A) Maske Takmak B) Eldiven Kullanmak C) Kendinizi sıklıkla dezenfekte etmek D) Evden çıkıp temiz hava almak");
            string cevap4;
            cevap4 = Console.ReadLine();

            if (cevap4 == "D")
            {
                Console.WriteLine("DOĞRU CEVAP !");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.Read();
                dogru++;
                puan = puan + 1000;

            }
            else
            {
                Console.WriteLine("YANLIŞ CEVAP");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadLine();
                yanlis++;
                puan = puan - 500;
            }

            Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
            Console.ReadLine();

            string soru5;
            Console.WriteLine("Soru 5 - Türkiye Cumhuriyeti Sağlık Bakanı Kimdir?");
            soru1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("A) Muharrem Kasapoğlu B) Fahrettin Koca C) Bekir Pakdemirli  D) Süleyman Soylu");
            string cevap5;
            cevap5 = Console.ReadLine();

            if (cevap5 == "B")
            {
                Console.WriteLine("DOĞRU CEVAP !");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.Read();
                dogru++;
                puan = puan + 1000;

            }
            else
            {
                Console.WriteLine("YANLIŞ CEVAP");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadLine();
                yanlis++;
                puan = puan - 500;
            }

            Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
            Console.ReadLine();

            string soru6;
            Console.WriteLine("Soru 6 - Hangisi coronavirus belirtisi değildir?");
            soru6 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("A) Öksürük B) Ateş C) İshal D) Nefes Darlığı");
            string cevap6;
            cevap6 = Console.ReadLine();

            if (cevap6 == "C")
            {
                Console.WriteLine("DOĞRU CEVAP !");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.Read();
                dogru++;
                puan = puan + 1000;

            }
            else
            {
                Console.WriteLine("YANLIŞ CEVAP");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadLine();
                yanlis++;
                puan = puan - 500;
            }

            Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
            Console.ReadLine();

            string soru7;
            Console.WriteLine("Soru 7 - Coronavirus ölüm oranı DSÖ ye göre kaçtır?");
            soru7 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("A) 1,6 B) 3,9 C) 3,4 D) 2,2 ");
            string cevap7;
            cevap7 = Console.ReadLine();

            if (cevap7 == "C")
            {
                Console.WriteLine("DOĞRU CEVAP !");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.Read();
                dogru++;
                puan = puan + 1000;

            }
            else
            {
                Console.WriteLine("YANLIŞ CEVAP");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadLine();
                yanlis++;
                puan = puan - 500;
            }

            Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
            Console.ReadLine();

            string soru8;
            Console.WriteLine("Soru 8 - Coronavirus hangi hastalığa yol açmaktadır?");
            soru1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("A) Kabızlık B) Solunum Yolu Hastalıkları C) Sinirsel Hastalıklar D) Felç");
            string cevap8;
            cevap8 = Console.ReadLine();

            if (cevap8 == "B")
            {
                Console.WriteLine("DOĞRU CEVAP !");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.Read();
                dogru++;
                puan = puan + 1000;

            }
            else
            {
                Console.WriteLine("YANLIŞ CEVAP");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadLine();
                yanlis++;
                puan = puan - 500;
            }

            Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
            Console.ReadLine();

            string soru9;
            Console.WriteLine("Soru 9 - Aşağıdakilerden hangisi su ve sabun yoksa kullanılabilecek ürünlerdendir");
            soru9 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("A) Kola B) Gazoz C) Kolonya(Alkol)  D) Şerbet");
            string cevap9;
            cevap9 = Console.ReadLine();

            if (cevap9 == "C")
            {
                Console.WriteLine("DOĞRU CEVAP !");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.Read();
                dogru++;
                puan = puan + 1000;

            }
            else
            {
                Console.WriteLine("YANLIŞ CEVAP");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadLine();
                yanlis++;
                puan = puan - 500;
            }

            Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
            Console.ReadLine();

            string soru10;
            Console.WriteLine("Soru 10 - Corona hangi ülkeden yayılmıştır");
            soru10 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("A) İtalya B) Çin C) İran D) Amerika");
            string cevap10;
            cevap10 = Console.ReadLine();

            if (cevap10 == "B")
            {
                Console.WriteLine("DOĞRU CEVAP !");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.Read();
                dogru++;
                puan = puan + 1000;

            }
            else
            {
                Console.WriteLine("YANLIŞ CEVAP");
                Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadLine();
                yanlis++;
                puan = puan - 500;
            }

            Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
            Console.ReadLine();

            if (puan >=7000)
            {
                Console.WriteLine("Tebrikler   " + ad + " Coronavirus hakkında bilinçli bir bireysiniz");
            }
            else
            {
                Console.WriteLine("Üzgünüz  " + ad + " Coronavirus hakkında biraz daha bilinçlenmeniz gerekiyor");
            }

        }
          
        }         
    }

