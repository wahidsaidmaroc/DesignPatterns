var factory = new CharacterStyleFactory();
var document = new[]
{
    new StyledCharacter('A', factory.Get("Arial", 12)),
    new StyledCharacter('B', factory.Get("Arial", 12)),
    new StyledCharacter('C', factory.Get("Georgia", 14))
};

foreach (var character in document)
{
    character.Display();
}

Console.WriteLine($"Styles partagés : {factory.Count}");

public sealed record CharacterStyle(string Font, int Size);

public sealed class CharacterStyleFactory
{
    private readonly Dictionary<string, CharacterStyle> _styles = [];

    public CharacterStyle Get(string font, int size)
    {
        var key = $"{font}:{size}";
        if (!_styles.TryGetValue(key, out var style))
        {
            style = new CharacterStyle(font, size);
            _styles.Add(key, style);
        }

        return style;
    }

    public int Count => _styles.Count;
}

public sealed record StyledCharacter(char Value, CharacterStyle Style)
{
    public void Display() =>
        Console.WriteLine($"'{Value}' en {Style.Font}, {Style.Size} pt");
}
