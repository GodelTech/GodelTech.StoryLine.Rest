using System;
using GodelTech.StoryLine.Rest.Expectations;
using GodelTech.StoryLine.Rest.Expectations.Builders;

namespace GodelTech.StoryLine.Rest.Actions.Extensions
{
    public static class UrlPredicateExtensions
    {
        public static UrlPredicateBuilder Url(this HttpResponse response)
        {
            if (response == null)
                throw new ArgumentNullException(nameof(response));

            return new UrlPredicateBuilder(response);
        }
    }
}