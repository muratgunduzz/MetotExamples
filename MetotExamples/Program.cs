/*Aynı uygulama içerisinde 4 adet metot tanımlamanız ve çağırmanız isteniyor :

Geriye Değer Döndürmeyen Bir void metot.

Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 

Geriye Tamsayı Döndüren Bir metot

Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

Parametre Alan ve Geriye Değer Döndüren Bir Metot

Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.*/

using System;

class Program
{
    // 1. Geriye Değer Döndürmeyen void metot
    static void Song()
    {
        Console.WriteLine("Sad but true");
    }

    // 2. Geriye Tamsayı Döndüren Metot
    static int Number()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 100);
        int remainder = randomNumber % 2;
        Console.WriteLine($"Üretilen sayı: {randomNumber}, 2'ye bölümünden kalan: {remainder}");
        return remainder;
    }

    // 3. Parametre Alan ve Geriye Değer Döndüren Metot
    static int Parameters(int num1, int num2)
    {
        return num1 * num2;
    }

    // 4. Parametre Alan ve Geriye Değer Döndürmeyen Metot
    static void User(string firstName, string lastName)
    {
        Console.WriteLine($"Hoş Geldiniz {firstName} {lastName}!");
    }

    static void Main()
    {
        Song();

        int number = Number();

        Console.WriteLine("Çarpım sonucu: " + Parameters(5, 10));

        User("Murat", "GÜNDÜZ");
    }
}
