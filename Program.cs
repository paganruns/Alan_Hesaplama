namespace alan;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen geometrik bir şekil seçiniz:");
        Console.WriteLine("1. {0}", (Sekiller)1);
        Console.WriteLine("2. {0}", (Sekiller)2);
        Console.WriteLine("3. {0}", (Sekiller)3);
        Console.WriteLine("4. {0}", (Sekiller)4); 

        Console.Write("Seçiminiz: ");
        int sekil = Convert.ToInt32(Console.ReadLine());


        switch (sekil)
        {

            case 1:
                Console.Write("Kısa kenarı giriniz: ");
                int kisaKenar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Uzun kenarı giriniz: ");
                int uzunKenar = Convert.ToInt32(Console.ReadLine());

                Dikdortgen dikdortgen = new Dikdortgen(kisaKenar, uzunKenar, 0, out int sonuc);

                Console.WriteLine("Alanı: {0}", sonuc);

                break;

            case 2:
                Console.Write("Kısa kenarı giriniz: ");
                int kisaKenar1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dik kenarı giriniz: ");
                int dikKenar1 = Convert.ToInt32(Console.ReadLine());

                Ucgen ucgen = new Ucgen(kisaKenar1, 0, dikKenar1, out int sonuc1);

                Console.WriteLine("Alanı: {0}", sonuc1);

                break;

            case 3:
                Console.Write("Bir kenarı giriniz: ");
                int tekKenar = Convert.ToInt32(Console.ReadLine());

                Kare kare = new Kare(tekKenar, 0, 0, out int sonuc2);

                Console.WriteLine("Alanı: {0}", sonuc2);

                break;

            case 4:
                Console.Write("Yarıçap giriniz: ");
                int yariCap = Convert.ToInt32(Console.ReadLine());
                Daire daire = new Daire(yariCap, 0,0, out double sonuc3);
                System.Console.WriteLine("Alanı: {0}", sonuc3);
                break;

        }

    }

    public enum Sekiller
    {

        Dikdortgen = 1,
        Ucgen = 2,
        Kare = 3,
        Daire = 4
    }

    public abstract class Kenarlar
    {
        public int Kenar1;
        public int Kenar2;
        public int Kenar3;

        protected Kenarlar(int kenar1, int kenar2, int kenar3)
        {
            Kenar1 = kenar1;
            Kenar2 = kenar2;
            Kenar3 = kenar3;
        }
    }

    public class Kare : Kenarlar
    {
        public Kare(int kenar1, int kenar2, int kenar3, out int sonuc) : base(kenar1, kenar2, kenar3)
        {
            sonuc = Kenar1 * Kenar1;
        }

    }

    public class Ucgen : Kenarlar
    {
        public Ucgen(int kenar1, int kenar2, int kenar3, out int sonuc) : base(kenar1, kenar2, kenar3)
        {
            sonuc = Kenar1 * Kenar3 / 2;
        }
    }

    public class Dikdortgen : Kenarlar
    {
        public Dikdortgen(int kenar1, int kenar2, int kenar3, out int sonuc) : base(kenar1, kenar2, kenar3)
        {
            sonuc = Kenar1 * Kenar2;
        }
    }

    public class Daire: Kenarlar
    {
        public Daire(int kenar1, int kenar2, int kenar3, out double sonuc) : base(kenar1, kenar2, kenar3)
        {
            sonuc = (Kenar1 * Kenar1) * 3.14;
        }
    }
    

}

