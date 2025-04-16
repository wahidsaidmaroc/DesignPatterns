// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

WordDocument originalDoc = new 
    WordDocument("Original", "This is the original document.", "WordFeature");
// Cloning the original document
// using the Prototype pattern

WordDocument clonedDoc = (WordDocument)originalDoc.Clone();

Console.WriteLine($"Title: {clonedDoc.Title}, Content: {clonedDoc.Content}, Feature: {clonedDoc.WordSpecificFeature}");



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

public class WordDocument : Document
{
    public string WordSpecificFeature { get; set; }

    public WordDocument(string title, string content, string wordSpecificFeature)
        : base(title, content)
    {
        WordSpecificFeature = wordSpecificFeature;
    }

    public override Document Clone()
    {
        return new WordDocument(Title, Content, WordSpecificFeature);
    }
}

public class PdfDocument : Document
{
    public string PdfSpecificFeature { get; set; }

    public PdfDocument(string title, string content, string pdfSpecificFeature)
        : base(title, content)
    {
        PdfSpecificFeature = pdfSpecificFeature;
    }

    public override Document Clone()
    {
        return new PdfDocument(Title, Content, PdfSpecificFeature);
    }
}