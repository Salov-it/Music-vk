

namespace MyRecommendationsService.Application.Interface
{
    public interface IVkApiService
    {
        Task<List<VkNet.Model.Attachments.Audio>> GetAudiosAsync(uint count, long? UserId);
    }
}
