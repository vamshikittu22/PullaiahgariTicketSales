namespace PullaiahgariTicketSales.Models
{

    //Created by Pullaiahgari
    //333333
    //This Class creates a list of events with each event of type Event class 
    // and categories with Category class
    public class EventsService
    {

        private List<Event> _allEvents = new()
        {
            new Event() {Id = 100, Title = "The Lion King", CategoryID = 1, TicketPrice = 50, Description = "Musical Based on Disney's animated movie.", ImageId = "100.jpeg"},
            new Event() {Id = 200, Title = "Holiday Spectacular", CategoryID = 2, TicketPrice = 40, Description = "Holiday extravaganza for the entire family.", ImageId = "200.jpeg"},
            new Event() {Id = 300, Title = "Mary Poppins", CategoryID = 1, TicketPrice = 50, Description = " The popular musical with seven Tony awards.", ImageId = "300.jpeg"},
            new Event() {Id = 400, Title = "Taylor Swift", CategoryID = 2, TicketPrice = 90, Description = "Popular singer and songwriter.", ImageId = "400.jpeg"},
            new Event() {Id = 500, Title = "Alice in Wonderland", CategoryID = 1, TicketPrice = 90, Description = "Alice Adventures in Wonderland and Through the Looking-Glass by Lewis Carroll", ImageId = "500.jpeg"}
        };

        private List<Category> _allCategories = new()
        {
            new Category() {Id = 1, CategoryName = "Theater show"}, new Category() {Id = 2, CategoryName = "Concert"}
        };


        //GetEvent()  returns events based on incoming parameter category
        public Event GetEvent(int id)
        {

            //incoming parameter id comes from the <a> link in details view, id is either all or specific name

            Event? selectedEvent = null;
            foreach (Event anEvent in _allEvents)
            {
                if (anEvent.Id == id)
                {
                    selectedEvent = anEvent;
                }

            }
            return selectedEvent;
        }//GetEvent

        //GetCategories() returns list of caretories or events
        public List<Category> GetCategories() { return _allCategories; }

        //GetAllEvents  return all categories
        public List<Event> GetAllEvents() { return _allEvents; }

    }//EventService

}//namespace
