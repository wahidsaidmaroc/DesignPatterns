IImage image = new ImageProxy("vacances.jpg");
Console.WriteLine("Le proxy est créé, l'image n'est pas encore chargée.");
image.Display();
image.Display();

public interface IImage
{
    void Display();
}

public sealed class RealImage(string fileName) : IImage
{
    public void Display() => Console.WriteLine($"Affichage de {fileName}.");
}

public sealed class ImageProxy(string fileName) : IImage
{
    private RealImage? _image;

    public void Display()
    {
        _image ??= LoadImage();
        _image.Display();
    }

    private RealImage LoadImage()
    {
        Console.WriteLine($"Chargement de {fileName}...");
        return new RealImage(fileName);
    }
}
