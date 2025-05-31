namespace MatematikaLibraries
{
    public class Matematika
    {
        public static int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }

        public static string Turunan(int[] persamaan)
        {
            List<string> hasil = new List<string>();
            int pangkat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koef = persamaan[i] * pangkat;
                if (koef == 0) continue;

                string suku = koef.ToString();
                if (pangkat - 1 > 1)
                    suku += $"x{pangkat - 1}";
                else if (pangkat - 1 == 1)
                    suku += "x";

                hasil.Add(suku);
                pangkat--;
            }
            return string.Join(" + ", hasil).Replace("+ -", "- ");
        }

        public static string Integral(int[] persamaan)
        {
            List<string> hasil = new List<string>();
            int pangkat = persamaan.Length;

            for (int i = 0; i < persamaan.Length; i++)
            {
                double koef = (double)persamaan[i] / (pangkat);
                string suku = (koef == 1 ? "" : koef.ToString("0.##")) + $"x{pangkat}";
                hasil.Add(suku);
                pangkat--;
            }

            hasil.Add("C");
            return string.Join(" + ", hasil).Replace("+ -", "- ");
        }
    }
}