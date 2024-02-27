namespace BusinessManagementSystem.Dtios
{
    public class CreateProductDtio
    {  
        public int Quantity { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public double CostPrice { get; set; }
    }
}
