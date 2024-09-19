using Microsoft.AspNetCore.Mvc;
using PullaiahgariTicketSales.Models;

namespace PullaiahgariTicketSales.Controllers
{
    public class CartController : Controller
    {
        //Created by Pullaiahgari
        //888888

        public IActionResult Buy(int id)
        {
            //gets the ID of the event that the user wants to you ticket for and then,
            //using the EventsService, gets an object representing the event.

            EventsService eventsService = new EventsService();
            Event selectedEvent = eventsService.GetEvent(id);

            //Start buying ticket by creating buyTicket object and setting name of the event and ticket price. (constructor of Buy class).

            BuyTickets buyTickets = new BuyTickets(selectedEvent.Title, selectedEvent.TicketPrice);
            return View(buyTickets);
        }//buy
        public IActionResult Confirmation(BuyTickets model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateAmountDue();
                return View(model);
            }
            return View("Buy", model); //take user back to buy tickets page
        }//confirmation

    }//Cartcontroller

}//namespace
