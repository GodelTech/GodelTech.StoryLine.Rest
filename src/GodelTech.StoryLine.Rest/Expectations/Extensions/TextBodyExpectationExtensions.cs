using System;
using GodelTech.StoryLine.Rest.Expectations.Builders;

namespace GodelTech.StoryLine.Rest.Expectations.Extensions
{
    public static class TextBodyExpectationExtensions
    {
        public static TextBodyExpectationBuilder TextBody(this HttpResponse builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            return new TextBodyExpectationBuilder(builder);
        }
    }
}