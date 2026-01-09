namespace HarryPottah;

public class MagicStore
{
    private List<StoreItem> _items;

    public MagicStore(List<StoreItem> items)
    {
        _items = items;
    }

    public StoreItem? GetItemByName(string name)
    {
        return _items.FirstOrDefault(i =>
            i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
