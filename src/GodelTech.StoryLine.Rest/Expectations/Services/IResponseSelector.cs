using GodelTech.StoryLine.Rest.Services.Http;

namespace GodelTech.StoryLine.Rest.Expectations.Services
{
    public interface IResponseSelector
    {
        bool Maches(IResponse response);
    }
}