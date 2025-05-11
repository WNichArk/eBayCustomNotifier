namespace ebayCustomNotifier.Models.Items
{
    public class Item
    {
        public int ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public List<ItemElement> ItemElements { get; set; }
    }

    public class ItemElement
    {
        public int ItemElementId { get; set; }
        public string ElementName { get; set; }
        public string ElementValue { get; set; }
    }
}
