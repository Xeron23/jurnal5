
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


class Program
{
    private static void Main(string[] args)
    {


        SimpleDataBase<int> data1 = new SimpleDataBase<int>();
        data1.AddNewData(12);
        data1.AddNewData(34);
        data1.AddNewData(56);
        data1.PrintAllData();
    }
}

