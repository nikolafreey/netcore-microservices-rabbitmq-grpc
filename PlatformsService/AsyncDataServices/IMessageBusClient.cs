using PlatformsService.Dtos;

namespace PlatformsService.AsyncDataServices
{
    public interface IMessageBusClient
    {
        void PublishNewPlatform(PlatformPublishDto platformPublishDto);
    }
}