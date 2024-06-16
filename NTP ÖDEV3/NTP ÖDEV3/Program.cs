namespace NTPÖDEV3
{
    class Dersler
    {
        int ID;
        public string ders_Adi;
        int egitmenID;
        public Dersler(int ID, string ders_Adi)
        {
            this.ID = ID;
            this.ders_Adi = ders_Adi;
        }
    }
    class Öğretmenler
    {
        public int ID;
        public string Öğretmen_Adi;
        Dersler[] verilenDersler = new Dersler[20];
        public Öğretmenler(int ID, string Öğretmen_Adi)
        {
            this.ID = ID;
            this.Öğretmen_Adi = Öğretmen_Adi;
        }
        class Soru2
        {
            public static void Main(string[] args)
            {
                Öğretmenler öğretmen1 = new Öğretmenler(1, "Ali");
                Öğretmenler öğretmen2 = new Öğretmenler(2, "Salih");
                Öğretmenler öğretmen3 = new Öğretmenler(3, "Mert");
                Öğretmenler öğretmen4 = new Öğretmenler(4, "Enes");
                Öğretmenler öğretmen5 = new Öğretmenler(4, "Onur");
                Dersler ders1 = new Dersler(1, "lineer Cebir");
                Dersler ders2 = new Dersler(2, "Görüntü İşleme");
                Dersler ders3 = new Dersler(3, "Matematik");
                Dersler ders4 = new Dersler(4, "Ayrık Matematik");
                Dersler ders5 = new Dersler(5, "Veri Yapıları");
                Dersler ders6 = new Dersler(6, "Sayısal Tasarım");
                Dersler ders7 = new Dersler(7, "Fizik");
                Dersler ders8 = new Dersler(8, "Algoritma");
                Dersler ders9 = new Dersler(9, "Elektrik");
                Dersler ders10 = new Dersler(10, "İnkılap");
                Dersler ders11 = new Dersler(11, "Sinyal");
                Dersler ders12 = new Dersler(12, "BBT");
                Dersler ders13 = new Dersler(13, "Kimya");
                Dersler ders14 = new Dersler(14, "Diferansiyel");
                Dersler ders15 = new Dersler(15, "Arge");
                Dersler ders16 = new Dersler(16, "İngilizce");
                dersEkle(ders1, öğretmen1);
                dersEkle(ders2, öğretmen1);
                dersEkle(ders5, öğretmen1);
                dersEkle(ders3, öğretmen2);
                dersEkle(ders4,öğretmen2);
                dersEkle(ders6, öğretmen2);
                dersEkle(ders7, öğretmen3);
                dersEkle(ders8, öğretmen4);
                dersEkle(ders9, öğretmen4);
                dersEkle(ders10, öğretmen3);
                dersEkle(ders11, öğretmen4);
                dersEkle(ders12, öğretmen3);
                dersEkle(ders13, öğretmen5);
                dersEkle(ders14, öğretmen5);
                dersEkle(ders15, öğretmen5);
                dersEkle(ders16, öğretmen5);
                dersSirala(öğretmen1);
                dersSirala(öğretmen2);
                dersSirala(öğretmen3);
                dersSirala(öğretmen4);
                dersSirala(öğretmen5);
                Console.ReadKey();
            }
            public static Öğretmenler dersEkle(Dersler ders, Öğretmenler öğretmen)
            {
                int i = 0;
                while (öğretmen.verilenDersler[i] != null)
                {
                    i++;
                }
                öğretmen.verilenDersler[i] = ders;
                return öğretmen;
            }
            public static void dersSirala(Öğretmenler öğretmen)
            {
                Console.WriteLine();
                Console.WriteLine("Öğretmen ID-adı : " + öğretmen.ID + " - " + öğretmen.Öğretmen_Adi);
                Console.WriteLine("Verdiği Dersler :");
                foreach (Dersler i in öğretmen.verilenDersler)
                {
                    if (i == null) { break; }
                    Console.WriteLine(i.ders_Adi);
                }
            }
        }
    }
}