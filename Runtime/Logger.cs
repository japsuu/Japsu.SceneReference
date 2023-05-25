namespace Eflatun.SceneReference
{
    internal static class Logger
    {
        //internal static void Debug(string msg) => UnityEngine.Debug.Log($"{Constants.LogPrefixBase} {msg}");
        //internal static void Warn(string msg) => UnityEngine.Debug.LogWarning($"{Constants.LogPrefixBase} {msg}");
        //internal static void Error(string msg) => UnityEngine.Debug.LogError($"{Constants.LogPrefixBase} {msg}");
        
        
        internal static void Debug(string msg)
        {
            if(Eflatun.SceneReference.Editor.SettingsManager.SceneGuidToPathMap.EnableInfoLogging.value)
                UnityEngine.Debug.Log($"{Constants.LogPrefixBase} {msg}");
        }
        
        
        internal static void Warn(string msg)
        {
            if(Eflatun.SceneReference.Editor.SettingsManager.SceneGuidToPathMap.EnableWarnLogging.value)
                UnityEngine.Debug.LogWarning($"{Constants.LogPrefixBase} {msg}");
        }
        
        
        internal static void Error(string msg)
        {
            if(Eflatun.SceneReference.Editor.SettingsManager.SceneGuidToPathMap.EnableErrorLogging.value)
                UnityEngine.Debug.LogError($"{Constants.LogPrefixBase} {msg}");
        }
    }
}
