using System;
using UnityEngine;

namespace NativePrefs
{
    public static class ProviderFactory
    {
        public static IPrefsProvider GetProvider()
        {
            if (Application.isEditor)
            {
                return new EditorPrefsProvider();
            }
            
            switch (Application.platform)
            {
                case RuntimePlatform.Android:
                {
                    throw new NotImplementedException();
                }

                case RuntimePlatform.IPhonePlayer:
                {
                    return new IOSPrefsProvider();
                }
            }

            throw new Exception("Can't find a provider for the current platform");
        }
    }
}