internal class Program
{

    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract decimal CalculatePay(); // Abstract method

        public virtual string GetEmployeeDetails() // Virtual method
        {
            return $"{FirstName} {LastName}";
        }

        public sealed override string ToString() // Sealed method
        {
            return GetEmployeeDetails();
        }
    }
}



