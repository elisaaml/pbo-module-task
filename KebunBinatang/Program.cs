using System;
using System.Collections.Generic;

// Kelas Hewan
public class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    // Konstruktor
    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    // Method suara hewan
    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    // Method untuk informasi dasar hewan
    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

// Kelas Mamalia yang mewarisi Hewan
public class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    // Konstruktor
    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    // Override method Suara()
    public override string Suara()
    {
        return "Mamalia ini bersuara";
    }

    // Override method InfoHewan()
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

// Kelas Reptil yang mewarisi Hewan
public class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    // Konstruktor
    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    // Override method Suara()
    public override string Suara()
    {
        return "Reptil ini bersuara";
    }

    // Override method InfoHewan()
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
    }
}

// Kelas Singa yang mewarisi Mamalia
public class Singa : Mamalia
{
    // Konstruktor
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {
        JumlahKaki = jumlahKaki;
    }

    // Method khusus Mengaum()
    public void Mengaum()
    {
        Console.WriteLine($"{Nama} mengaum sangat keras!");
    }

    // Override method InfoHewan()
    public override string InfoHewan()
    {
        return $"Nama Singa: {Nama}, Umur: {Umur} tahun, Jumlah Kaki: {JumlahKaki}";
    }

    // Override method Suara()
    public override string Suara()
    {
        return "RAWRRRRR";
    }
}

// Kelas Gajah yang mewarisi Mamalia
public class Gajah : Mamalia
{
    // Konstruktor
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {
        JumlahKaki = jumlahKaki;
    }

    // Override method InfoHewan()
    public override string InfoHewan()
    {
        return $"Nama Gajah: {Nama}, Umur: {Umur} tahun, Jumlah Kaki: {JumlahKaki}";
    }

    // Override method Suara()
    public override string Suara()
    {
        return "TRUUUMPETTT";
    }
}

// Kelas Ular yang mewarisi Reptil
public class Ular : Reptil
{
    // Konstruktor
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {
        PanjangTubuh = panjangTubuh;
    }

    // Method khusus Merayap()
    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang merayap!");
    }

    // Override method InfoHewan()
    public override string InfoHewan()
    {
        return $"Nama Ular: {Nama}, Umur: {Umur} tahun, Panjang Tubuh: {PanjangTubuh} meter";
    }

    // Override method Suara()
    public override string Suara()
    {
        return "pppsssssttt";
    }
}

// Kelas Buaya yang mewarisi Reptil
public class Buaya : Reptil
{
    // Konstruktor
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {
        PanjangTubuh = panjangTubuh;
    }

    // Override method InfoHewan()
    public override string InfoHewan()
    {
        return $"Nama Buaya: {Nama}, Umur: {Umur} tahun, Panjang Tubuh: {PanjangTubuh} meter";
    }

    // Override method Suara()
    public override string Suara()
    {
        return "No WAnya berapa maniezz?";
    }
}


// Kelas KebunBinatang
public class KebunBinatang
{
    private List<Hewan> koleksiHewan;

    public KebunBinatang()
    {
        koleksiHewan = new List<Hewan>();
    }

    // Method untuk menambah hewan ke koleksi
    public void TambahHewan(Hewan hewan)
    {
        if (hewan is Mamalia || hewan is Reptil)
        {
            koleksiHewan.Add(hewan);
            Console.WriteLine($"{hewan.Nama} telah ditambahkan ke kebun binatang.");
        }
        else
        {
            Console.WriteLine("Hewan yang ditambahkan tidak sesuai dengan jenis yang diperbolehkan.");
        }
    }

    // Method untuk menampilkan daftar hewan di kebun binatang
    public void DaftarHewan()
    {
        Console.WriteLine("\n|| Daftar hewan yang terdapat di kebun binatang ||");

        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine($"\n= {hewan} =");
            Console.WriteLine(hewan.InfoHewan());
            Console.WriteLine($"Suara : {hewan.Suara()}");
        }
    }
}

// Program utama
class Program
{
    static void Main(string[] args)
    {
        // Membuat objek kebun binatang
        KebunBinatang kebunBinatang = new KebunBinatang();

        // Membuat beberapa objek dari berbagai jenis hewan
        Singa singa = new Singa("Mufasa", 10, 4);
        Gajah gajah = new Gajah("Zola", 13, 4);
        Ular ular = new Ular("Nagini", 6, 4.2);
        Buaya buaya = new Buaya("David", 8, 3.25);

        // Menambahkan hewan-hewan ke kebun binatang
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        // Menampilkan semua hewan di kebun binatang
        kebunBinatang.DaftarHewan();

        // Demonstrasi penggunaan polymorphism dengan memanggil method Suara() untuk beberapa hewan berbeda
        Hewan[] hewanArray = { singa, gajah, ular, buaya };

        foreach (var hewan in hewanArray)
        {
            Console.WriteLine($"{hewan.Nama} bersuara: {hewan.Suara()}");
        }

        // Memanggil method khusus
        singa.Mengaum();
        ular.Merayap();
    }
}