using DesignPatterns.BuilderPattern.Method1;
using DesignPatterns.BuilderPattern.Method2;
using System.Text;

var sb = new StringBuilder();

sb.Append("Tufan").Append(" ").Append("Ayhan");

var fName = sb.ToString();

var eb = new EndpointBuilder("https://localhost");

eb.Append("api")
    .Append("v1")
    .Append("user")
    .AppendParam("id", "5")
    .AppendParam("username", "ayhan");

var url = eb.Build();

//Console.WriteLine("Final URl: " + url);

var empBuilder = new EmployeeBuilderM1();

var employee = empBuilder
    .SetFullName("Ömer Tufan Ayhan")
    .SetUserName("omertufanayhan")
    .SetEmailAddress("omertufan@gmail.com")
    .BuildEmployee();

//Console.WriteLine("M1 employee Firstname: " + employee.FirstName);

IEmployeeBuilderM2 employeeBuilder = new InternalEmployeeBuilder(); //dependency injection

employeeBuilder.SetEmailAddress("omertufan@gmail.com");
employeeBuilder.SetFullName("omer tufan ayhan");

var emp = employeeBuilder.BuildEmployee();

// Console.WriteLine("M1 employee emailaddress: " + emp.EmailAddress);

var emp = GenerateEmployee("omer tufan ayhan", "omertufanayhan@gmail.com", 0);
System.Console.WriteLine("Email Address: " + emp.EmailAddress);

EmployeeM2 GenerateEmployee(string fullName, string emailAddress, int empType)
{
    IEmployeeBuilderM2 employeeBuilder;
    if (empType == 0)
        employeeBuilder = new InternalEmployeeBuilder();
    else
        employeeBuilder = new ExternalEmployeeBuilder();

    employeeBuilder.SetFullName(fullName);
    employeeBuilder.SetEmailAddress(emailAddress);

    return employeeBuilder.BuildEmployee();
}