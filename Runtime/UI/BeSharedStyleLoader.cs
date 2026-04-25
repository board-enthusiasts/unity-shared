using UnityEngine;
using UnityEngine.UIElements;

namespace BE.Unity.Shared.UI
{
    /// <summary>
    /// Applies the shared Board Enthusiasts UI Toolkit style sheet to a visual tree.
    /// </summary>
    public static class BeSharedStyleLoader
    {
        private const string SharedStyleResourceName = "BE.Shared";

        /// <summary>
        /// Adds the shared style sheet to a visual element when it is available.
        /// </summary>
        /// <param name="root">The visual tree root that should receive the shared style sheet.</param>
        /// <returns><see langword="true" /> when the style sheet was found and applied.</returns>
        public static bool ApplyTo(VisualElement root)
        {
            if (root == null)
            {
                return false;
            }

            StyleSheet styleSheet = Resources.Load<StyleSheet>(SharedStyleResourceName);
            if (styleSheet == null || root.styleSheets.Contains(styleSheet))
            {
                return styleSheet != null;
            }

            root.styleSheets.Add(styleSheet);
            return true;
        }
    }
}

