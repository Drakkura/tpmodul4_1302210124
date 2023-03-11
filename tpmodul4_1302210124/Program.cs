// See https://aka.ms/new-console-template for more information
namespace mod4_1302210124 {
    internal class program {
        public enum dataKota {
            Batununggal,
            Kujangsari,
            Mengger,
            Wates,
            Cijaura,
            Jatisari,
            Margasari,
            Sekejati,
            Kebonwaru,
            Maleer,
            Samoja
        };
        public class getKodePos {
            public static int getKode(dataKota kota) {
                int[] kodepos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
                return kodepos[(int)kota];
            }
        }
        public static void Main(string[] args) {
            dataKota kota = dataKota.Jatisari;
            int kode = getKodePos.getKode(kota);
            Console.WriteLine("Kelurahan: " + kota + "\nkodepos: " + kode);
        }
    }
}