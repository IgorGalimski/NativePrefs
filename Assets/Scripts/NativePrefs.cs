namespace NativePrefs
{
    public static class NativePrefs
    {
        private static readonly IPrefsProvider _prefsProvider = ProviderFactory.GetProvider();

        public static bool Has(string key)
        {
            return _prefsProvider.Has(key);
        }

        public static void Delete(string key)
        {
            _prefsProvider.Delete(key);
        }

        public static void SaveDouble(string key, double value)
        {
            _prefsProvider.SaveDouble(key, value);
        }

        public static double GetDouble(string key)
        {
            return _prefsProvider.GetDouble(key);
        }

        public static void SaveInt(string key, int value)
        {
            _prefsProvider.SaveInt(key, value);
        }

        public static int GetInt(string key)
        {
            return _prefsProvider.GetInt(key);
        }

        public static void SaveBool(string key, bool value)
        {
            _prefsProvider.SaveBool(key, value);
        }

        public static bool GetBool(string key)
        {
            return _prefsProvider.GetBool(key);
        }

        public static void SaveString(string key, string value)
        {
            _prefsProvider.SaveString(key, value);
        }

        public static string GetString(string key)
        {
            return _prefsProvider.GetString(key);
        }
    }
}