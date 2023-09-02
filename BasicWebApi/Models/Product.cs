namespace BasicWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? UnitName { get; set; }
        public string? Name { get; set; }
        public int Code { get; set; }
        public string? ParentCode { get; set; }
        public int ProductBarcode { get; set; }
        public string? Description { get; set; }
        public string? BrandName { get; set; }
        public string? SizeName { get; set; }
        public string? ColorName { get; set; }
        public string? ModelName { get; set; }
        public string? VariantName { get; set; }
        public float OldPrice { get; set; }
        public float Price { get; set; }
        public float CostPrice { get; set; }
        public string? WarehouseList { get; set; }
        public float stock { get; set; }
        public float TotalPurchase { get; set; }
        public DateTime LastPurchaseDate { get; set; }
        public string? LastPurchaseSupplier { get; set; }
        public float TotalSales { get; set; }
        public string? LastSalesDate {  get; set; }
        public string? LastSalesCustomer { get; set; }
        public string? ImagePath { get; set; }
        public string? Type {  get; set; }
        public string? Status { get; set; }


    }
}
