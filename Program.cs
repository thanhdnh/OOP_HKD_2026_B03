public class Human
{
    private string name;
    private DateTime birthday;
    private bool gender;
    public Human(string name, DateTime birthday, bool gender)
    {
        this.name = name;
        this.birthday = birthday;
        this.gender = gender;
    }
    public string GetInfos()
    {
        return $"Ten: {name}, Sinh nam: {birthday}, Gioi tinh: {(gender ? "Nam" : "Nu")}";
    }
}
public class Employee : Human
{
    private string id;
    private float salarycoef;
    private DateTime participationdate;
    public Employee(string name, DateTime birthday, bool gender, string id, float salarycoef, DateTime participationdate) : base(name, birthday, gender)
    {
        this.id = id;
        this.salarycoef = salarycoef;
        this.participationdate = participationdate;
    }
    public string GetInfos()
    {
        return $"ID: {id}, " + base.GetInfos() + $", Salary Coef: {salarycoef}, Participation date: {participationdate}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        /*Human h = new Human("Nam", new DateTime(1990, 4, 5), true);
        Employee emp = new Employee("Hoa", new DateTime(1992, 5, 7), false, "EMP001", 4.5f, new DateTime(2019, 4, 3));
        Console.WriteLine(h.GetInfos());
        Console.WriteLine(emp.GetInfos());*/

        Shape rec = new Rectangle(3, 4);
        //rec.ShowInfo();

        Shape round = new Round(3);
        Console.WriteLine($"Chu vi HCN: {rec.TinhChuVi()}");
        Console.WriteLine($"Dien tich HCN: {rec.TinhDienTich()}");
        Console.WriteLine($"Chu vi HT: {round.TinhChuVi()}");
        Console.WriteLine($"Dien tich HT: {round.TinhDienTich()}");

    }
}

public abstract class Shape
{
    public abstract float TinhChuVi();
    public abstract float TinhDienTich();
}
public class Rectangle : Shape
{
    private float w, h;
    public Rectangle(float w, float h)
    {
        this.w = w;
        this.h = h;
    }
    public override float TinhChuVi()
    {
        return 2 * (w + h);
    }

    public override float TinhDienTich()
    {
        return w * h;
    }
    public string ShowInfo()
    {
        return "Rectangle";
    }
}
public class Round : Shape
{
    private float R;
    public Round(float R)
    {
        this.R = R;
    }
    public override float TinhChuVi()
    {
        return 2*(float)Math.PI*R;
    }

    public override float TinhDienTich()
    {
        return (float)Math.PI*R*R;
    }
}