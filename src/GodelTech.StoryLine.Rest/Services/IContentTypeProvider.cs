using System.Collections.Generic;

namespace GodelTech.StoryLine.Rest.Services
{
    public interface IContentTypeProvider
    {
        string GetContentType(IEnumerable<KeyValuePair<string, string[]>> headers);
        string GetCharSet(IEnumerable<KeyValuePair<string, string[]>> headers);
    }
}