namespace ContentService.Data.Repositories;

public class ExecuteProductData : IDataContent<PopularProduct>
{
    private readonly ApplicationContext _context;

    public ExecuteProductData(ApplicationContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<PopularProduct>> GetItemsAsync()
    {
        return await _context.PopularProducts.OrderBy(x => x.ProductName).ToListAsync();
    }
}
