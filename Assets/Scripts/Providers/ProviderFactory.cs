using System;

namespace NativePrefs
{
    public static class ProviderFactory
    {
        public static IPrefsProvider GetProvider()
        {
            #if UNITY_EDITOR
                return new EditorPrefsProvider();
            #elif UNITY_ANDROID
                return new AndroidPrefsProvider();
            #elif UNITY_IOS
                return new IOSPrefsProvider();
            #endif
            
            throw new Exception("Can't find a provider for the current platform");
        }
    }
}