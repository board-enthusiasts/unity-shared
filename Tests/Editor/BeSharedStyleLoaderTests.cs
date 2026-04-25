using BE.Unity.Shared.UI;
using NUnit.Framework;
using UnityEngine.UIElements;

namespace BE.Unity.Shared.Tests
{
    public sealed class BeSharedStyleLoaderTests
    {
        [Test]
        public void ApplyToReturnsFalseWhenRootIsMissing()
        {
            Assert.False(BeSharedStyleLoader.ApplyTo(null));
        }

        [Test]
        public void ApplyToCanBeCalledRepeatedly()
        {
            VisualElement root = new();

            bool firstResult = BeSharedStyleLoader.ApplyTo(root);
            bool secondResult = BeSharedStyleLoader.ApplyTo(root);

            Assert.AreEqual(firstResult, secondResult);
        }
    }
}

