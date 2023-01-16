namespace ContentService.Data.Repositories;

public class ExecuteCategoryData : IDataContent<Category>
{
    private readonly ApplicationContext _context;

    public ExecuteCategoryData(ApplicationContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Category>> GetItemsAsync()
    {
        return await _context.Categories.ToListAsync();
    }
}
