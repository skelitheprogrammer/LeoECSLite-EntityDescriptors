using Skillitronic.LeoECSLite.EntityDescriptors.ComponentProviders;

namespace Skillitronic.LeoECSLite.EntityDescriptors.Editor.Tests
{
    public class TestDescriptor : IEntityDescriptor
    {
        private static readonly IComponentProvider[] _providers =
        {
            new ComponentProvider<TestComponent>(),
            new ComponentProvider<TestStringComponent>(),
        };

        public IComponentProvider[] Components => _providers;
    }
}
