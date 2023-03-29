using Leopotam.EcsLite;
using Skillitronic.LeoECSLite.EntityDescriptors.ComponentProviders;

namespace Skillitronic.LeoECSLite.EntityDescriptors.Factory
{
    public sealed class DescriptorEntityFactory : IDescriptorEntityFactory
    {
        public int Create(IEntityDescriptor descriptor, EcsWorld world)
        {
            int entity = world.NewEntity();

            IComponentProvider[] componentProviders = descriptor.Components;

            for (int i = 0; i < componentProviders.Length; i++) componentProviders[i].Provide(world, entity);

            return entity;
        }
    }
}