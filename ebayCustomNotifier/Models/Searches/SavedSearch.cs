using ebayCustomNotifier.Models.Items;

namespace ebayCustomNotifier.Models.Searches
{
    public class SavedSearch
    {
        public int SavedSearchId { get; set; }
        public string SearchTerm { get; set; }
        public List<ItemElement> ItemElements { get; set; } = new List<ItemElement>();
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    }
}
