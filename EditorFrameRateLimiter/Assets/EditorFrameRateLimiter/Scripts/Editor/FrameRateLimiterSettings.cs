using UnityEditor;

namespace EditorFrameRateLimiter
{
    [FilePath("EditorFrameRateLimiterSettings.asset", FilePathAttribute.Location.PreferencesFolder)]
    public class FrameRateLimiterSettings : ScriptableSingleton<FrameRateLimiterSettings>
    {
        public bool Enable = true;
        public int TargetFrameRate = 60;

        public void Save()
        {
            Save(true);
        }
    }
}
