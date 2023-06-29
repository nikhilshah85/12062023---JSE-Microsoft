using System.Data.SqlClient;
using System.Xml;

namespace employeeManagement.Models
{
    public class employeeDetails
    {
        SqlConnection con = new SqlConnection("server=(localdb)\\ProjectModels;database=employeeManagement;integrated security=true");
        #region Properties
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public int empSalary { get; set; }

        public bool empIsPermenant { get; set; }

        List<employeeDetails> eList = new List<employeeDetails>();
        #endregion

        

        #region CRUD Operations
        public List<employeeDetails> GetAllEmployees()
        {
            SqlCommand cmd_getAllEmp = new SqlCommand("select * from employeeDetails", con);
            SqlDataReader read_emp = null;
            try
            {
                con.Open();
                 read_emp = cmd_getAllEmp.ExecuteReader();
                while (read_emp.Read())
                {
                    eList.Add(new employeeDetails()
                    {
                         empNo =Convert.ToInt32(read_emp[0]),
                         empName = read_emp[1].ToString(),
                         empDesignation = read_emp[2].ToString(),
                         empSalary =Convert.ToInt32(read_emp[3]),
                         empIsPermenant =Convert.ToBoolean(read_emp[4])
                    });
                }
                return eList;
            }
            catch (Exception es)
            {

                throw new Exception(es.Message);
            }
            finally
            {
                read_emp.Close();
                con.Close();
            }



        }

        public employeeDetails GetEmployeeById(int id)
        {
            SqlCommand cmd_searchById = new SqlCommand("select * from employeeDetails", con);
            SqlDataReader read_empByid = null;
            employeeDetails emp = new employeeDetails();
            try
            {
                con.Open();
                read_empByid = cmd_searchById.ExecuteReader();
                if (read_empByid.Read())
                {
                    emp = new employeeDetails()
                    {

                        empNo = Convert.ToInt32(read_empByid[0]),
                        empName = read_empByid[1].ToString(),
                        empDesignation = read_empByid[2].ToString(),
                        empSalary = Convert.ToInt32(read_empByid[3]),
                        empIsPermenant = Convert.ToBoolean(read_empByid[4])

                    };
                    
                }
                return emp;
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


        public string AddNewEmployee(employeeDetails newEmp)
        {
            SqlCommand cmd_insertEmp = new SqlCommand("insert into employeeDetails values(@eNo,@eName,@eDesignation,@eSalary,@IsPermenant)", con);
            cmd_insertEmp.Parameters.AddWithValue("@eNo", newEmp.empNo);
            cmd_insertEmp.Parameters.AddWithValue("@eName", newEmp.empNo);
            cmd_insertEmp.Parameters.AddWithValue("@eDesignation", newEmp.empNo);
            cmd_insertEmp.Parameters.AddWithValue("@eSalary", newEmp.empNo);
            cmd_insertEmp.Parameters.AddWithValue("@IsPermenant", newEmp.empNo);
            
            try
            {
                con.Open();
                int result = cmd_insertEmp.ExecuteNonQuery();
                if (result == 1)
                {
                    return "Employee Added Successfully";
                }
                else
                {
                    throw new Exception("Something went wrong, please contact admin");
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


        #endregion

        
    }
}
