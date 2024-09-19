using Microsoft.AspNetCore.Mvc;
using PullaiahgariTicketSales.Models;

namespace PullaiahgariTicketSales.Controllers
{
    public class EventsController : Controller
    {

       //Created by Pullaiahagri
       //7777777


        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult EventList(string id = "All")
        {

           //Instantiate the EventService class

            EventsService eventsService = new EventsService();


            //list of categories
            List<Category> categories = new List<Category>();

            //list of events
            List<Event> events = new List<Event>();

            //get events based on ID
            if (id == "All")
            {
                //get all events
                events = eventsService.GetAllEvents();
            }
            else
            {
                //Based on ID fund the category being asked for, if ID is specified then use the category to return all events 
                //of that type
                //Variable to hold category id:
                int selectedCategoryID = 0;
                foreach (Category cat in categories)
                {
                    if (cat.CategoryName == id)
                    {
                        selectedCategoryID = cat.Id;
                    }//if
                }//foreach

                foreach (Event anEvent in eventsService.GetAllEvents())
                {
                    if (anEvent.CategoryID == selectedCategoryID)
                    {
                        events.Add(anEvent);
                    }//id
                }//loop for finding events.
            }//if else


            //return ListViewModel as a ViewModel with a collection of Events

            ListViewModel listViewModel = new ListViewModel(events, categories, id);

            return View(listViewModel);
        }//EventList()

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult Details(int id)
        {
            EventsService eventsService = new EventsService();
            Event oneEvent = eventsService.GetEvent(id);
            return View(oneEvent);
        }//details()

    }//EventsController

}//namespace
