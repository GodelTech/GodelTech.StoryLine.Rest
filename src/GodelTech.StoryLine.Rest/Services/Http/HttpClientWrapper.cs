using System.Net.Http;

namespace GodelTech.StoryLine.Rest.Services.Http
{
    public class HttpClientWrapper : HttpClient, IHttpClient
    {
        public HttpClientWrapper()
        {
        }

        public HttpClientWrapper(HttpMessageHandler handler)
            : base(handler)
        {
            
        }
    }
}