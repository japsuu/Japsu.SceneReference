namespace Eflatun.SceneReference.Editor
{
    internal static class EditorLogger
    {
        //internal static void Debug(string msg) => UnityEngine.Debug.Log($"{Constants.LogPrefixBase} {msg}");
        //internal static void Warn(string msg) => UnityEngine.Debug.LogWarning($"{Constants.LogPrefixBase} {msg}");
        //internal static void Error(string msg) => UnityEngine.Debug.LogError($"{Constants.LogPrefixBase} {msg}");
        
        
        internal static void Debug(string msg)
        {
            if(SettingsManager.SceneGuidToPathMap.EnableInfoLogging.value)
                UnityEngine.Debug.Log($"{Constants.LogPrefixBase} {msg}");
        }
        
        
        internal static void Warn(string msg)
        {
            if(SettingsManager.SceneGuidToPathMap.EnableWarnLogging.value)
                UnityEngine.Debug.LogWarning($"{Constants.LogPrefixBase} {msg}");
        }
        
        
        internal static void Error(string msg)
        {
            if(SettingsManager.SceneGuidToPathMap.EnableErrorLogging.value)
                UnityEngine.Debug.LogError($"{Constants.LogPrefixBase} {msg}");
        }
    }
}
