namespace AngularSignalR.Models
{
    public class Message
    {
        public string Data { get; set; }
        public string Label { get; set; }

        public Message(string d)
        {
            Data = d;
        }
    }
}