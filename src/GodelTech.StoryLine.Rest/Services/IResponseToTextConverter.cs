using GodelTech.StoryLine.Rest.Services.Http;

namespace GodelTech.StoryLine.Rest.Services
{
    public interface IResponseToTextConverter
    {
        string GetText(IResponse response);
    }
}