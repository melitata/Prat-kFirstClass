using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Person
{
    //GET SET LERİ PRİVATE YAPMAYINCA SONSUZ DÖNGÜYE SOKUP HATA VERİYOR
//OYÜZDEN MECBUR PRİVATE YAPTIM 

    private string ad;        
    private string soyad;      
    private DateTime dgmTarihi;

    public string Ad { get { return ad; } set { ad = value; } }

    public string Soyad { get { return soyad; } set { soyad = value; } }
    public DateTime DgmTarihi { get { return dgmTarihi; } set { dgmTarihi = value; } }

    static void Main(string[] args)
    {
        Person person = new Person();
        person.Ad = "Ali";
        person.Soyad = "YIlmaz";
        person.DgmTarihi = new DateTime(1990, 1, 1);
        Person person2 = new Person();
        person2.Ad = "Veli";
        person2.Soyad = "Tüç";
        person2.DgmTarihi = new DateTime(2001, 5, 14);
        Person person3 = new Person();
        person3.Ad = "Metin";
        person3.Soyad = "Kılıç";
        person3.DgmTarihi = new DateTime(1992, 2, 2);
        Person person4 = new Person();
        person4.Ad = "Melisa";
        person4.Soyad = "Kılıç";
        person4.DgmTarihi = new DateTime(2001, 2, 2);
        Person person5 = new Person();
        person5.Ad = "Melike";
        person5.Soyad = "Kul";
        person5.DgmTarihi = new DateTime(1990, 11, 30);
        Console.WriteLine("İSİM:\t\t\t" + person.Ad + "\nSOYİSİM:\t\t" + person.Soyad + "\nDOĞUM TARİHİ:\t\t" + person.DgmTarihi.ToShortDateString());
        Console.WriteLine("İSİM:\t\t\t" + person2.Ad + "\nSOYİSİM:\t\t" + person2.Soyad + "\nDOĞUM TARİHİ:\t\t" + person2.DgmTarihi.ToShortDateString());
        Console.WriteLine("İSİM:\t\t\t" + person3.Ad + "\nSOYİSİM:\t\t" + person3.Soyad + "\nDOĞUM TARİHİ:\t\t" + person3.DgmTarihi.ToShortDateString());
        Console.WriteLine("İSİM:\t\t\t" + person4.Ad + "\nSOYİSİM:\t\t" + person4.Soyad + "\nDOĞUM TARİHİ:\t\t" + person4.DgmTarihi.ToShortDateString());
        Console.WriteLine("İSİM:\t\t\t" + person5.Ad + "\nSOYİSİM:\t\t" + person5.Soyad + "\nDOĞUM TARİHİ:\t\t" + person5.DgmTarihi.ToShortDateString());
        

    }
    
}




