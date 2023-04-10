namespace P326FirstWebAPI.Models
{
    public class Product:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public bool IsActive { get; set; }
    }
}
