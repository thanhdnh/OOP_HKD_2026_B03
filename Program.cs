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
        return $"Ten: {name}, Sinh nam: {birthday}, Gioi tinh: {(gender?"Nam":"Nu")}";
    }
}
public class Employee:Human{
    private string id;
    private float salarycoef;
    private DateTime participationdate;
    public Employee(string name, DateTime birthday, bool gender, string id, float salarycoef, DateTime participationdate):base(name, birthday, gender){
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
    Human h = new Human("Nam", new DateTime(), true);
    Employee emp = new Employee("Hoa", new DateTime(), false, "EMP001", 4.5f, new DateTime());
    Console.WriteLine(h.GetInfos());
    Console.WriteLine(emp.GetInfos());
  }
}