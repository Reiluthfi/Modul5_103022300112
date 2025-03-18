class program
{
    class SimpleDataBase<T>
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
                Console.WriteLine($"Data {i+1} berisi : " +storedData[i] + ", yang disimpan pada waktu UTC:" + inputDates[i]);
            }
    class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T data1, T data2, T data3)
        {
            dynamic nilaiTerbesar = 0;
            for (int i = 0; i < 3; i++)
            {
                if (data1 > nilaiTerbesar)
                {
                    nilaiTerbesar = data1;
                }
                if (data2 > nilaiTerbesar)
                {
                    nilaiTerbesar = data2;
                }
                if (data3 > nilaiTerbesar)
                {
                    nilaiTerbesar = data3;
                }
            }
            Console.WriteLine(nilaiTerbesar);
          
        }
    }
    static void Main()
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(12);
        db.AddNewData(34);
        db.AddNewData(56);
        db.PrintAllData();

        PemrosesData datas = new PemrosesData();
        datas.DapatkanNilaiTerbesar<float>(10, 30, 22);
        
    }
}