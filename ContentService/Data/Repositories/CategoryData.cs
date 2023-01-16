namespace ContentService.Data.Repositories;

public class CategoryData : IDataContent<Category>
{
    private readonly ApplicationContext _context;

    public CategoryData(ApplicationContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Category>> GetItemsAsync()
    {
        return await _context.Categories.ToListAsync();
    }
}
