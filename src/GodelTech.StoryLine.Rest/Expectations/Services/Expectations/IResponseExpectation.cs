using GodelTech.StoryLine.Rest.Services.Http;

namespace GodelTech.StoryLine.Rest.Expectations.Services.Expectations
{
    public interface IResponseExpectation
    {
        void Validate(IResponse response);
    }
}