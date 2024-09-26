using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

public class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }
    public virtual string Suara()
    {
        return "Hewan ini bersuara.";
    }
    public virtual string InfoHewan()
    {
        return $"Nama : {Nama}, Umur : {Umur} tahun.";
    }
}
public class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string nama, int umur, int JumlahKaki) : base(nama, umur)
    {
        jumlahKaki = JumlahKaki;
    }
    public override string InfoHewan()
    {
        return $"{base.InfoHewan()}, Jumlah Kaki : {jumlahKaki}.";
    }
}
public class Reptil : Hewan
{
    public double panjangTubuh;
    public Reptil(string nama, int umur, double panjangtubuh) : base(nama, umur)
    {
        panjangTubuh = panjangtubuh;
    }
    public override string InfoHewan()
    {
        return $"{base.InfoHewan()}, Panjang Tubuh : {panjangTubuh} meter.";
    }
}
public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahkaki) : base(nama, umur, jumlahkaki)
    { }
    public override string Suara()
    {
        return "Singa mengaum.";
    }
    public void Mengaum()
    {
        Console.WriteLine("Aaumm!");
    }
}
public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahkaki) : base(nama, umur, jumlahkaki)
    { }
    public override string Suara()
    {
        return "Gajah mengeluarkan suara terompet lewat belalainya.";
    }
}
public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangtubuh) : base(nama, umur, panjangtubuh)
    { }
    public override string Suara()
    {
        return "Ular mendesis.";
    }
    public void Merayap()
    {
        Console.WriteLine("Ular sedang merayap.");
    }
}
public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangtubuh) : base(nama, umur, panjangtubuh)
    { }
    public override string Suara()
    {
        return "Buaya mengeram.";
    }
}
public class KebunBinatang
{
    public List<Hewan> koleksiHewan = new List<Hewan>();
    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }
    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}
class Program
{
    static void Main()
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Singa", 4, 3);
        Gajah gajah = new Gajah("Gajah", 10, 6);
        Ular ular = new Ular("Ular", 3, 4);
        Buaya buaya = new Buaya("Buaya", 9, 3.7);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

    }
}