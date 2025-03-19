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
class program
{
    static void Main()
    {
        double a = 1.0;
        double b = 3.0;
        double c = 2.2;
        PemrosesData data = new PemrosesData();
        Console.WriteLine("aaaaaaaa");
    }
}