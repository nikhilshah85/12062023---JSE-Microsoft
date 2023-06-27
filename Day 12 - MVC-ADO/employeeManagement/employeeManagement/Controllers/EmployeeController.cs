using Microsoft.AspNetCore.Mvc;
using employeeManagement.Models;
namespace employeeManagement.Controllers
{
    public class EmployeeController : Controller
    {

        employeeDetails eObj = new employeeDetails();
        public IActionResult EmployeeList()
        {
            ViewBag.eList = eObj.GetAllemployees();
            return View();
        }
    }
}
