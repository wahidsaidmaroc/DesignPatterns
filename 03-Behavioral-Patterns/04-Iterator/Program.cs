var library = new BookCollection();
library.Add(new Book("Le Petit Prince"));
library.Add(new Book("L'Étranger"));
library.Add(new Book("Le Tour du monde en quatre-vingts jours"));

foreach (var book in library)
{
    Console.WriteLine(book.Title);
}

public sealed record Book(string Title);

public sealed class BookCollection : IEnumerable<Book>
{
    private readonly List<Book> _books = [];

    public void Add(Book book) => _books.Add(book);

    public IEnumerator<Book> GetEnumerator() => _books.GetEnumerator();

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
        GetEnumerator();
}
