using DesignPattern.Prototype.Documents;



#region "Doc 1"
var original = new ProjectProposalDocument(
    title: "Web Platform Microsoft",
    author: "Said WAHID")
{
    Summary = "Initial proposal template"
};

original.AddSection("Business needs");
original.AddSection("Technical solution");
original.AddSection("Timeline");

Console.WriteLine("Original document:");
Console.WriteLine(original);
Console.WriteLine();

#endregion



var cloned = original.Clone();
cloned.Title = "Web Platform Proposal - Customer A";
cloned.Author = "Architecture Team";
cloned.AddSection("Customer-specific notes");

Console.WriteLine("Cloned and customized document:");
Console.WriteLine(cloned);

Console.WriteLine("Original document after cloning remains unchanged:");
Console.WriteLine(original);
