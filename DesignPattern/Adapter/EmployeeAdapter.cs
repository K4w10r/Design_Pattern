// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                employees.Add(new Employee(
                    int.Parse(employeesArray[i, 0]),
                    employeesArray[i, 1],
                    employeesArray[i,2],
                    decimal.Parse(employeesArray[i,3])
                    ));
            }
            thirdPartyBillingSystem.ProcessSalary(employees);
        }
    }
}
