ReportExporter[] exporters = [new CsvExporter(), new TextExporter()];
foreach (var exporter in exporters)
{
    exporter.Export("Ventes du mois");
    Console.WriteLine();
}

public abstract class ReportExporter
{
    public void Export(string title)
    {
        var data = ReadData();
        var formatted = Format(title, data);
        Save(formatted);
    }

    protected virtual string ReadData() => "Produit,Quantité\nLivre,3";
    protected abstract string Format(string title, string data);
    protected abstract void Save(string content);
}

public sealed class CsvExporter : ReportExporter
{
    protected override string Format(string title, string data) => $"{title}\n{data}";
    protected override void Save(string content) => Console.WriteLine($"CSV enregistré :\n{content}");
}

public sealed class TextExporter : ReportExporter
{
    protected override string Format(string title, string data) =>
        $"{title}\n---\n{data.Replace(',', ' ')}";

    protected override void Save(string content) => Console.WriteLine($"Texte enregistré :\n{content}");
}
