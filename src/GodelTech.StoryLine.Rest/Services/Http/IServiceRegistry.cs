using System.Collections.Generic;

namespace GodelTech.StoryLine.Rest.Services.Http
{
    public interface IServiceRegistry
    {
        IServiceConfig Get(string serviceName);
        IReadOnlyCollection<IServiceConfig> GetAll();
    }
}