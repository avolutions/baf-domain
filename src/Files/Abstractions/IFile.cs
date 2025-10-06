namespace Avolutions.Baf.Domain.Files.Abstractions;

public interface IFile
{
    public string FileName { get; set; }
    public string FileExtension { get; set; }
    public string ContentType { get; set; }
    public long Size { get; set; }
}