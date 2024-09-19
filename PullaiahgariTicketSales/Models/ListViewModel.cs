namespace PullaiahgariTicketSales.Models
{

    //Created by Pullaiahgari
    //444444

    public class ListViewModel
    {
        public IEnumerable<Event> Events { get; }
        public List<Category> Categories { get; }
        public string? SelectedCategory { get; }
        public ListViewModel(IEnumerable<Event> events, List<Category> categories, string selectedCategory)
        {
            Events = events;
            Categories = categories;
            SelectedCategory = selectedCategory;
        }//ctor

    }//ListViewModel

}//namespace
