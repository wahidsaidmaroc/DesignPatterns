var editor = new TextEditor();
editor.Write("Bonjour");
var saved = editor.Save();
editor.Write(" tout le monde");
Console.WriteLine(editor.Text);
editor.Restore(saved);
Console.WriteLine(editor.Text);

public sealed record EditorMemento(string Text);

public sealed class TextEditor
{
    public string Text { get; private set; } = string.Empty;

    public void Write(string text) => Text += text;

    public EditorMemento Save() => new(Text);

    public void Restore(EditorMemento memento) => Text = memento.Text;
}
