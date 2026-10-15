namespace DesignPattern.Builder.Email.Builders;

public class EmailBuilder
{
    private readonly Models.Email _email = new();

    public EmailBuilder From(string from)
    {
        _email.From = from;
        Console.WriteLine($"→ From : {from}");
        // this conserve le même Builder tout au long de la chaîne.
        return this;
    }

    public EmailBuilder To(string to)
    {
        _email.To = to;
        Console.WriteLine($"→ To : {to}");
        return this;
    }

    public EmailBuilder Subject(string subject)
    {
        _email.Subject = subject;
        Console.WriteLine($"→ Subject : {subject}");
        return this;
    }

    public EmailBuilder Body(string body)
    {
        _email.Body = body;
        Console.WriteLine($"→ Body : {body}");
        return this;
    }

    public EmailBuilder AddAttachment(string attachment)
    {
        _email.Attachment = attachment;
        Console.WriteLine($"→ Attachment : {attachment}");
        return this;
    }

    public EmailBuilder SetPriority(string priority)
    {
        _email.Priority = priority;
        Console.WriteLine($"→ Priority : {priority}");
        return this;
    }

    public EmailBuilder Cc(string cc)
    {
        _email.Cc = cc;
        Console.WriteLine($"→ Cc : {cc}");
        return this;
    }

    // Un Builder par objet : Build retourne l'instance préparée, sans envoyer d'email.
    public Models.Email Build()
    {
        Console.WriteLine("→ Build()");
        return _email;
    }
}
