namespace PullaiahgariTicketSales.Models
{
    /*
     * Created by Pullaiahgari
     * 222222
     * Class creates type for events
     * 
     */
    public class Event
    {
        //properties

        public int Id { get; set; }
        public string? Title { get; set; }
        public int CategoryID { get; set; }
        public double TicketPrice { get; set; }
        public string? Description { get; set; }
        public string? ImageId { get; set; }
    }//event

}//namespace
