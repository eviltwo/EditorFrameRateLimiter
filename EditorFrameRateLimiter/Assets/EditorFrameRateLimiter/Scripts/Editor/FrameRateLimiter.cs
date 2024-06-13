using UnityEditor;
using UnityEngine;

namespace EditorFrameRateLimiter
{
    public static class FrameRateLimiter
    {
        [InitializeOnLoadMethod]
        private static void Execute()
        {
            if (FrameRateLimiterSettings.instance.Enable)
            {
                var frameRate = FrameRateLimiterSettings.instance.TargetFrameRate;
                Application.targetFrameRate = frameRate;
                Debug.Log($"EditorFrameRateLimiter: Target frame rate is set to {frameRate}");
            }
            else
            {
                // Set default value
                // https://docs.unity3d.com/ScriptReference/Application-targetFrameRate.html
                Application.targetFrameRate = -1;
            }
        }
    }
}
