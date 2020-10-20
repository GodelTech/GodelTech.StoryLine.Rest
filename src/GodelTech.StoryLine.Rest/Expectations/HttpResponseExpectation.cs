using System;
using GodelTech.StoryLine.Contracts;
using GodelTech.StoryLine.Exceptions;
using GodelTech.StoryLine.Rest.Expectations.Services;
using GodelTech.StoryLine.Rest.Expectations.Services.Expectations;
using GodelTech.StoryLine.Rest.Services.Http;

namespace GodelTech.StoryLine.Rest.Expectations
{
    public class HttpResponseExpectation : IExpectation
    {
        public IResponseExpectation[] Expectations { get; set; } = new IResponseExpectation[0];
        public IResponseSelector Selector { get; set; }

        public void Validate(IActor actor)
        {
            if (actor == null)
                throw new ArgumentNullException(nameof(actor));

            var response = actor.Artifacts.Get<IResponse>(Selector.Maches);
            if (response == null)
                throw new ExpectationException("Matching response was not found");

            foreach (var expectation in Expectations)
            {
                expectation.Validate(response);
            }
        }
    }
}