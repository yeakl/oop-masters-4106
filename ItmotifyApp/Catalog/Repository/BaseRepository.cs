using ItmotifyApp.Catalog.Model;

namespace ItmotifyApp.Catalog.Repository;

public abstract class BaseRepository<T> where T : ICatalogItem
{
    private readonly List<T> _items = [];

    public void Add(T item) => _items.Add(item);
    public List<T> GetAll() => _items;
    public T GetByIndex(int index) => _items.ElementAt(index);

    public List<T> FindByName(string name)
    {
        List<T> items = [];
        items.AddRange(GetAll().Where(item => item.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase)));

        return items;
    }
}