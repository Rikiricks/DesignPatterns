namespace Builder.Features
{
    public class Email
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<string> Attachments { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"To: {To}\nFrom: {From}\nSubject: {Subject}\nBody: {Body}\nAttachments: {string.Join(", ", Attachments)}";
        }
    }
}
