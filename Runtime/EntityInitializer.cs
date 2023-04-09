using Leopotam.EcsLite;

namespace Skillitronic.LeoECSLite.EntityDescriptors
{
    public readonly ref struct EntityInitializer
    {
        public readonly EcsWorld World;
        public readonly int Entity;

        public EntityInitializer(EcsWorld world, int entity)
        {
            World = world;
            Entity = entity;
        }

        public void InitComponent<T>(in T component) where T : struct
        {
            World.GetPool<T>().Get(Entity) = component;
        }
    }
}
