

using collection_demo;
using System.Collections;

#region Array


#region String Array

//string name = "Nikhil";
//name = "Karan"; //this will override the first value, we will have to create 2 variables for storing both the values
//thus we can use a syntax which will store multiple values in a single varaiable
//string[] friends = new string[5];

//friends[0] = "Kriti";
//friends[1] = "Mohini";
//friends[2] = "Akshay";
//friends[3] = "Ramesh";
//friends[4] = "Suresh";

//Console.WriteLine(friends[3]);


//for (int i = 0; i < friends.Length; i++)
//{
//    Console.WriteLine("Enter Friend No " + (i+1));
//    friends[i] = Console.ReadLine();
//}

//Console.WriteLine("Press Enter To display all the friends");
//Console.ReadLine();

//for (int i = 0; i < friends.Length; i++)
//{
//    Console.WriteLine(friends[i]);
//}
#endregion


#region Int Array
//int[] numbers = new int[20];
//int positivenumbers = 0;
//int negativeNumber = 0;
//int eveninNumbers = 0;
//int oddNumbers = 0;
//int total_of_numbers = 0;


//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("Enter Number " + (i + 1));
//    int userValue = Convert.ToInt32(Console.ReadLine());
//    numbers[i] = userValue;


//    if (userValue < 0)
//    {
//        negativeNumber = negativeNumber + 1;
//    }
//    else
//    {
//        positivenumbers = positivenumbers + 1;
//    }
//    if (userValue % 2 == 0)
//    {
//        eveninNumbers = eveninNumbers + 1;
//    }
//    else
//    {
//        oddNumbers = oddNumbers + 1;
//    }
//    total_of_numbers = total_of_numbers + userValue;

//}

//Console.WriteLine("Thank You, press enter to view the summary");
//Console.ReadLine();
//Console.Clear();

//Console.WriteLine("Total Of All Numbers " + total_of_numbers);
//Console.WriteLine("Even  Numbers : " + eveninNumbers);
//Console.WriteLine("Odd  Numbers : " + oddNumbers);
//Console.WriteLine("Positive  Numbers : " + positivenumbers);
//Console.WriteLine("Negative  Numbers : " + negativeNumber);


#endregion

#endregion

#region ArrayList

//ArrayList mylist = new ArrayList();

//Console.WriteLine("Enter Any Value");


//mylist.Add(10);
//mylist.Add("Twenty");
//mylist.Add(29.88);
//mylist.Add(true);
//mylist.Add("Hello"); 
//mylist.Add(30);
//mylist.Add(10);
//mylist.Add(90);
//mylist.Add(10);
//mylist.Add(10);
//mylist.Add(false);
//mylist.Add(new { firstName = "nikhil", lastName = "Shah" });


//foreach (var item in mylist)
//{
//    Console.WriteLine(item);
//}



#endregion

#region List

#region List of String

//List<string> myFriends = new List<string>(); //this does not need a size, but data type has to be followed


//myFriends.Add("Rishi");
//myFriends.Add("Sumit");
//myFriends.Add("Raashi");
//myFriends.Add("Mahesh");
//myFriends.Add("Maahi");

//foreach (var item in myFriends)
//{
//    Console.WriteLine(item);
//}

#endregion


#region List of Employee

//List<Employee> eList = new List<Employee>();

//eList.Add(new Employee() { empNo = 101, empName = "Karan", empDesignation = "Sales", empIsPermenant = true, empSalary = 5000 });
//eList.Add(new Employee() { empNo = 102, empName = "Nikhil", empDesignation = "Consultant", empIsPermenant = true, empSalary = 5000 });
//eList.Add(new Employee() { empNo = 103, empName = "Rohan", empDesignation = "Sales", empIsPermenant = true, empSalary = 5000 });
//eList.Add(new Employee() { empNo = 104, empName = "Mohan", empDesignation = "Consultant", empIsPermenant = false, empSalary = 5000 });
//eList.Add(new Employee() { empNo = 105, empName = "Sohan", empDesignation = "Sales", empIsPermenant = true, empSalary = 5000 });
//eList.Add(new Employee() { empNo = 106, empName = "Amit", empDesignation = "Sales", empIsPermenant = true, empSalary = 5400 });
//eList.Add(new Employee() { empNo = 107, empName = "Sumit", empDesignation = "Sales", empIsPermenant = true, empSalary = 1200 });
//eList.Add(new Employee() { empNo = 108, empName = "Priya", empDesignation = "Consultant", empIsPermenant = true, empSalary = 5000 });
//eList.Add(new Employee() { empNo = 109, empName = "Riya", empDesignation = "Sales", empIsPermenant = false, empSalary = 5000 });
//eList.Add(new Employee() { empNo = 110, empName = "Jiya", empDesignation = "Sales", empIsPermenant = true, empSalary = 5000 });
//eList.Add(new Employee() { empNo = 111, empName = "Dia", empDesignation = "Consultant", empIsPermenant = true, empSalary = 5000 });

//int total = 0;
//double totalSalary = 0;
//int totalPermenant = 0;
//int totalContract = 0;
//int totalSales = 0;
//int totalConsultatnt = 0;
//foreach (var item in eList)
//{
//	#region collect Sumamry
//	totalSalary = totalSalary + item.empSalary;
//	total = total + 1;

//	if (item.empIsPermenant)
//	{
//		totalPermenant = totalPermenant + 1;
//	}
//	else
//	{
//		totalContract = totalContract + 1;
//	}

//	if (item.empDesignation == "Sales")
//	{
//		totalSales = totalSales + 1;
//	}
//	else
//	{
//		totalConsultatnt = totalConsultatnt + 1;
//	}
//	#endregion

//	Console.WriteLine("Empployee Number " + item.empNo);
//    Console.WriteLine("Empployee Name " + item.empName);
//    Console.WriteLine("Empployee Designation " + item.empDesignation);
//    Console.WriteLine("Empployee Salary " + item.empSalary);
//    Console.WriteLine("Empployee is Permemant " + item.empIsPermenant);

//	Console.WriteLine("-------------------------------------------------------------");

//}

//Console.WriteLine("Total Employee : " + total + " | Salary : " + totalSalary + " | Permenant  " + totalPermenant);

#endregion


#region Hashtable

//Hashtable eList = new Hashtable();
//eList.Add(10, "Nikhil");
//eList.Add(20, "Nikhil");
//eList.Add(30, "Sumit");

//Employee emp = new Employee() { empNo = 101, empName = "Sahil", empDesignation = "sales", empIsPermenant = true, empSalary = 5000 };
//eList.Add(emp.empNo, emp);
//eList.Add("Twenty", 50);

#endregion


//key has to be unique

Dictionary<int, Employee> eDictionalry = new Dictionary<int, Employee>();

eDictionalry.Add(101, new Employee() { empNo = 101, empName = "Sahil", empDesignation = "Sales", empIsPermenant = true, empSalary = 5000 });
eDictionalry.Add(102, new Employee() { empNo = 101, empName = "Sahil", empDesignation = "Sales", empIsPermenant = true, empSalary = 5000 });
eDictionalry.Add(103, new Employee() { empNo = 101, empName = "Sahil", empDesignation = "Sales", empIsPermenant = true, empSalary = 5000 });
eDictionalry.Add(104, new Employee() { empNo = 101, empName = "Sahil", empDesignation = "Sales", empIsPermenant = true, empSalary = 5000 });
eDictionalry.Add(105, new Employee() { empNo = 101, empName = "Sahil", empDesignation = "Sales", empIsPermenant = true, empSalary = 5000 });
eDictionalry.Add(106, new Employee() { empNo = 101, empName = "Sahil", empDesignation = "Sales", empIsPermenant = true, empSalary = 5000 });
eDictionalry.Add(107, new Employee() { empNo = 101, empName = "Sahil", empDesignation = "Sales", empIsPermenant = true, empSalary = 5000 });

foreach (var item in eDictionalry)
{
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value.empName);
}





#endregion