using UnityEngine;

namespace NativePrefs
{
    public class AndroidPrefsProvider : IPrefsProvider
    {
        private readonly AndroidJavaClass bridgeClass = new AndroidJavaClass("com.igorgalimski.NativePrefs");
        
        public bool Has(string key)
        {
            return bridgeClass.CallStatic<bool>(key);
        }

        public void Delete(string key)
        {
            bridgeClass.CallStatic("Delete", key);
        }

        public void SaveDouble(string key, double value)
        {
            bridgeClass.CallStatic("SaveDouble", key, value);
        }

        public double GetDouble(string key)
        {
            return bridgeClass.CallStatic<double>("GetDouble", key);
        }

        public void SaveInt(string key, int value)
        {
            bridgeClass.CallStatic("SaveInt", key, value);
        }

        public int GetInt(string key)
        {
            return bridgeClass.CallStatic<int>("GetInt", key);
        }

        public void SaveBool(string key, bool value)
        {
            bridgeClass.CallStatic("SaveBool", key, value);
        }

        public bool GetBool(string key)
        {
            return bridgeClass.CallStatic<bool>("GetBool", key);
        }

        public void SaveString(string key, string value)
        {
            bridgeClass.CallStatic("SaveString", key, value);
        }

        public string GetString(string key)
        {
            return bridgeClass.CallStatic<string>("GetString", key);
        }
    }
}