class program
{
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
        PemrosesData datas = new PemrosesData();
        datas.DapatkanNilaiTerbesar<float>(11, 35, 36);
        
    }
}