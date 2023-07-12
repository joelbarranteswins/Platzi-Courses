namespace OpenClose;

public interface IEmployee
{
    public string Fullname { get; set; }
    public int HoursWorked { get; set; }
    public decimal CalculateSalaryMonthly();
}