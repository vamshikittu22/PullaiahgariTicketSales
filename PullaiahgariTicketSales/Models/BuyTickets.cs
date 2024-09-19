using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PullaiahgariTicketSales.Models
{
    public class BuyTickets
    {
        /*
         * Created by Pullaiahgari
         * 555555555
         * This is the supporting model for Buy view which is a form that accesses this class.
         *  This class has an overloaded constructor with two signatures: a default constructor and one with parameters for event name and for sale and ticket price.Default parameterless constructor is needed for binding model.
         *  The parametrized constructor is called from the Cart controler's Buy action method, to be sent as ViewModel. supports Buy form.
         *  There are two methods: CalculateDiscount() and ProcessSale() methods 
         *  One colllection for dropdown options
         *  
         */



        //constants
        private const Double SR_DISCOUNT_RATE = 0.2D;

        //properties and variables:
        public string? EventName { get; set; }
        public string? CustomerName { get; set; }
        [Required(ErrorMessage = "Email is a required Field.")]
        [EmailAddress(ErrorMessage = "Please Enter a Valid Email Address")]
        [Display(Name = "Email Address: ")]
        public string? Email { get; set; }
        public double TicketPrice { get; set; }
        public string? SaleDate { get; set; }
        [Required(ErrorMessage = "Number of Tickets should be between 1 and 10")]
        public int NumberOfTickets { get; set; }
        [Display(Name = "Senior Discount: ")]
        public bool SeniorDiscount { get; set; }
        [Required(ErrorMessage = "Delivery Option is required.")]
        [Display(Name = "Select mode of delivery: ")]
        public string? DeliveryMode { get; set; }//underlying property for dropdown

        //other properties:
        public double SubTotal { get; set; }
        public double SaleDiscount { get; set; }
        public double DeliveryCharge { get; set; }
        public double AmountDue { get; set; }

        //collection for select dropdown
        public List<SelectListItem> DeliveryOptions = new()
        {
            new SelectListItem { Text = "", Value = "None"},
            new SelectListItem { Text = "Mail", Value = "Mail"},
            new SelectListItem { Text = "Print", Value = "Print at Home"},
            new SelectListItem { Text = "Digital", Value = "Digital Ticket"},
            new SelectListItem { Text = "Call", Value = "Will Call"}
        };

        public BuyTickets()
        {
            //Parameterless constructor for use with binding model
        }//ctor

        public BuyTickets(string? eventName, double ticketPrice)
        {
            this.EventName = eventName;
            this.TicketPrice = ticketPrice;
        }//ctor -- for use with ValueModel.

        public void CalcuteDiscount()
        {
            SaleDiscount = SubTotal * SR_DISCOUNT_RATE;
        }//CalculateDiscount()

        public void CalculateAmountDue()
        {
            //Calculates the amount due and sets the saleDate.
            SaleDate = DateTime.Today.ToShortDateString();
            SubTotal = TicketPrice * NumberOfTickets;

            //check if there is senior discount;
            if (SeniorDiscount)
            {
                CalcuteDiscount();
            }//if
            if (DeliveryMode == "Mail")
            {
                DeliveryCharge = 3.95;
            }
            else
            {
                DeliveryCharge = 0;
            }
            AmountDue = SubTotal - SaleDiscount + DeliveryCharge;
        }//calculateamountdue

    }//buytickets

}//namespace
