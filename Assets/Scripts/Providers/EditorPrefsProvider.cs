using UnityEditor;

#if  UNITY_EDITOR

namespace NativePrefs
{
    public class EditorPrefsProvider : IPrefsProvider
    {
        public bool Has(string key)
        {
            return EditorPrefs.HasKey(key);
        }

        public void Delete(string key)
        {
            EditorPrefs.DeleteKey(key);
        }

        public void SaveDouble(string key, double value)
        {
            SaveString(key, value.ToString());
        }

        public double GetDouble(string key)
        {
            var str = GetString(key);
            double.TryParse(str, out var value);

            return value;
        }

        public void SaveInt(string key, int value)
        {
            EditorPrefs.SetInt(key, value);
        }

        public int GetInt(string key)
        {
            return EditorPrefs.GetInt(key);
        }

        public void SaveBool(string key, bool value)
        {
            EditorPrefs.SetBool(key, value);
        }

        public bool GetBool(string key)
        {
            return EditorPrefs.GetBool(key);
        }

        public void SaveString(string key, string value)
        {
            EditorPrefs.SetString(key, value);
        }

        public string GetString(string key)
        {
            return EditorPrefs.GetString(key);
        }
    }
}

#endif