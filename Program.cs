internal class Program
{
    class PemrosesanData<T>
    {
        private T a, b, c;
        public T DapatkanNilaiTerbesar(T a, T b, T c)
        {
            dynamic terbesar = a;
            if (b > terbesar)
            {
                terbesar = b;
            }
            if (c > terbesar)
            {
                terbesar = c;
            }
            return terbesar;
        }
    }
    private static void Main(string[] args)
    {
        PemrosesanData<double> data = new PemrosesanData<double>();
        double output = data.DapatkanNilaiTerbesar(2.263, 5.62356, 6.6265);
        Console.WriteLine(output);
    }
}