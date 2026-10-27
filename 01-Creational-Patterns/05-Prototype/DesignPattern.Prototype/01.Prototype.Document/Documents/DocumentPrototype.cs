namespace DesignPattern.Prototype.Documents;

public abstract class DocumentPrototype
{
    protected DocumentPrototype(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public string Title { get; set; }

    public string Author { get; set; }

    public string Summary { get; set; } = string.Empty;

    public List<string> Sections { get; } = new();

    public void AddSection(string section) => Sections.Add(section);

    public abstract DocumentPrototype Clone();

    public override string ToString()
    {
        return $"""
               Title: {Title}
               Author: {Author}
               Summary: {Summary}
               Sections: {string.Join(", ", Sections)}
               """;
    }
}
