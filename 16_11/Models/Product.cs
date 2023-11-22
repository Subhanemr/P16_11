namespace _16_11.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgageURL { get; set; }
        public string ImgageLgURL { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Category? Category { get; set; }
        public int? CategoryId { get; set; }


    }
}
