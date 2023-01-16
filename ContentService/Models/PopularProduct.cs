namespace ContentService.Models;

public class PopularProduct
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int ImageId { get; set; }
    public string ProductName { get; set; }
    public string ImagePath { get; set; }
}
