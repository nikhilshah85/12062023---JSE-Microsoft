using employeeManagementAPP_ADONet;

Console.WriteLine("~~~~~~~~~ !! Employee Management !! ~~~~~~~~~~~~~`");

Console.WriteLine("Press Enter To Continue");
Console.ReadLine();

Console.WriteLine("1. Add New Employee");
Console.WriteLine("2. Delete Employee");
Console.WriteLine("3. Update Employee");
Console.WriteLine("4. View Employee Detail");
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

    case 3: 
        break;
    default:
		break;
}