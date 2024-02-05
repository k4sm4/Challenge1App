using Challenge1App;

Employee employee1 = new Employee("Adam","Kowalski","29");
Employee employee2 = new Employee("Marek","Kowalski","40");
Employee employee3 = new Employee("Marita","Kowalska","35");

employee1.AddScore(7);
employee1.AddScore(6);
employee1.AddScore(8);
employee1.AddScore(3);
employee1.AddScore(4);

employee2.AddScore(5);
employee2.AddScore(6);
employee2.AddScore(9);
employee2.AddScore(5);
employee2.AddScore(2);

employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(10);
employee3.AddScore(1);
employee3.AddScore(5);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};
int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("User with the highest result ");
Console.WriteLine();
Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + employeeWithMaxResult.Age + " - with resoult of " + employeeWithMaxResult.Result);


Console.ReadLine();