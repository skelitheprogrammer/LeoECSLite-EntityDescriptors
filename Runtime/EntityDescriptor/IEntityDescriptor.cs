using Skillitronic.LeoECSLite.EntityDescriptors.ComponentProviders;

namespace Skillitronic.LeoECSLite.EntityDescriptors
{
    public interface IEntityDescriptor
    {
        IComponentProvider[] Components { get; }
    }
}