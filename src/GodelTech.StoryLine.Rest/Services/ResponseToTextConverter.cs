using System;
using System.Text;
using GodelTech.StoryLine.Exceptions;
using GodelTech.StoryLine.Rest.Services.Http;

namespace GodelTech.StoryLine.Rest.Services
{
    public class ResponseToTextConverter : IResponseToTextConverter
    {
        private readonly IContentTypeProvider _contentTypeProvider;

        public ResponseToTextConverter(IContentTypeProvider contentTypeProvider)
        {
            _contentTypeProvider = contentTypeProvider ?? throw new ArgumentNullException(nameof(contentTypeProvider));
        }

        public string GetText(IResponse response)
        {
            if (response == null)
                throw new ArgumentNullException(nameof(response));

            if (response.Body == null)
                return string.Empty;

            if (response.Body.Length == 0)
                return string.Empty;

            var charSetName = _contentTypeProvider.GetCharSet(response.Headers);
            var encoding = string.IsNullOrEmpty(charSetName) ?
                Config.DefaultEncoding :
                GetEncoding(charSetName);

            try
            {
                return encoding.GetString(response.Body);
            }
            catch (Exception ex)
            {
                throw new ExpectationException("Failed to convert response into text.", ex);
            }
        }

        private static Encoding GetEncoding(string charSetName)
        {
            try
            {
                return Encoding.GetEncoding(charSetName);
            }
            catch (ArgumentException ex)
            {
                throw new ExpectationException("Unknown charset specified in response: " + charSetName, ex);
            }
        }
    }
}