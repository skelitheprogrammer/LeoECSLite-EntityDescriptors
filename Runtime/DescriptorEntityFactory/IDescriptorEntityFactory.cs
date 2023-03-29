using Leopotam.EcsLite;

namespace Skillitronic.LeoECSLite.EntityDescriptors.Factory
{
    public interface IDescriptorEntityFactory
    {
        public int Create(IEntityDescriptor descriptor, EcsWorld world);
    }
}