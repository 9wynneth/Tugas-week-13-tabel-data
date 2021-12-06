using System;

namespace Tugas_week_13_tabel_data
{
    class Program
    {
        static void NamaAda(int i)
        {
            Console.WriteLine("NIM SUDAH ADA, MASUKAN NIM LAIN!!!");
            Console.Write(String.Format("{0,-15} {1,-1}", "NIM", ":"));
        }
        static void Main(string[] args)
        {
            while (true)
            Console.Write("Berapa Data = ");
            int JumlahData = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string[,] Data = new string[JumlahData, 7];
            for (int i = 0; i < JumlahData; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine($"Data ke - {i + 1}");
                    }
                    else
                    {
                        if (j == 1)
                        {
                            Console.Write(String.Format("{0,-15} {1,-1}", "NIM",":"));
                            Data[i, 1] = Console.ReadLine();
                            if (i == 1)
                                while (Data[i, 1] == Data[i - 1, 1])
                                {
                                    NamaAda(i);
                                    Data[i, 1] = Console.ReadLine();
                                }
                            if (i == 2)
                                while (Data[i, 1] == Data[i - 1, 1] || Data[i, 1] == Data[i - 2, 1])
                                {
                                    NamaAda(i);
                                    Data[i, 1] = Console.ReadLine();
                                }
                            if (i == 3)
                                while (Data[i, 1] == Data[i - 1, 1] || Data[i, 0] == Data[i - 2, 1] || Data[i, 1] == Data[i - 3, 1])
                                {
                                    NamaAda(i);
                                    Data[i, 1] = Console.ReadLine();
                                }
                            if (i == 4)
                                while (Data[i, 1] == Data[i - 1, 1] || Data[i, 0] == Data[i - 2, 1] || Data[i, 1] == Data[i - 3, 1] || Data[i, 1] == Data[i - 4, 1])
                                {
                                    NamaAda(i);
                                    Data[i, 1] = Console.ReadLine();
                                }
                        }
                        if (j == 2)
                        {
                            Console.Write(String.Format("{0,-15} {1,-1}", "NAMA", ":"));
                            Data[i, 2] = Console.ReadLine();
                        }
                        if (j == 3)
                        {
                            Console.Write(String.Format("{0,-15} {1,-1}", "JENIS KELAMIN ", ":"));
                            Data[i, 3] = Console.ReadLine();
                        }
                        if (j == 4)
                        {
                            Console.Write(String.Format("{0,-15} {1,-1}", "TAHUN MASUK", ":"));
                            Data[i, 4] = Console.ReadLine();
                        }
                        if (j == 5)
                        {
                            Console.Write(String.Format("{0,-15} {1,-1}", "PROGRAM STUDI", ":"));
                            Data[i, 5] = Console.ReadLine();
                        }
                        if (j == 6)
                        {
                            Console.Write(String.Format("{0,-15} {1,-1}", "KELAS", ":"));
                            Data[i, 6] = Console.ReadLine();
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("PRINT HASIL ? (y/n) . . . ");
            string Print = Console.ReadLine();
            if (Print == "y")
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0,-4}{1,-6}{2,-25}{3,-20}{4,-15}{5,-18}{6,-14}", "NO", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAN STUDI", "KELAS"));
                for (int k = 0; k < JumlahData; k++)
                {
                    Console.WriteLine(String.Format("{0,-4}{1,-6}{2,-25}{3,-20}{4,-15}{5,-18}{6,-14}", k + 1, Data[k, 1].ToUpper(), Data[k, 2].ToUpper(), Data[k, 3].ToUpper(), Data[k, 4].ToUpper(), Data[k, 5].ToUpper(), Data[k, 6].ToUpper()));
                }
                    Console.Write("Tambah Data? (y/n) ... ");
                    string TambahData = Console.ReadLine();
                    if (TambahData=="y")
                    {
                        
                    }
                    else if (TambahData=="n")
                    {
                        System.Environment.Exit(1);
                }
                
            }
            else if (Print == "n")
            {
                System.Environment.Exit(1);
            }
        }
    }
}
