namespace Builder.Features
{
    public class EmailBuilder : IEmailBuilder
    {
        private Email _email = new Email();

        public IEmailBuilder AddAttachment(string attachment)
        {
            _email.Attachments.Add(attachment);
            return this;
        }

        public IEmailBuilder SetBody(string body)
        {
            _email.Body = body;
            return this;
        }

        public IEmailBuilder SetFrom(string from)
        {
            _email.From = from;
            return this;
        }

        public IEmailBuilder SetSubject(string subject)
        {
            _email.Subject = subject;
            return this;
        }

        public IEmailBuilder SetTo(string to)
        {
            _email.To = to;
            return this;
        }

        public Email Build()
        {
            return _email;
        }
    }
}
