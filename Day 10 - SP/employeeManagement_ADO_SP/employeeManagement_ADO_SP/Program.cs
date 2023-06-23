using employeeManagement_ADO_SP;

Console.WriteLine("Stored Procedure Execution - Employee Mangement APP");

Console.WriteLine("Press Enter to continue");
Console.ReadLine();



Console.WriteLine("1. Delete Employee Proc");
Console.WriteLine("2. Update Employee Proc");
Console.WriteLine("3. View Employee by ID Proc");
Console.WriteLine("4. View All Employee Proc");
Console.WriteLine("5. Add Employee Proc - Proc with output parameter");

string result = "";
int choice = Convert.ToInt32(Console.ReadLine());
Employee empObj = new Employee();
switch (choice)
{

	case 1:
		Console.WriteLine("Please Enter Employee Number to delete employee");
		int empNo_delete = Convert.ToInt32(Console.ReadLine());
		 result = empObj.proc_DeletEmployee(empNo_delete);
		Console.WriteLine(result);
		break;
	case 3:

		Console.WriteLine("Enter Employee Number to view details");
		int empno = Convert.ToInt32(Console.ReadLine());
		try
		{
            Employee emp =  empObj.proc_GetEmployeeById(empno);
			Console.WriteLine("Employee Number " + emp.empNo);
            Console.WriteLine("Employee Number " + emp.empName);
            Console.WriteLine("Employee Number " + emp.empDesignation);
            Console.WriteLine("Employee Number " + emp.empSalary);
            Console.WriteLine("Employee Number " + emp.empIsPermenant);
            

        }
		catch(Exception es)
		{
			Console.WriteLine(es.Message);
		}



		break;

	case 5:
		try
		{
			Console.WriteLine("Enter New Employee Name");
			string name = Console.ReadLine();
			Console.WriteLine("Enter New Employee Designation");
			string designation = Console.ReadLine();

			Console.WriteLine("Enter New Employee Salary");
			double salary = Convert.ToDouble(Console.ReadLine());

			//      Console.WriteLine("Enter New Employee Is permenat");
			//bool isPermenant = Convert.ToBoolean(Console.ReadLine());

			result = empObj.proc_AddEmployee(name, designation, salary, true);
			Console.WriteLine(result);
		}
		catch (Exception es) { Console.WriteLine(es.Message); }
		
		break;

    default:
		break;
}