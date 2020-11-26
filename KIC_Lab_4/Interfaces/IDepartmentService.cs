using KIC_Lab_4.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KIC_Lab_4.Interfaces
{
    public interface IDepartmentService
    {
        public Task<ICollection<Department>> GetDepartments();

        public Task<Department> GetDepartmentById(int deptId);

        public Task<bool> CheckIfExists(int deptId);

        public Task<bool> CheckIfExistsByName(string deptName);

        public Task<string> GetMaxDeptPrice(string deptName);
    }
}
