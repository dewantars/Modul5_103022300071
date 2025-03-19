public class PemrosesData()
{
    public float DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        dynamic nilaiTerbesar = (dynamic)a;
        dynamic data = (dynamic)b;
        dynamic data2 = (dynamic)c;

        if (nilaiTerbesar < data)
        {
            nilaiTerbesar = data;
        }
        if (nilaiTerbesar < data2)
        {
            nilaiTerbesar = data2;
        }
        return nilaiTerbesar;
    }


}

class Program
{
    static void Main()
    {
        PemrosesData pemrosesData = new PemrosesData();
        float nilaiTerbesar = pemrosesData.DapatkanNilaiTerbesar(1.0f, 3.0f, 2.2f);
        Console.WriteLine("Nilai terbesar dari 1.0, 3.0, 2.2 adalah");
        Console.WriteLine(nilaiTerbesar);
    }
}