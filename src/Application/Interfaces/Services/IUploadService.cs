using CustomerManager.Application.Requests;

namespace CustomerManager.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}