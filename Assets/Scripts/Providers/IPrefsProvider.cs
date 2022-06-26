namespace NativePrefs
{
    public interface IPrefsProvider
    {
        public bool Has(string key);

        public void Delete(string key);

        public void SaveDouble(string key, double value);

        public double GetDouble(string key);

        public void SaveInt(string key, int value);

        public int GetInt(string key);

        public void SaveBool(string key, bool value);

        public bool GetBool(string key);

        public void SaveString(string key, string value);

        public string GetString(string key);
    }
}