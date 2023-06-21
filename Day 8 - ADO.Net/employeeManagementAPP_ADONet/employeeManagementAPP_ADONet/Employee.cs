using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace employeeManagementAPP_ADONet
{
    internal class Employee
    {


        #region Properties

        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }

        #endregion

        SqlConnection con = new SqlConnection("server=(localdb)\\ProjectModels;database=employeeManagement;integrated security=true");



        public Employee GetEmpById(int p_empNo)
        {
            SqlCommand cmd_getEmpByid = new SqlCommand("select * from employeeDetails where empNo =@eNo", con);
            cmd_getEmpByid.Parameters.AddWithValue("eNo", p_empNo);
            SqlDataReader readEmp = null;

            try
            {
                con.Open();
                readEmp = cmd_getEmpByid.ExecuteReader();
                if (readEmp.Read())
                {
                    Employee emp = new Employee();
                    emp.empNo =Convert.ToInt32(readEmp[0]);
                    emp.empName = readEmp[1].ToString();
                    emp.empDesignation = readEmp[2].ToString();
                    emp.empSalary = Convert.ToInt32(readEmp[3]);
                    emp.empIsPermenant =Convert.ToBoolean(readEmp[4]);
                    con.Close();
                    return emp;
                }
                else
                {
                    con.Close();
                    throw new Exception("Employee Not Found");
                }
            }
            catch (Exception)
            {

                con.Close();
                throw new Exception("Employee Not found");
            }     
                       
        }

        public List<Employee> GetAllEmployees()
        {
            SqlCommand cmd_getAll = new SqlCommand("select * from employeeDetails", con);
            SqlDataReader readAllEmployee = null;
            List<Employee> eList = new List<Employee>();

            try
            {
                con.Open();

                readAllEmployee = cmd_getAll.ExecuteReader();

                while (readAllEmployee.Read())
                {
                    eList.Add(new Employee()
                    {
                     empNo = Convert.ToInt32(readAllEmployee[0]),
                     empName = readAllEmployee[1].ToString(),
                     empDesignation = readAllEmployee[2].ToString(),
                     empSalary =Convert.ToInt32(readAllEmployee[3]),
                     empIsPermenant = Convert.ToBoolean(readAllEmployee[4])
                    
                    });
                    
                }
                return eList;
                readAllEmployee.Close();
                con.Close();
            }
            catch (Exception es)
            {
                con.Close();
                throw new Exception(es.Message);
            }
        }
        public string AddNewEmployee(int p_empNo, string p_name, string p_designation, int p_salary, bool p_isPermenant)
        {
            SqlCommand cmd_insert = new SqlCommand("insert into employeeDetails values(@empNo,@empName,@empDesignation,@empSalary,@empIsPermanant)", con);
            cmd_insert.Parameters.AddWithValue("empNo", p_empNo);
            cmd_insert.Parameters.AddWithValue("empName", p_name);
            cmd_insert.Parameters.AddWithValue("empDesignation", p_designation);
            cmd_insert.Parameters.AddWithValue("empSalary", p_salary);
            cmd_insert.Parameters.AddWithValue("empIsPermanant", p_isPermenant);
            try
            {
                Console.WriteLine(cmd_insert.CommandText);
                con.Open();
                int result = cmd_insert.ExecuteNonQuery(); //method returns number of rows affected in database
                if (result == 1)
                {
                    con.Close();
                    return "Employee Added to database";
                }
                else
                {
                    con.Close();
                    return "Could not insert please check with Admin";
                }

            }
            catch (Exception es)
            {
                con.Close();
                return es.Message;
            }
        }

        public string DeleteEmployee(int p_empno)
        {
            SqlCommand cmd_delete = new SqlCommand("delete from employeeDetails where empNo=@empNo", con);

            cmd_delete.Parameters.AddWithValue("empNo", p_empno);

            try
            {
                con.Open();
                int deleteResult = cmd_delete.ExecuteNonQuery();

                if (deleteResult == 1)
                {
                    con.Close();
                    return "Employee Deleted Successfully";
                }
                else
                {
                    con.Close();
                    return "Employee Not found in system";
                }

            }
            catch (Exception es)
            {
                con.Close();
                throw new Exception(es.Message);
            }
        }

        
    }
}
