internal class Program
{
    private static void Main(string[] args)
    {
        ex1_1();
        ex1_2();
        ex1_3();
        ex2_1();
        ex2_2();
        ex2_3();
        ex2_4();
        ex2_5();
    }
    static void ex1_1()
    {
        Console.Write("Nhap do C can doi: ");
        double doC = 0;
        while (!double.TryParse(Console.ReadLine(), out doC))
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        double doF = (doC * 9 / 5) + 32;
        double doK = doC + 273.15;
        Console.WriteLine($"Do F: {doF}");
        Console.WriteLine($"Do K: {doK}");
    }
    static void ex1_2()
    {
        Console.Write("Nhap ban kinh hinh cau: ");
        double r = 0;
        while (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        double V = (4 / 3) * Math.PI * Math.Pow(r, 3);
        double S = 4 * Math.PI * Math.Pow(r, 2);
        Console.WriteLine($"The tich hinh cau: {V}");
        Console.WriteLine($"Dien tich hinh cau: {S}");
    }
    static void ex1_3()
    {
        Console.Write("Nhap so a: ");
        double a = 0;
        double b = 0;
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        Console.Write("Nhap so b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        Console.WriteLine($"""
        Tong = {a + b}
        Hieu = {a - b}
        Tich = {a * b}
        Thuong = {(b != 0 ? a / b : "Khong the chia cho 0")}
        Chia lay phan du = {(b != 0 ? a % b : "Khong the chia cho 0")}
        """);
    }
    static void ex2_1()
    {
        Console.Write("Nhap so a: ");
        double a = 0;
        double b = 0;
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        Console.Write("Nhap so b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        Console.WriteLine($"""
        Tong = {a + b}
        Hieu = {a - b}
        Tich = {a * b}
        Thuong = {(b != 0 ? a / b : "Khong the chia cho 0")}
        Chia lay phan du = {(b != 0 ? a % b : "Khong the chia cho 0")}
        """);
    }
    static void ex2_2()
    {
        Console.WriteLine("Cac gia tri cua ham x = y^2 + 2y + 1");
        Console.WriteLine("   y | x");
        Console.WriteLine(" --- | ---");
        for (int y = -5; y <= 5; y++)
        {
            int x = (y * y) + 2 * y + 1;
            Console.WriteLine($"  {y,2} | {x}");
        }
    }
    static void ex2_3()
    {
        Console.Write("Nhap quang duong di duoc:");
        double s = 0;
        while (!double.TryParse(Console.ReadLine(), out s) || s <= 0)
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        double t = 0;
        double gio  = 0;
        double phut = 0;    
        double giay = 0;
        Console.Write("Nhap tong so gio di chuyen: ");
        while (!double.TryParse(Console.ReadLine(), out gio) || gio < 0)
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        Console.Write("So phut di chuyen (<60): ");
        while (!double.TryParse(Console.ReadLine(), out phut) || phut < 0 || phut >=60)
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        Console.Write("So giay di chuyen (<60): ");
        while (!double.TryParse(Console.ReadLine(), out giay) || giay < 0 || giay >=60)
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        if(gio ==0 && phut == 0 && giay == 0)
        {
            Console.WriteLine("Khong the tinh van toc voi thoi gian bang 0");
            return;
        }
        t = gio + (phut / 60) + (giay / 3600);
        double v = s / t;
        Console.WriteLine($"Van toc la: {v} km/h  =  {v * 0.621371} miles/h ");
    }
    static void ex2_4()
    {
        Console.Write("Nhap ban kinh hinh cau: ");
        double r = 0;
        while (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        double V = (4 / 3) * Math.PI * Math.Pow(r, 3);
        double S = 4 * Math.PI * Math.Pow(r, 2);
        Console.WriteLine($"The tich hinh cau: {V}");
        Console.WriteLine($"Dien tich hinh cau: {S}");
    }
    static void ex2_5()
    {
        Console.Write("Hay nhap vao ban phim mot ky tu bat ky: ");
        char kytu;
        kytu = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (char.IsLetter(kytu))
        {
            if(kytu == 'a' || kytu == 'e' || kytu == 'i' || kytu == 'o' || kytu == 'u')
            {
                Console.WriteLine($"{kytu} la mot nguyen am");
            }
            else
            {
                Console.WriteLine($"{kytu} la mot phu am");
            }
        }
        else if (char.IsDigit(kytu))
        {
            Console.WriteLine($"{kytu} la mot con so");
        }
        else
        {
            Console.WriteLine($"{kytu} la mot ky tu dac biet");
        }
    }
}
