using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace employeeManagement_ADO_SP
{
    internal class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }

        SqlConnection con = new SqlConnection("server=(localdb)\\ProjectModels;database=employeeManagement;integrated security=true");

        public string proc_DeletEmployee(int p_empNo)
        {
            SqlCommand cmd_delete = new SqlCommand("proc_deleteEmp", con);

            cmd_delete.CommandType = System.Data.CommandType.StoredProcedure;

            cmd_delete.Parameters.AddWithValue("@empNo", p_empNo);
            try
            {
                con.Open();
                int result = cmd_delete.ExecuteNonQuery();
                if (result == 1)
                {
                    con.Close();
                    return "Employee Deleted Successfully";
                }
                else
                {
                    con.Close();
                    return "Employee with EMP NO : " + p_empNo + " Not found in system";
                }
            }
            catch (Exception es)
            {
                con.Close();
                throw new Exception(es.Message);
            }
        }

        public string proc_AddEmployee(string name, string designation, double salary, bool isPermenat)
        {
            SqlCommand cmd_addEmployee = new("proc_AddNewEmployee", con);
            cmd_addEmployee.Parameters.AddWithValue("@empName", name);
            cmd_addEmployee.Parameters.AddWithValue("@empDesignation", designation);
            cmd_addEmployee.Parameters.AddWithValue("@empSalary", salary);
            cmd_addEmployee.Parameters.AddWithValue("@empIsPermenant", isPermenat);

            cmd_addEmployee.Parameters.Add("@empNo",System.Data.SqlDbType.Int);
            
            cmd_addEmployee.Parameters["@empNo"].Direction = System.Data.ParameterDirection.Output;

            cmd_addEmployee.CommandType = System.Data.CommandType.StoredProcedure;
            Console.WriteLine(cmd_addEmployee.CommandText);
            Console.ReadLine();
            try
            {
                con.Open();
                int result = cmd_addEmployee.ExecuteNonQuery();
                if (result == 1)
                {
                    return "Employee Addedd Successfully, new Emp No : " + cmd_addEmployee.Parameters["@empNo"].Value.ToString();   
                }
                else
                {
                    return "Could Not Add Employee";
                }
            }
            catch (Exception es)
            {
                throw new Exception(es.Message);                
            }
            finally
            {
                con.Close();
            }

        }

        public Employee proc_GetEmployeeById(int id)
        {
            SqlCommand cmd_getById = new SqlCommand("proc_getEmpById", con);
            cmd_getById.Parameters.AddWithValue("@empNo",id);
            SqlDataReader readEmp = null;

            cmd_getById.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                con.Open();
                readEmp = cmd_getById.ExecuteReader();
                if (readEmp.Read())
                {
                    Employee emp = new Employee();

                    emp.empNo =Convert.ToInt32(readEmp[0]);
                    emp.empName = readEmp[1].ToString();
                    emp.empDesignation = readEmp[2].ToString();
                    emp.empSalary =Convert.ToDouble(readEmp[3]);
                    emp.empIsPermenant =Convert.ToBoolean(readEmp[4]);
                    return emp;
                }
                else
                {
                    throw new Exception("Employee not found");
                }
            }
            catch (Exception es)
            {

                throw new Exception(es.Message);
            }
            finally
            {
                readEmp.Close();
                con.Close();
            }
        }

    }
}
