class PemrosesData
{
    public double DapatkanNilaiTerbesar<T>(T data, T data1, T data2)
    {

        dynamic a = (dynamic)data1;
        dynamic b = (dynamic)data2;
        dynamic c = (dynamic)data;
        dynamic max = a;
        if (max < b)
        {
            max = b;
        }
        if (max < c)
        {
            max = c;
        }
        return max;
    }

}

class simpleDatabase<T>
{
    private List<T> storageData;
    private List<DateTime> inputDates;

    public simpleDatabase()
    {
        storageData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storageData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 1; i < storageData.Count; i++)
        {
            Console.WriteLine("data" + i + "berisi " + storageData[i] + " Yang disimpan pada waktu UTC:  " + inputDates[i]);
        }

    }
}

class program
{
    static void Main()
    {
        double a = 1.0;
        double b = 3.0;
        double c = 2.2;
        PemrosesData data = new PemrosesData();
        Console.WriteLine("Nilai terbesdar dari dari 1.0, 3.0, 2.2 adalah" + data.DapatkanNilaiTerbesar(a, b, c));
        

        simpleDatabase<int> database = new simpleDatabase<int>();
        database.addNewData(10);
        database.addNewData(30);
        database.addNewData(22);
        database.printAllData();
        // Error di run Muhammad Salman Al Farizy sudah dicoba diperbaiki bang Syauqi tadi tap kata bang syauqi kasih comment aja wewe 
    }
}