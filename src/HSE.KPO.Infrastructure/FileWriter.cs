namespace HSE.KPO.Infrastructure;

public class FileWriter : IFileWriter
{
    public FileWriter()
    {

    }
    public void Write(string text, string path)
    {
        Console.WriteLine(text);
        File.WriteAllText(path, text);
    }
}

public class FileWriterProxy : IFileWriter
{
    public void Write(string text, string path)
    {
        var writer = new FileWriter();
        writer.Write(text, path);
    }
}