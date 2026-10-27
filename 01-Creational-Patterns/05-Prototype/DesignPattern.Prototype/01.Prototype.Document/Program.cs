using DesignPattern.Prototype.Documents;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("====================================");
Console.WriteLine("PROTOTYPE PATTERN DEMO");
Console.WriteLine("====================================");
Console.WriteLine("Prototype lets us clone an existing object and customize the copy.");
Console.WriteLine();

var original = new ProjectProposalDocument(
    title: "Web Platform Proposal",
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

var cloned = original.Clone();
cloned.Title = "Web Platform Proposal - Customer A";
cloned.Author = "Architecture Team";
cloned.AddSection("Customer-specific notes");

Console.WriteLine("Cloned and customized document:");
Console.WriteLine(cloned);
Console.WriteLine();

Console.WriteLine("Original document after cloning remains unchanged:");
Console.WriteLine(original);
