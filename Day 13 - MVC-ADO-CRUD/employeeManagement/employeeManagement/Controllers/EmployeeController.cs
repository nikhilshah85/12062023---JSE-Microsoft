using Microsoft.AspNetCore.Mvc;
using employeeManagement.Models;
namespace employeeManagement.Controllers
{
    public class EmployeeController : Controller
    {

        employeeDetails eObj = new employeeDetails();
        public IActionResult EmployeeList()
        {
            ViewBag.eList = eObj.GetAllEmployees();
            return View();
        }

        public IActionResult EmployeeById()
        {
            ViewBag.hasData = false;
            return View();
        }
        [HttpPost]
        public IActionResult EmployeeById(int empNo)
        {
            ViewBag.empDetails = eObj.GetEmployeeById(empNo);
            ViewBag.hasData = true;
            return View();
        }

        public IActionResult AddNewEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewEmployee(employeeDetails newEmp)
        {
            ViewBag.result = eObj.AddNewEmployee(newEmp);
            return View();
        }
    }
}









