using MonPrimeur.Models;

namespace MonPrimeur.Services;

public class ImageService
{
    private readonly PathService pathService;

    public ImageService(PathService pathService)
    {
        this.pathService = pathService;
    }

    public async Task<Image> UploadAsync(Image image)
    {
        var uploadsPath = pathService.GetUploadsPath();

        var imageFile = image.File;
        var imageFileName = GetRandomFileName(imageFile.FileName);
        var imageUploadPath = Path.Combine(uploadsPath, imageFileName);

        using (var fs = new FileStream(imageUploadPath, FileMode.Create))
        {
            await imageFile.CopyToAsync(fs);
        }
        image.Name = imageFile.FileName;
        image.Path = pathService.GetUploadsPath(imageFileName, withWebRootPath: false);

        return image;
    }

    private string GetRandomFileName(string FileName)
    {
        return Guid.NewGuid() + Path.GetExtension(FileName);
    }

}
