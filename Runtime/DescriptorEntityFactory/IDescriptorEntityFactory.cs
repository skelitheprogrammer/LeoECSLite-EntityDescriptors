using Leopotam.EcsLite;

namespace Skillitronic.LeoECSLite.EntityDescriptors.Factory
{
    public interface IDescriptorEntityFactory
    {
        public EntityInitializer Create<T>(EcsWorld world) where T: IEntityDescriptor, new();
    }
}