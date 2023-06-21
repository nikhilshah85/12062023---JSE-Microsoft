using employeeManagementAPP_ADONet;
using System.Data.SqlClient;

Console.WriteLine("~~~~~~~~~ !! Employee Management !! ~~~~~~~~~~~~~`");

Console.WriteLine("Press Enter To Continue");
Console.ReadLine();

Console.WriteLine("1. Add New Employee");
Console.WriteLine("2. Delete Employee");
Console.WriteLine("3. Update Employee");
Console.WriteLine("4. View Employee Detail by Id");
Console.WriteLine("5. View All Employee");

int choice = Convert.ToInt32(Console.ReadLine());
Employee empObj = new Employee();

switch (choice)
{
    #region Case 1 : Add New Employee
    case 1:
		Console.WriteLine("Enter Employee Number");
        int no = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Employee Name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Employee Designation");
        string designation = Console.ReadLine();

        Console.WriteLine("Enter Employee Salary");
        int salary = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Employee Is Permenant");
        bool ispermenant = Convert.ToBoolean(Console.ReadLine());

        string result = empObj.AddNewEmployee(no, name, designation, salary, ispermenant);
        Console.WriteLine(result);

        break;
    #endregion

    #region Case 2: Delete Employee
    case 2:
        Console.WriteLine("Please Enter Employee Number to delete employee");
        int empNo = Convert.ToInt32(Console.ReadLine());
        string deleteResult = empObj.DeleteEmployee(empNo);
        Console.WriteLine(deleteResult);
        break;
    #endregion

    #region Case 3: Update Employee
    case 3:
        Console.WriteLine("Task");
        break;
    #endregion

    #region Case 4: Get Employee By Id
    case 4:
        Console.WriteLine("Please enter emp no to view details");
        int eno = Convert.ToInt32(Console.ReadLine());

        try
        {
            Employee details = empObj.GetEmpById(eno);
            Console.WriteLine("Employee Number : " + details.empNo);
            Console.WriteLine("Employee Name : " + details.empName);
            Console.WriteLine("Employee Designation : " + details.empDesignation);
            Console.WriteLine("Employee Salary : " + details.empSalary);
            Console.WriteLine("Employee Is Permenant : " + details.empIsPermenant);

        }
        catch(Exception es)
        {
            Console.WriteLine(es.Message);
        }

        break;
    #endregion

    #region Case 5: View All Employees
    case 5:
        List<Employee> alldetails = empObj.GetAllEmployees();

        foreach (var item in alldetails)
        {
            Console.WriteLine("Employee Number : " + item.empNo);
            Console.WriteLine("Employee Name : " + item.empName);
            Console.WriteLine("Employee Designation : " + item.empDesignation);
            Console.WriteLine("Employee Salary : " + item.empSalary);
            Console.WriteLine("Employee Is Permenant : " + item.empIsPermenant);
            Console.WriteLine(" -----------------------------------------------------");
        }
       
        break;
    #endregion

    default:
		break;
}