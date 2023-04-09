using Leopotam.EcsLite;
using NUnit.Framework;
using Skillitronic.LeoECSLite.EntityDescriptors.Factory;

namespace Skillitronic.LeoECSLite.EntityDescriptors.Editor.Tests
{
    public class AssignData
    {
        [Test]
        public void AssignDataSimplePasses()
        {
            string writeData = "Test";
            EcsWorld world = new ();
            IDescriptorEntityFactory descriptorEntityFactory = new DescriptorEntityFactory();

            EntityInitializer entityInitializer =  descriptorEntityFactory.Create<TestDescriptor>(world);
            int entity = entityInitializer.Entity;
            entityInitializer.InitComponent(new TestStringComponent()
            {
                Data = writeData,
            });

            string dataFromComponent = world.GetPool<TestStringComponent>().Get(entity).Data;

            Assert.AreSame(writeData, dataFromComponent);
        }
    }
}