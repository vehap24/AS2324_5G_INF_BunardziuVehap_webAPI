namespace AS2324_5G_INF_BunardziuVehap_webAPI.Models
{
    public class Operazioni
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public bool Multiplo => N2 % N1 == 0;
        public int Potenza(int N1, int N2)
        {
            int risultato = 1;
            for(int i = 0; i < N2; i++)
            {
                risultato = risultato * i;
            }
            return risultato;
        }
        public bool AnnoBisestile => N1 % 4 == 0;

        public int Ipotenusa(int N1, int N2) {
            ((N1 * N1) + (N2 * N2));
        }
    }
}
