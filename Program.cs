using System;

class Buku
{
    // Property
    public string Judul { get; set; }
    public string Penulis { get; set; }
    public int Tahun { get; set; }
    public int Harga { get; set; }

    // Method untuk menampilkan data
    public void TampilData()
    {
        Console.WriteLine("Judul   : " + Judul);
        Console.WriteLine("Penulis : " + Penulis);
        Console.WriteLine("Tahun   : " + Tahun);
        Console.WriteLine("Harga   : Rp " + Harga.ToString("N0"));
    }
}

class Program
{
    static void Main()
    {
        // Data awal
        Buku buku = new Buku
        {
            Judul = "Pemrograman C# Dasar",
            Penulis = "Budi Santoso",
            Tahun = 2012,
            Harga = 75000
        };

        Console.WriteLine("Data Buku Awal");
        buku.TampilData();

        Console.WriteLine("\nUpdate Data Buku");

        // Input data baru
        Console.Write("Judul baru   : ");
        buku.Judul = Console.ReadLine();

        Console.Write("Penulis baru : ");
        buku.Penulis = Console.ReadLine();

        Console.Write("Tahun        : ");
        buku.Tahun = int.Parse(Console.ReadLine());

        Console.Write("Harga        : ");
        buku.Harga = int.Parse(Console.ReadLine());

        Console.WriteLine("\nData Buku Setelah Update");
        buku.TampilData();

        Console.ReadKey();
    }
}
