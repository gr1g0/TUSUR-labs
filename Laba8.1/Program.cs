try
{
    EngMer tri = new();
    tri.Check();
    tri.Sum();
    tri.Minus();
    tri.Mult();
    tri.Del();  
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
public abstract class GeneralEngMer
{

    public double f1;
    public double d1;
    public double f2;
    public double d2;
     public GeneralEngMer()
    {
        Console.WriteLine("Введите Футы первой длины");
        this.f1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите Дюймы первой длины");
        this.d1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите Футы второй длины");
        this.f2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите Дюймы второй длины");
        this.d2 = double.Parse(Console.ReadLine());
    }
    public void Check()
    {
        if ((f1 < f2) || ((f1 == f2) & (d1 < d2)))
        {
            Console.WriteLine("Вторая длина больше первой");
        }
        else if ((f1 > f2) || ((f1 == f2) & (d1 > d2)))
        {
            Console.WriteLine("Первая длина больше второй");
        }
        else if ((f1 == f2) & (d1 == d2))
        {
            Console.WriteLine("Длины равны");
        }
    }
}
public class EngMer : GeneralEngMer, InterfaceEngMer
{
    public void Sum()
    {
        double f3 = f1+f2;
        double d3 = d1+d2;
        if (d3>=12)
        {
            d3-=12;
            f3++;
        }
        Console.WriteLine($"Сумма длин равна: {f3}`{d3}");
    }
    public void Minus()
    {
        double f3 = Math.Abs(f1-f2);
        double d3 = Math.Abs(d1-d2);
        if (d3>=12)
        {
            d3-=12;
            f3++;
        }
        Console.WriteLine($"Разница длин равна: {f3}`{d3}");
    }
    public void Mult()
    {
        double f3 = f1*f2;
        double d3 = d1*d2;
        while (d3>=12)
        {
            d3-=12;
            f3++;
        }
        Console.WriteLine($"Произведение длин равно: {f3}`{d3}");
    }
    public void Del()
    {
        double f3 = f1/f2;
        double d3 = d1/d2;
        Console.WriteLine($"Частное длин равно: {f3}`{d3}");
    }
    ~EngMer()
    {
        Console.WriteLine("Класс Деструктуризирован");
    }
}
public interface InterfaceEngMer
{
    void Sum();
    void Check();
}