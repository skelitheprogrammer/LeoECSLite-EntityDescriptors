using UnityEditor;

namespace Skillitronic.LeoECSLite.Common.Editor
{
    internal sealed partial class TemplateGenerator
    {
        private const string TEMPLATE_DESCRIPTOR = "TemplateDescriptor.cs.txt";


        [MenuItem("Assets/Create/LeoECS Lite/Descriptors/Create Entity Descriptor", false, -199)]
        private static void CreateEntityDescriptorTemplate()
        {
            CreateAndRenameAsset($"{GetAssetPath()}/EntityDescriptor.cs", GetIcon(),
                (name) => CreateTemplateInternal(GetTemplateContent(TEMPLATE_DESCRIPTOR), name));
        }
    }
}