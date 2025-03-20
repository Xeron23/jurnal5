
﻿class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i] + " AM");
        }
    }
}


﻿internal class Program
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
      
      
       SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(12);
        data.AddNewData(34);
        data.AddNewData(56);
        data.PrintAllData();
    }
}
