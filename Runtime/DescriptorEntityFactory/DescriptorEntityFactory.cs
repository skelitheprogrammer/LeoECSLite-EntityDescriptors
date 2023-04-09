using Leopotam.EcsLite;
using Skillitronic.LeoECSLite.EntityDescriptors.ComponentProviders;

namespace Skillitronic.LeoECSLite.EntityDescriptors.Factory
{
    public sealed class DescriptorEntityFactory : IDescriptorEntityFactory
    {
        public EntityInitializer Create<T>(EcsWorld world) where T : IEntityDescriptor, new()
        {
            int entity = world.NewEntity();
            
            T descriptor = new();
            IComponentProvider[] componentProviders = descriptor.Components;
            
            for (int i = 0; i < componentProviders.Length; i++)
            {
                componentProviders[i].Provide(world, entity);
            }

            return new EntityInitializer(world, entity);
        }
    }
}