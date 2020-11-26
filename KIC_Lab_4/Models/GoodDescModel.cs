using System.ComponentModel.DataAnnotations;

namespace KIC_Lab_4.Models
{
    public class GoodDescModel
    {
        [Required(ErrorMessage = "Please enter the good ID!")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter positive number!")]
        public int Good_Id { get; set; }

        [Required(ErrorMessage = "Please enter desired discount!")]
        [Range(0, 100, ErrorMessage = "Please enter the discount between 0 and 100!")]
        public int Discount { get; set; }
    }
}
