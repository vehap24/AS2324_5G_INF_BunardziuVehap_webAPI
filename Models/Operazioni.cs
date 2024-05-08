namespace AS2324_5G_INF_BunardziuVehap_webAPI.Models
{
    public class Operazioni
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public bool N_positivo => N1 > 0 && N2 > 0;
        public bool Multiplo => N1 % N2 == 0;
        public int Potenza(int N1, int N2)
        {
            int risultato = N1;
            for(int i = 1; i < N2; i++)
            {
                risultato = risultato * i;
            }
            return risultato;
        }
        public bool AnnoBisestile => N1 % 4 == 0;

        public float Ipotenusa(int N1, int N2) {
            return (float)Math.Sqrt((N1 * N1) + (N2 * N2));
        }
    }
}
