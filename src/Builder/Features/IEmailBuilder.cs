namespace Builder.Features
{
    public interface IEmailBuilder
    {
        IEmailBuilder SetTo(string to);
        IEmailBuilder SetFrom(string from);
        IEmailBuilder SetSubject(string subject);
        IEmailBuilder SetBody(string body);
        IEmailBuilder AddAttachment(string attachment);
        Email Build();
    }
}
