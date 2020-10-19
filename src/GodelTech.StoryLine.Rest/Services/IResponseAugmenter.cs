using GodelTech.StoryLine.Rest.Services.Http;

namespace GodelTech.StoryLine.Rest.Services
{
    public interface IResponseAugmenter
    {
        void BeforeRequestExecuted(IRequest request);
        void AfterResponseReceived(IResponse response);
    }
}
