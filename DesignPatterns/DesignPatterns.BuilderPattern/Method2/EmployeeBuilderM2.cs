namespace DesignPatterns.BuilderPattern.Method2
{
    public interface IEmployeeBuilderM2
    {
        void SetFullName(string fullName);

        void SetUserName(string userName);

        void SetEmailAddress(string emailAddress);

        EmployeeM2 BuildEmployee();
    }

    public abstract class EmployeeBuilderM2 : IEmployeeBuilderM2
    {
        public EmployeeM2 Employee { get; set; }

        protected EmployeeBuilderM2()
        {
            Employee = new EmployeeM2();
        }

        public abstract void SetFullName(string fullName);

        public abstract void SetUserName(string userName);

        public abstract void SetEmailAddress(string emailAddress);

        public EmployeeM2 BuildEmployee() => Employee;
    }
}