﻿namespace BusinessManagementSystem.Dtios
{
    public class UpdateProductDtio
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
