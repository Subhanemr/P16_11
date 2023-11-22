using System.ComponentModel.DataAnnotations;

namespace _16_11.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name must be entered mutled")]
        [MaxLength(25, ErrorMessage = "It should not exceed 25 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Name must be entered mutled")]
        public string ImgageURL { get; set; }
        [Required(ErrorMessage = "Name must be entered mutled")]
        public string ImgageLgURL { get; set; }
        [Required(ErrorMessage = "Name must be entered mutled")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Name must be entered mutled")]
        public DateTime CreatedDate { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public Category? Category { get; set; }
        public int? CategoryId { get; set; }


    }
}
