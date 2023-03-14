public class kodeBuah
{
    public enum NamaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blacberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka };

    public static String GetKodeBuah(NamaBuah Buah)
    {
        String[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00", };
        return kodeBuah[(int)Buah];
    }

    public static void main()
    {
        Console.WriteLine("Nama Buah" + kodeBuah.NamaBuah.Semangka + "Kode Buah" + kodeBuah.GetKodeBuah(kodeBuah.NamaBuah.Semangka));
    }
}


