namespace SchoolSystem.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Location { get; set; }
        public string EventDate { get; set; }
        public string Theme { get; set; }
        public int QuantityPeople { get; set; }
        public int Batch { get; set; }
        public int ImageURL { get; set; }
    }
}