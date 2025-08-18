internal class Program
{
    private static void Main(string[] args)
    {
        ex01();
        ex02();
        ex03();
    }
    static void ex01()
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
    static void ex02()
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
    static void ex03()
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

}