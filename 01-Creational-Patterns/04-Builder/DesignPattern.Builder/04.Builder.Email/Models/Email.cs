namespace DesignPattern.Builder.Email.Models;

public class Email
{
    public string From { get; internal set; } = string.Empty;
    public string To { get; internal set; } = string.Empty;
    public string Subject { get; internal set; } = string.Empty;
    public string Body { get; internal set; } = string.Empty;
    public string Attachment { get; internal set; } = string.Empty;
    public string Priority { get; internal set; } = "Normal";
    public string Cc { get; internal set; } = string.Empty;

    public override string ToString() => $"""
        Email :
          From : {From}
          To : {To}
          Subject : {Subject}
          Body : {Body}
          Attachment : {(string.IsNullOrEmpty(Attachment) ? "Aucune" : Attachment)}
          Priority : {Priority}
          Cc : {(string.IsNullOrEmpty(Cc) ? "Aucun" : Cc)}
        """;
}
