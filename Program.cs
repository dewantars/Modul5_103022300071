using System;
class simpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public simpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) +" berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        simpleDataBase<float> db = new simpleDataBase<float>();
        db.addNewData(1.0f);
        db.addNewData(3.0f);
        db.addNewData(2.2f);
        db.printAllData();
    }
}