namespace MyTicket.DTO.TicketMasterResponses;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Accessibility
    {
        public int ticketLimit { get; set; }
        public string info { get; set; }
        public string url { get; set; }
        public string urlText { get; set; }
    }