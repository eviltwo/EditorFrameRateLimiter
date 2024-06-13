using System.Collections.Generic;
using UnityEditor;

namespace EditorFrameRateLimiter
{
    public class FrameRateLimiterSettingsProvider : SettingsProvider
    {
        private const string SettingPath = "Preferences/EditorFrameRateLimiter";
        private static readonly string[] Keywords = { };

        [SettingsProvider]
        public static SettingsProvider CreateProvider()
        {
            return new FrameRateLimiterSettingsProvider(SettingPath, SettingsScope.User, Keywords);
        }

        public FrameRateLimiterSettingsProvider(string path, SettingsScope scopes, IEnumerable<string> keywords) : base(path, scopes, keywords)
        {
        }

        public override void OnGUI(string searchContext)
        {
            using (var check = new EditorGUI.ChangeCheckScope())
            {
                var settings = FrameRateLimiterSettings.instance;
                settings.Enable = EditorGUILayout.Toggle("Enable", settings.Enable);
                if (settings.Enable)
                {
                    settings.TargetFrameRate = EditorGUILayout.IntField("Target Frame Rate", settings.TargetFrameRate);
                }

                if (check.changed)
                {
                    settings.Save();
                }
            }
        }
    }
}
