namespace ContentService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IDataContent<PopularProduct> _dataContent;

    public ProductController(IDataContent<PopularProduct> dataContent)
    {
        _dataContent = dataContent;
    }

    [HttpGet("GetPopularProducts")]
    public async Task<IEnumerable<PopularProduct>> GetPopularProducts()
    {
        return await _dataContent.GetItemsAsync();
    }
}
