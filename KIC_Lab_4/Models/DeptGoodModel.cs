using System.ComponentModel.DataAnnotations;

namespace KIC_Lab_4.Models
{
    public class DeptGoodModel
    {
        [Required(ErrorMessage = "Please enter the department name!")]
        public string DeptName { get; set; }

        public string GoodName { get; set; }
    }
}
