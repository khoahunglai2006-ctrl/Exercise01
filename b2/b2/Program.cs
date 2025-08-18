internal class Program
{
    private static void Main(string[] args)
    {
        ex01();
        ex02();
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
        while(!double.TryParse(Console.ReadLine(), out r) || r <= 0)
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        double V = (4 / 3) * Math.PI * Math.Pow(r, 3);
        double S = 4 * Math.PI * Math.Pow(r, 2);
        Console.WriteLine($"The tich hinh cau: {V}");
        Console.WriteLine($"Dien tich hinh cau: {S}");
    }
}