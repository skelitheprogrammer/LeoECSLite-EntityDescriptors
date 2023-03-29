using Leopotam.EcsLite;
using Skillitronic.LeoECSLite.EntityDescriptors.ComponentProviders;

namespace Skillitronic.LeoECSLite.EntityDescriptors
{
    public class EntityDescriptorExtender<T> : IComponentProvider where T : IEntityDescriptor, new()
    {
        public void Provide(EcsWorld world, int entity)
        {
            T descriptor = new();

            foreach (IComponentProvider provider in descriptor.Components) provider.Provide(world, entity);
        }
    }
}