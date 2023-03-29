using Leopotam.EcsLite;

namespace Skillitronic.LeoECSLite.EntityDescriptors.ComponentProviders
{
    public interface IComponentProvider
    {
        void Provide(EcsWorld world, int entity);
    }
}