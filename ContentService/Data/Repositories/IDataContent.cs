namespace ContentService.Data.Repositories;

public interface IDataContent<T>
{
    Task<IEnumerable<T>> GetItemsAsync();
}
