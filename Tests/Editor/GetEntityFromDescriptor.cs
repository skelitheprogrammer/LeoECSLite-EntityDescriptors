using Leopotam.EcsLite;
using NUnit.Framework;
using Skillitronic.LeoECSLite.EntityDescriptors.Factory;

namespace Skillitronic.LeoECSLite.EntityDescriptors.Editor.Tests
{
    public class GetEntityFromDescriptor
    {
        [Test]
        public void GetEntityFromDescriptorSimplePasses()
        {
            EcsWorld world = new ();
            IDescriptorEntityFactory descriptorEntityFactory = new DescriptorEntityFactory();

            EntityInitializer entityInitializer =  descriptorEntityFactory.Create<TestDescriptor>(world);
            int entity = entityInitializer.Entity;
            bool hasEntity = world.GetPool<TestComponent>().Has(entity);
            
            Assert.True(hasEntity);
        }
    }
}
