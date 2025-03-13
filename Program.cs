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

class FanLaptop
{
    private enum Mode { Quiet, Balanced, Performance, Turbo };
    private Mode currentMode;
    public FanLaptop()
    {
        this.currentMode = Mode.Quiet;
    }

    public void ModeUp()
    {
        switch (currentMode)
        {
            case Mode.Quiet:
                toBalancedMode();
                break;
            case Mode.Balanced:
                toPerformanceMode();
                break;
            case Mode.Performance:
                toTurboMode();
                break;
            case Mode.Turbo:
                break;
        }
    }

    public void ModeDown()
    {
        switch (currentMode)
        {
            case Mode.Quiet:
                break;
            case Mode.Balanced:
                toQuietMode(); 
                break;
            case Mode.Performance:
                toBalancedMode();
                break;
            case Mode.Turbo:
                toPerformanceMode();
                break;
        }
    }

    public void TurboShortcut()
    {
        if (currentMode == Mode.Turbo)
        {
            toQuietMode();
        }
        else if (currentMode == Mode.Quiet) {
            toTurboMode();
        }
    }

    public void toQuietMode()
    {
        if (this.currentMode == Mode.Quiet)
        {
            Console.WriteLine("sudah dalam mode Quiet");
        }
        else if (this.currentMode == Mode.Turbo)
        {
            this.currentMode = Mode.Quiet;
            Console.WriteLine("Fan Turbo berubah menjadi Quiet");
        }
        else if (this.currentMode == Mode.Balanced)
        {
            this.currentMode = Mode.Quiet;
            Console.WriteLine("Fan Balanced berubah menjadi Quiet");
        }

    }

    public void toPerformanceMode() {
        if (this.currentMode == Mode.Performance)
        {
            Console.WriteLine("sudah dalam mode Performance");
        } else if (this.currentMode == Mode.Balanced)
        {
            this.currentMode= Mode.Performance;
            Console.WriteLine("Fan Balanced berubah menjadi Performance");
        } else if (this.currentMode== Mode.Turbo)
        {
            this.currentMode = Mode.Performance;
            Console.WriteLine("Fan Turbo berubah menjadi Performance");
        }
    }

    public void toBalancedMode()
    {
        if (this.currentMode == Mode.Balanced)
        {
            Console.WriteLine("sudah dalam mode Balanced");
        }
        else if (this.currentMode == Mode.Performance)
        {
            this.currentMode = Mode.Balanced;
            Console.WriteLine("Fan Performance berubah menjadi Balanced");
        }
        else if (this.currentMode == Mode.Quiet)
        {
            this.currentMode = Mode.Balanced;
            Console.WriteLine("Fan Quiet berubah menjadi Balanced");
        }
    }

    public void toTurboMode()
    {
        if (this.currentMode == Mode.Turbo)
        {
            Console.WriteLine("sudah dalam mode Turbo");
        }
        else if (this.currentMode == Mode.Quiet)
        {
            this.currentMode = Mode.Turbo;
            Console.WriteLine("Fan Quiet berubah menjadi Turbo");
        }
        else if (this.currentMode == Mode.Performance)
        {
            this.currentMode = Mode.Turbo;
            Console.WriteLine("Fan Performance berubah menjadi Turbo");
        }
    }


}

class Program
{
    static void Main()
    {
        KodeProduk kode = new KodeProduk();
        Console.WriteLine(kode.getKodeProduk("Tablet"));
        
        FanLaptop fanLaptop = new FanLaptop();
        fanLaptop.TurboShortcut();
        fanLaptop.TurboShortcut();
        fanLaptop.ModeUp();
        fanLaptop.ModeUp();
        fanLaptop.ModeUp();
        fanLaptop.ModeDown();
        fanLaptop.ModeDown();

        
    }
}
