// See https://aka.ms/new-console-template for more information

// Cloning the original document
// using the Prototype pattern


public abstract class Document
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Document(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public abstract Document Clone();
}
