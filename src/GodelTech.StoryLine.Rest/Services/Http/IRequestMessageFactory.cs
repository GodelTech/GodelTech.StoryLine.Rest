using System.Net.Http;

namespace GodelTech.StoryLine.Rest.Services.Http
{
    public interface IRequestMessageFactory
    {
        HttpRequestMessage Create(IRequest request);
    }
}