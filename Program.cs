// See https://aka.ms/new-console-template for more information
class KodeProduk
{
    private string[] Produk =
    {
        "Laptop","Smartphone","Tablet","Headset","Keyboard","Mouse","Printer","Monitor","Smartwatch","Kamera"
    };

    private string[] kodeProduk =
    {
        "E100","E101","E102","E103","E104","E105","E106","E107","E108","E109"
    };

    public string getKodeProduk(string Produk)
    {
        for (int i = 0; i < Produk.Length; i++)
        {
            if (this.Produk[i] == Produk)
            {
                return this.kodeProduk[i];
            }
        }
        return null;
    }
}

class Program
{
    static void Main()
    {
        KodeProduk kode = new KodeProduk();
        Console.WriteLine(kode.getKodeProduk("Tablet"));
    }
}
