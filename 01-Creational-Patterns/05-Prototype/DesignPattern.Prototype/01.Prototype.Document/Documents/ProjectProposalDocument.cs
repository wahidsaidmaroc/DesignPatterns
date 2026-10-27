namespace DesignPattern.Prototype.Documents;

public sealed class ProjectProposalDocument : DocumentPrototype
{
    public ProjectProposalDocument(string title, string author)
        : base(title, author)
    {
    }

    private ProjectProposalDocument(ProjectProposalDocument source)
        : base(source.Title, source.Author)
    {
        Summary = source.Summary;
        Sections.AddRange(source.Sections);
    }

    public override DocumentPrototype Clone() => new ProjectProposalDocument(this);
}
