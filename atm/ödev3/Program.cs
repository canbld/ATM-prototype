using System;
using System.Drawing;


Random rnd = new Random();
int tutar,bakiye = 10000;
int i, s, k, j;
int fat,devam;
int hak = 3,islem;
string sifre = "1234";

for (i = 0; i <= 1; i++)
{
    Console.Write("Şifre giriniz : ");
    string gsifre = Console.ReadLine();
    if (gsifre == sifre)
    {
        
        for (s = 0; s < 1; s++)
        {
            Console.WriteLine("İşlem seçiniz : \n1. Para Yatırma\n2. Para Çekme\n3. Bakiye Sorgulama\n4. Fatura Ödeme\n5. Çıkış");
            islem = int.Parse(Console.ReadLine());
            if (islem == 1)
            {
                for (k = 0; k < 1; k++)
                {
                    Console.WriteLine("Yatırmak istediğiniz tutarı seçiniz : ");
                    for (j = 1; j <= 10; j++)
                    {
                        Console.Write($"{10 * j}TL ");
                        i = 1;
                    }
                    Console.WriteLine();
                    tutar = int.Parse(Console.ReadLine());
                    if (tutar % 10 == 0)
                    {
                        bakiye = bakiye + tutar;
                        Console.WriteLine($"Mevcut bakiyeniz : {bakiye} TL");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış tutar girdiniz. Girdiğiniz tutar onun(10) katı olmalıdır.");
                        k--;
                    }
                }
                Console.WriteLine("Ana menüye dönmek için 0(sıfır) tuşlayınız.\nÇıkış yapmak için 5(beş) tuşlayınız.");
                devam = int.Parse(Console.ReadLine());
                if (devam == 0)
                {
                    s--;
                }
                else
                {
                    Console.WriteLine("Çıkış yapılıyor");
                    break;
                }
            }
            else if (islem == 2)
            {
                for (k = 0; k < 1; k++)
                {
                    Console.WriteLine("Çekmek istediğiniz tutarı seçiniz : ");
                    for (j = 1; j <= 10; j++)
                    {
                        Console.Write($"{10 * j}TL ");
                        i = 1;
                    }
                    Console.WriteLine();
                    tutar = int.Parse(Console.ReadLine());
                    if (tutar % 10 == 0)
                    {
                        bakiye = bakiye - tutar;
                        if (bakiye < 0)
                        {
                            bakiye = bakiye + tutar;
                            Console.WriteLine("Yetersiz bakiye");
                            Console.WriteLine($"Mevcut bakiyeniz : {bakiye} TL");
                        }
                        else
                        {
                            Console.WriteLine($"Mevcut bakiyeniz : {bakiye} TL");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yanlış tutar girdiniz. Girdiğiniz tutar onun(10) katı olmalıdır.");
                        k--;
                    }
                }
                Console.WriteLine("Ana menüye dönmek için 0(sıfır) tuşlayınız.\nÇıkış yapmak için 5(beş) tuşlayınız.");
                devam = int.Parse(Console.ReadLine());
                if (devam == 0)
                {
                    s--;
                }
                else
                {
                    Console.WriteLine("Çıkış yapılıyor");
                    break;
                }
            }
            else if (islem == 3)
            {
                Console.WriteLine($"Mevcut bakiyeniz : {bakiye} TL");
                Console.WriteLine("Ana menüye dönmek için 0(sıfır) tuşlayınız.\nÇıkış yapmak için 5(beş) tuşlayınız.");
                devam = int.Parse(Console.ReadLine());
                if (devam == 0)
                {
                    s--;
                }
                else
                {
                    Console.WriteLine("Çıkış yapılıyor");
                    return;
                }
            }
            else if (islem == 4)
            {
                Console.WriteLine("1-Elektrik\n2-Su\n3-Doğalgaz\n4-İnternet");
                Console.Write("Ödemek istediğiniz faturayı tuşlayınız : ");
                fat = int.Parse(Console.ReadLine());
                if (fat ==1)
                {
                    int fatu = rnd.Next(100, 2001);
                    Console.WriteLine($"Fatura tutarı {fatu} TL");
                    Console.WriteLine("Ödemek için 1(bir) tuşlayınız.\nAna menüye dönmek için 0(sıfır) tuşlayınız.\nÇıkış yapmak için 5(beş) tuşlayınız.");
                    devam = int.Parse(Console.ReadLine());
                    if (devam == 1)
                    {
                        bakiye = bakiye - fatu;
                        if (bakiye<0)
                        {
                            bakiye = bakiye + fatu;
                            Console.WriteLine("Ödeme başarısız yetersiz bakiye.");
                            Console.WriteLine($"Kalan bakiyeniz {bakiye}");
                        }
                        else
                        {
                            Console.WriteLine($"Ödeme başarılı kalan bakiyeniz {bakiye}");
                        }
                    }
                    else if (devam == 0)
                    {
                        s--;
                    }
                    else
                    {
                        Console.WriteLine("Çıkış yapılıyor");
                        return;
                    }
                }
                else if (fat==2)
                {
                    int fatu = rnd.Next(100, 2001);
                    Console.WriteLine($"Fatura tutarı {fatu} TL");
                    Console.WriteLine("Ödemek için 1(bir) tuşlayınız.\nAna menüye dönmek için 0(sıfır) tuşlayınız.\nÇıkış yapmak için 5(beş) tuşlayınız.");
                    devam = int.Parse(Console.ReadLine());
                    if (devam == 1)
                    {
                        bakiye = bakiye - fatu;
                        if (bakiye <0)
                        {
                            bakiye = bakiye + fatu;
                            Console.WriteLine("Ödeme başarısız yetersiz bakiye");
                            Console.WriteLine($"Kalan bakiyeniz {bakiye}");
                        }
                        else
                        {
                            Console.WriteLine($"Ödeme başarılı kalan bakiyeniz {bakiye}");
                        }
                    }
                    else if (devam == 0)
                    {
                        s--;
                    }
                    else
                    {
                        Console.WriteLine("Çıkış yapılıyor");
                        return;
                    }
                }
                else if (fat ==3)
                {
                    int fatu = rnd.Next(100, 2001);
                    Console.WriteLine($"Fatura tutarı {fatu} TL");
                    Console.WriteLine("Ödemek için 1(bir) tuşlayınız.\nAna menüye dönmek için 0(sıfır) tuşlayınız.\nÇıkış yapmak için 5(beş) tuşlayınız.");
                    devam = int.Parse(Console.ReadLine());
                    if (devam == 1)
                    {
                        bakiye = bakiye - fatu;
                        if (bakiye < 0)
                        {
                            bakiye = bakiye + fatu;
                            Console.WriteLine("Ödeme başarısız yetersiz bakiye");
                            Console.WriteLine($"Kalan bakiyeniz {bakiye}");
                        }
                        else
                        {
                            Console.WriteLine($"Ödeme başarılı kalan bakiyeniz {bakiye}");
                        }
                    }
                    else if (devam == 0)
                    {
                        s--;
                    }
                    else
                    {
                        Console.WriteLine("Çıkış yapılıyor");
                        return;
                    }
                }
                else if (fat ==4)
                {
                    int fatu = rnd.Next(100, 2001);
                    Console.WriteLine($"Fatura tutarı {fatu} TL");
                    Console.WriteLine("Ödemek için 1(bir) tuşlayınız.\nAna menüye dönmek için 0(sıfır) tuşlayınız.\nÇıkış yapmak için 5(beş) tuşlayınız.");
                    devam = int.Parse(Console.ReadLine());
                    if (devam == 1)
                    {
                        bakiye = bakiye - fatu;
                        if (bakiye < 0)
                        {
                            bakiye = bakiye + fatu;
                            Console.WriteLine("Ödeme başarısız yetersiz bakiye");
                            Console.WriteLine($"Kalan bakiyeniz {bakiye}");
                        }
                        Console.WriteLine($"Ödeme başarılı kalan bakiyeniz {bakiye}");
                    }
                    else if (devam == 0)
                    {
                        s--;
                    }
                    else
                    {
                        Console.WriteLine("Çıkış yapılıyor");
                        return;
                    }
                }
                Console.WriteLine("Ana menüye dönmek için 0(sıfır) tuşlayınız.\nÇıkış yapmak için 5(beş) tuşlayınız.");
                devam = int.Parse(Console.ReadLine());
                if (devam == 0)
                {
                    s--;
                }
                else
                {
                    Console.WriteLine("Çıkış yapılıyor");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Çıkış yapılıyor");
                return;
            }
        }
    }
    else
    {
        hak--;
        if (hak == 0)
        {
            Console.WriteLine("Hesabınız bloke edildi detaylı bilgi için müşteri hizmetlerimizi arayınız : 444 31 31");
            break;
        }
        else
        {
            Console.WriteLine("Yanlış şifre girdiniz lütfen tekrar deneyiniz");
            i--;
        }
    }
}



