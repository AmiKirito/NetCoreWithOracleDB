using KIC_Lab_4.Interfaces;
using KIC_Lab_4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KIC_Lab_4.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [Route("departments/{deptId}")]
        public async Task<IActionResult> GetDepartmentById(int deptId)
        {
            var department = await _departmentService.GetDepartmentById(deptId);

            return View(department);
        }

        [Route("departments")]
        public async Task<IActionResult> GetDepartments()
        {
            var departments = await _departmentService.GetDepartments();

            return View(departments);
        }

        [HttpGet]
        public IActionResult GetMaxDeptPrice()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetMaxDeptPrice(DeptGoodModel model)
        {
            if (!await _departmentService.CheckIfExistsByName(model.DeptName))
            {
                ModelState.AddModelError("", "Department with such name does not exist!");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.GoodName = await _departmentService.GetMaxDeptPrice(model.DeptName);

            return View(model);
        }
    }
}
