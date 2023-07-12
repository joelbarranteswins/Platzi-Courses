namespace Liskov
{
    public class EmployeeFullTime : Employee
    {
        public int ExtraHours {get;set;}
        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked)
        {
            ExtraHours = extrahours;
        }

        public override decimal CalculateSalary()
        {   
            decimal hourValue = 50;
            return hourValue * (HoursWorked + ExtraHours);
        } 
    }
}