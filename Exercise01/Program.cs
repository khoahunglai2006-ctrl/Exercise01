using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        ex01();
        ex02();
        ex03();
        ex04();
        ex05();
        ex06();
        ex07();
        ex08();
        ex09();
        ex10();
    }
    /// <summary>
    /// Tính tổng 2 số nguyên a và b
    /// </summary>
    static void ex01()
    {
        Console.WriteLine("Tinh tong a va b");
        Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        int b = Convert.ToInt32(Console.ReadLine());
        tong(a, b);
    }
    static void tong(int a, int b)
    {
        int c = a + b;
        Console.WriteLine($"a + b = {c}");
    }
    /// <sumary>
    /// Đổi chỗ hai biến a và b
    /// </sumary>
    static void ex02()
    {
        Console.WriteLine("Doi cho a va b");
        Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        int b = Convert.ToInt32(Console.ReadLine());
        int doi = a;
        a = b;
        b = doi;
        Console.WriteLine($"Gia tri cua a va b sau khi doi: a = {a}; b = {b}");
    }
    static void ex03()
    {
        Console.WriteLine("Tich 2 so thuc a va b");
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        double c = a * b;
        Console.WriteLine($"a x b = {c}");
    }
    static void ex04()
    {
        Console.WriteLine("Doi feet sang met");
        Console.Write("feet = ");
        double feet = Convert.ToDouble(Console.ReadLine());
        double m = 0.3048 * feet;
        Console.WriteLine($"m = {m}");
    }
    static void ex05()
    {
        Console.WriteLine("Doi do C sang do F va nguoc lai");
        Console.WriteLine("Nhap 1 de doi C sang F");
        Console.WriteLine("Nhap 2 de doi F sang C");
        int a = Convert.ToInt32(Console.ReadLine());
        double C = 0;
        double F = 0;
        if (a == 1)
        {
            Console.Write("C = ");
            C = Convert.ToDouble(Console.ReadLine());
            F = C * 9 / 5 + 32;
            Console.WriteLine($"F = {F}");
        }
        else
        {
            Console.Write("F = ");
            F = Convert.ToDouble(Console.ReadLine());
            C = (F - 32) * 5 / 9;
            Console.WriteLine($"C = {C}");
        }
    }
    static void ex06()
    {
        Console.WriteLine("Kiem tra kich thuoc kieu du lieu");
        Console.WriteLine("Kich thuoc la " + sizeof(int));
    }
    static void ex07()
    {
        Console.WriteLine("Ky tu can chuyen la");
        char chu = Convert.ToChar(Console.ReadLine());
        int ascii = (int)chu;
        Console.WriteLine($"Ma ASCII cua ky tu '{chu}' la {ascii}");
    }
    static void ex08()
    {
        Console.WriteLine("Nhap ban kinh hinh tron");
        double r = double.Parse(Console.ReadLine());
        double dienTich = Math.PI * r * r;
        Console.WriteLine($"Dien tich hinh tron co ban kinh {r} la {dienTich}");
    }
    static void ex09()
    {
        Console.WriteLine("Nhap canh hinh vuong");
        double canh = double.Parse(Console.ReadLine());
        double dienTich = canh * canh;
        Console.WriteLine($"Dien tich hinh vuong co canh {canh} la {dienTich}");
    }
    static void ex10()
    {
        Console.WriteLine("Nhap ngay thang nam");
        DateTime a= DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"Ngay la {a.Day}, thang la {a.Month}, nam la {a.Year}");
    }
}