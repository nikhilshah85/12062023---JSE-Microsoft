using System.Data.SqlClient;
namespace employeeManagement.Models
{
    public class employeeDetails
    {
        #region Properties
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesigantion { get; set; }

        public int empSalary { get; set; }
        public bool empIsPermenant { get; set; }
        #endregion

        List<employeeDetails> eList = new List<employeeDetails>();

        SqlConnection con = new SqlConnection("server=(localdb)\\ProjectModels;database=employeeManagement;integrated security=true");

        public List<employeeDetails> GetAllemployees()
        {
            SqlCommand cmd_allemp = new SqlCommand("select * from employeeDetails",con);
            SqlDataReader read_emp;

            try
            {
                con.Open();

                read_emp = cmd_allemp.ExecuteReader();

                while (read_emp.Read())
                {
                    eList.Add(new employeeDetails()
                    {
                         empNo =Convert.ToInt32(read_emp[0]),
                         empName = read_emp[1].ToString(),
                         empDesigantion = read_emp[2].ToString(),
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
                con.Close();
            }
        }
        
        




    }
}
