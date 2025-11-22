using System;

class Program
{
    static void Main(string[] args)
    {
        // 1) Kullanıcıya hoş geldin mesajı
        Console.WriteLine("Not Hesaplama Uygulamasına Hoş Geldiniz!");
        Console.WriteLine("----------------------------------------");
        
        // 2) Kullanıcıdan ad bilgisini al
        Console.Write("Lütfen adınızı girin: ");
        string ad = Console.ReadLine();

        // 3) 3 adet sınav notu iste
        Console.Write("1. sınav notunu girin: ");
        double not1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. sınav notunu girin: ");
        double not2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("3. sınav notunu girin: ");
        double not3 = Convert.ToDouble(Console.ReadLine());

        // 4) Ortalama hesapla
        double ortalama = (not1 + not2 + not3) / 3;

        // 5) Harf notu belirle
        string harfNotu;
        if (ortalama >= 85)
            harfNotu = "AA";
        else if (ortalama >= 75)
            harfNotu = "BA";
        else if (ortalama >= 65)
            harfNotu = "BB";
        else if (ortalama >= 55)
            harfNotu = "CB";
        else if (ortalama >= 50)
            harfNotu = "CC";
        else
            harfNotu = "FF";

        // 6) Geçti mi kaldı mı?
        string durum = ortalama >= 50 ? "GEÇTİ" : "KALDI";

        // 7) Sonuçları ekrana yazdır
        Console.WriteLine();
        Console.WriteLine("----- Sonuç -----");
        Console.WriteLine($"Öğrenci: {ad}");
        Console.WriteLine($"Ortalama: {ortalama:F2}");
        Console.WriteLine($"Harf Notu: {harfNotu}");
        Console.WriteLine($"Durum: {durum}");

        // 8) Program hemen kapanmasın
        Console.WriteLine();
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}


