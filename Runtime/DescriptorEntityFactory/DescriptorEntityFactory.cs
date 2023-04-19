using Leopotam.EcsLite;
using Skillitronic.LeoECSLite.EntityDescriptors.ComponentProviders;

namespace Skillitronic.LeoECSLite.EntityDescriptors.Factory
{
    public class DescriptorEntityFactory : IDescriptorEntityFactory
    {
        public EntityInitializer Create<T>(EcsWorld world) where T : IEntityDescriptor, new()
        {
            T descriptor = new();
            return Create(descriptor, world);
        }

        public EntityInitializer Create(IEntityDescriptor descriptor, EcsWorld world)
        {
            int entity = world.NewEntity();
            
            IComponentProvider[] componentProviders = descriptor.Components;
            
            for (int i = 0; i < componentProviders.Length; i++)
            {
                componentProviders[i].Provide(world, entity);
            }

            return new EntityInitializer(world, entity);
        }
    }
}