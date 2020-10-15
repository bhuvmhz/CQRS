using Models;
using System.Collections.Generic;

namespace Kantipur.Persistence.Repositories.IRepository
{
    public interface IContainerRepository
    {
        ICollection<Container> GetContainers();
        Container GetContainer(int containerId);
        bool ContainerExists(string containerName);
        bool ContainerExists(int containerId);
        bool CreateContainer(Container container);
        bool UpdateContainer(Container container);
        bool DeleteContainer(Container container);
        bool Save();
    }
}
