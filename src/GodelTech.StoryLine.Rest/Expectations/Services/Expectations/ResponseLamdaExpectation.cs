using System;
using GodelTech.StoryLine.Exceptions;
using GodelTech.StoryLine.Rest.Services.Http;

namespace GodelTech.StoryLine.Rest.Expectations.Services.Expectations
{
    public class ResponseLamdaExpectation : IResponseExpectation
    {
        private readonly Func<IResponse, bool> _predicate;
        private readonly Func<IResponse, string> _message;

        public ResponseLamdaExpectation(Func<IResponse, bool> predicate, Func<IResponse, string> message)
        {
            _predicate = predicate ?? throw new ArgumentNullException(nameof(predicate));
            _message = message ?? throw new ArgumentNullException(nameof(message));
        }

        public void Validate(IResponse response)
        {
            if (response == null)
                throw new ArgumentNullException(nameof(response));

            if (!_predicate(response))
                throw new ExpectationException(_message(response));
        }
    }
}