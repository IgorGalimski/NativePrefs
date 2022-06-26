#if UNITY_IOS || UNITY_EDITOR

using System.Runtime.InteropServices;

namespace NativePrefs
{
    public class IOSPrefsProvider : IPrefsProvider
    {
        [DllImport("__Internal")]
        private static extern bool HasInternal(string key);
        
        [DllImport("__Internal")]
        private static extern void DeleteInternal(string key);
        
        [DllImport("__Internal")]
        private static extern void SaveDoubleInternal(string key, double value);
        
        [DllImport("__Internal")]
        private static extern double GetDoubleInternal(string key);

        [DllImport("__Internal")]
        private static extern void SaveIntInternal(string key, int value);
        
        [DllImport("__Internal")]
        private static extern int GetIntInternal(string key);
        
        [DllImport("__Internal")]
        private static extern void SaveBoolInternal(string key, bool value);

        [DllImport("__Internal")]
        private static extern bool GetBoolInternal(string key);

        [DllImport("__Internal")]
        private static extern string SaveStringInternal(string key, string value);
        
        [DllImport("__Internal")]
        private static extern string GetStringInternal(string key);
        
        public bool Has(string key)
        {
            return HasInternal(key);
        }

        public void Delete(string key)
        {
            DeleteInternal(key);
        }

        public void SaveDouble(string key, double value)
        {
            SaveDoubleInternal(key, value);
        }

        public double GetDouble(string key)
        {
            return GetDoubleInternal(key);
        }

        public void SaveInt(string key, int value)
        {
            SaveIntInternal(key, value);
        }

        public int GetInt(string key)
        {
            return GetIntInternal(key);
        }

        public void SaveBool(string key, bool value)
        {
            SaveBoolInternal(key, value);
        }

        public bool GetBool(string key)
        {
            return GetBoolInternal(key);
        }

        public void SaveString(string key, string value)
        {
            SaveStringInternal(key, value);
        }

        public string GetString(string key)
        {
            return GetStringInternal(key);
        }
    }
}

#endif