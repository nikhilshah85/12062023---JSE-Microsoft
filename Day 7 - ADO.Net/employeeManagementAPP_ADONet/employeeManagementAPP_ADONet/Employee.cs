using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace employeeManagementAPP_ADONet
{
    internal class Employee
    {


        SqlConnection con = new SqlConnection("server=(localdb)\\ProjectModels;database=employeeManagement;integrated security=true");


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
