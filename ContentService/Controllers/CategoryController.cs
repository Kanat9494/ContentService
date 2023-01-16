namespace ContentService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IDataContent<Category> _dataContent;

    public CategoryController(IDataContent<Category> dataContent)
    {
        _dataContent = dataContent;
    }

    [HttpGet("GetCategories")]
    public async Task<IEnumerable<Category>> GetCategories()
    {
        return await _dataContent.GetItemsAsync();
    }
}
