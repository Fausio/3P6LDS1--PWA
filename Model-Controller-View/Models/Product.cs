namespace Model_Controller_View.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
      
    }
}
