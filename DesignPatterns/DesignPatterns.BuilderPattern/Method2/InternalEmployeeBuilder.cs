namespace DesignPatterns.BuilderPattern.Method2
{
    public class InternalEmployeeBuilder : EmployeeBuilderM2
    {
        public override void SetFullName(string fullName)
        {
            var arr = fullName.Split(new[] { ' ', '_', '.' });

            Employee.FirstName = arr[0];
            Employee.LastName = arr[arr.Length - 1];
        }

        public override void SetUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public override void SetEmailAddress(string emailAddress)
        {
            // omertufan@gmail.com
            var arr = emailAddress.Split('@');
            // ends with @company.com.tr

            Employee.EmailAddress = arr[0] + "@company.com.tr";
        }
    }
}