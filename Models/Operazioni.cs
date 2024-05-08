namespace AS2324_5G_INF_BunardziuVehap_webAPI.Models
{
    public class Operazioni
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public bool N_positivo => N1 >= 0 && N2 >= 0;
        public bool N1_positivo => N1 >= 0;
        public bool Multiplo => N1 % N2 == 0;
        public double Potenza(){
            return Math.Pow(N1, N2);
        }
        public bool AnnoBisestile => N1 % 4 == 0;

        public float Ipotenusa() {
            return (float)Math.Sqrt((N1 * N1) + (N2 * N2));
        }
    }
}
