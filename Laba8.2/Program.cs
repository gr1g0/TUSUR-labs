try
{
    Money tri = new();
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
public abstract class AnothaMoney
{

    public double many;
    public double notMy;
     public AnothaMoney()
    {
        Console.WriteLine("Введите Сколько у вас денег");
        this.many = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите Сколько денег у вашего соседа (у соседа должно быть меньше денег)");
        this.notMy = double.Parse(Console.ReadLine());
    }
    public void Check()
    {
        if (many < notMy)
        {
            Console.WriteLine("У соседа больше денег(((");
        }
        else if (many > notMy)
        {
            Console.WriteLine("У вас больше денег)))");
        }
        else if (many == notMy)
        {
            Console.WriteLine("У вас по ровну денег(ненадолго))))");
        }
    }
}
public class Money : AnothaMoney, InterfaceMoney
{
    public void Sum()
    {
        double f3 = many+notMy;
        int k5000 = Convert.ToInt32(f3/5000);
        int k1000 = Convert.ToInt32((f3%5000)/1000);
        int k500 = Convert.ToInt32((f3%1000)/500);
        int k100 = Convert.ToInt32((f3%500)/100);
        int k50 = Convert.ToInt32((f3%100)/50);
        int k10 = Convert.ToInt32((f3%50)/10);
        int k5 = Convert.ToInt32((f3%10)/5);
        int k2 = Convert.ToInt32((f3%5)/2);
        int k1 = Convert.ToInt32(((f3%5)%2)/1);
        int l50 = Convert.ToInt32((f3%1)/0.5);
        int l10 = Convert.ToInt32((f3%0.5)/0.1);
        int l5 = Convert.ToInt32((f3%0.1)/0.05);
        int l1 = Convert.ToInt32((f3%0.05)/0.01);
        Console.WriteLine($"Если б вы украли деньги соседа, у вас было бы в рублях: {k5000} 5000; {k1000} 1000; {k500} 500; {k100} 100; {k50} 50; {k10} 10; {k5} 5; {k1} 1; а копеек: {l50} 50; {l10} 10; {l5} 5; {l1} 1;");
    }
    public void Minus()
    {
        double f3 = many-notMy;
        int k5000 = Convert.ToInt32(f3/5000);
        int k1000 = Convert.ToInt32((f3%5000)/1000);
        int k500 = Convert.ToInt32((f3%1000)/500);
        int k100 = Convert.ToInt32((f3%500)/100);
        int k50 = Convert.ToInt32((f3%100)/50);
        int k10 = Convert.ToInt32((f3%50)/10);
        int k5 = Convert.ToInt32((f3%10)/5);
        int k2 = Convert.ToInt32((f3%5)/2);
        int k1 = Convert.ToInt32(((f3%5)%2)/1);
        int l50 = Convert.ToInt32((f3%1)/0.5);
        int l10 = Convert.ToInt32((f3%0.5)/0.1);
        int l5 = Convert.ToInt32((f3%0.1)/0.05);
        int l1 = Convert.ToInt32((f3%0.05)/0.01);
        Console.WriteLine($"Если б вдруг оказалось, что деньги соседа - это украденные ваши, у вас бы осталось в рублях: {k5000} 5000; {k1000} 1000; {k500} 500; {k100} 100; {k50} 50; {k10} 10; {k5} 5; {k1} 1; а копеек: {l50} 50; {l10} 10; {l5} 5; {l1} 1;");
    }
    public void Mult()
    {
        double f3 = many*notMy;
        int k5000 = Convert.ToInt32(f3/5000);
        int k1000 = Convert.ToInt32((f3%5000)/1000);
        int k500 = Convert.ToInt32((f3%1000)/500);
        int k100 = Convert.ToInt32((f3%500)/100);
        int k50 = Convert.ToInt32((f3%100)/50);
        int k10 = Convert.ToInt32((f3%50)/10);
        int k5 = Convert.ToInt32((f3%10)/5);
        int k2 = Convert.ToInt32((f3%5)/2);
        int k1 = Convert.ToInt32(((f3%5)%2)/1);
        int l50 = Convert.ToInt32((f3%1)/0.5);
        int l10 = Convert.ToInt32((f3%0.5)/0.1);
        int l5 = Convert.ToInt32((f3%0.1)/0.05);
        int l1 = Convert.ToInt32((f3%0.05)/0.01);
        Console.WriteLine($"Если по какой то причине вы умножите деньги соседа на свои, то у вас будет в рублях: {k5000} 5000; {k1000} 1000; {k500} 500; {k100} 100; {k50} 50; {k10} 10; {k5} 5; {k1} 1; а копеек: {l50} 50; {l10} 10; {l5} 5; {l1} 1;");
    }
    public void Del()
    {
        double f3 = many/notMy;
        int k5000 = Convert.ToInt32(f3/5000);
        int k1000 = Convert.ToInt32((f3%5000)/1000);
        int k500 = Convert.ToInt32((f3%1000)/500);
        int k100 = Convert.ToInt32((f3%500)/100);
        int k50 = Convert.ToInt32((f3%100)/50);
        int k10 = Convert.ToInt32((f3%50)/10);
        int k5 = Convert.ToInt32((f3%10)/5);
        int k2 = Convert.ToInt32((f3%5)/2);
        int k1 = Convert.ToInt32(((f3%5)%2)/1);
        int l50 = Convert.ToInt32((f3%1)/0.5);
        int l10 = Convert.ToInt32((f3%0.5)/0.1);
        int l5 = Convert.ToInt32((f3%0.1)/0.05);
        int l1 = Convert.ToInt32((f3%0.05)/0.01);
        Console.WriteLine($"Если по какой то причине вы поделите свои деньги на деньги соседа, то у вас останется в рублях: {k5000} 5000; {k1000} 1000; {k500} 500; {k100} 100; {k50} 50; {k10} 10; {k5} 5; {k1} 1; а копеек: {l50} 50; {l10} 10; {l5} 5; {l1} 1;");
    }
    ~Money()
    {
        Console.WriteLine("Класс Деструктуризирован");
    }
}
public interface InterfaceMoney
{
    void Sum();
    void Check();
}