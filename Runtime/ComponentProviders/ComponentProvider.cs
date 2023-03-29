using Leopotam.EcsLite;

namespace Skillitronic.LeoECSLite.EntityDescriptors.ComponentProviders
{
    public sealed class ComponentProvider<T> : IComponentProvider where T : struct
    {
        public void Provide(EcsWorld world, int entity)
        {
            world.GetPool<T>().Add(entity);
        }
    }
}