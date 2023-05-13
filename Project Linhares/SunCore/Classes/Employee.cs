namespace SunCore.Classes
{
    public class Employee : Person
    {
        public virtual int Temp { get; set; } //0: não, 1: sim
        public virtual string Job { get; set; }
        public virtual string HiringDate { get; set; }
        public virtual string Salary { get; set; }
        public virtual string DayOfWork { get; set; }
        public virtual string TimeOfWork { get; set; }
        public virtual string Vacation { get; set; }
        public virtual string SalaryObservation { get; set; }
    }
}
