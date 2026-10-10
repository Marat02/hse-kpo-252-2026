namespace HSE.KPO.Infrastructure;

public interface IFileWriter
{
    void Write(string text, string path);
}