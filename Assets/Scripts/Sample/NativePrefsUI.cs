using UnityEngine;
using UnityEngine.UI;

namespace NativePrefs.Sample
{
    public class NativePrefsUI : MonoBehaviour
    {
        private const string DOUBLE_SAVE_KEY = "double";
        private const string INT_SAVE_KEY = "int";
        private const string BOOL_SAVE_KEY = "bool";
        private const string STRING_SAVE_KEY = "string";
        
        //DOUBLE
        [SerializeField] 
        private Text _loadDoubleText;
        
        [SerializeField] 
        private Button _loadDoubleButton;
        
        [SerializeField] 
        private Text _saveDoubleText;

        [SerializeField] 
        private Button _saveDoubleButton;
        
        //INT
        [SerializeField] 
        private Text _loadIntText;
        
        [SerializeField] 
        private Button _loadIntButton;
        
        [SerializeField] 
        private Text _saveIntText;

        [SerializeField] 
        private Button _saveIntButton;
        
        //BOOL
        [SerializeField]
        private Toggle _loadBoolToogle;
        
        [SerializeField] 
        private Button _loadBoolButton;
        
        [SerializeField] 
        private Toggle _saveBoolToogle;

        [SerializeField] 
        private Button _saveBoolButton;
        
        //STRING
        [SerializeField] 
        private Text _loadStringText;
        
        [SerializeField] 
        private Button _loadStringButton;
        
        [SerializeField] 
        private Text _saveStringText;

        [SerializeField] 
        private Button _saveStringButton;

        public void Awake()
        {
            _loadDoubleButton.onClick.AddListener(OnLoadDoubleClick);
            _saveDoubleButton.onClick.AddListener(OnSaveDoubleClick);
            
            _loadIntButton.onClick.AddListener(OnLoadIntClick);
            _saveIntButton.onClick.AddListener(OnSaveIntClick);
            
            _loadBoolButton.onClick.AddListener(OnLoadBoolClick);
            _saveBoolButton.onClick.AddListener(OnSaveBoolClick);
            
            _loadStringButton.onClick.AddListener(OnLoadStringClick);
            _saveStringButton.onClick.AddListener(OnSaveStringClick);
        }

        public void OnDestroy()
        {
            _loadDoubleButton.onClick.RemoveAllListeners();
            _saveDoubleButton.onClick.RemoveAllListeners();
            
            _loadIntButton.onClick.RemoveAllListeners();
            _saveIntButton.onClick.RemoveAllListeners();
            
            _loadBoolButton.onClick.RemoveAllListeners();
            _saveBoolButton.onClick.RemoveAllListeners();
            
            _loadStringButton.onClick.RemoveAllListeners();
            _saveStringButton.onClick.RemoveAllListeners();
        }
        
        //DOUBLE
        private void OnLoadDoubleClick()
        {
            _loadDoubleText.text = NativePrefs.GetDouble(DOUBLE_SAVE_KEY).ToString();
        }

        private void OnSaveDoubleClick()
        {
            var valueString = _saveDoubleText.text;
            
            if (double.TryParse(valueString, out var value))
            {
                NativePrefs.SaveDouble(DOUBLE_SAVE_KEY, value);
            }
            else
            {
                Debug.LogError($"Can't parse double: {valueString}");
            }
        }
        
        //INT
        private void OnLoadIntClick()
        {
            _loadIntText.text = NativePrefs.GetInt(INT_SAVE_KEY).ToString();
        }
        
        private void OnSaveIntClick()
        {
            var valueString = _saveIntText.text;
            
            if (int.TryParse(valueString, out var value))
            {
                NativePrefs.SaveInt(INT_SAVE_KEY, value);
            }
            else
            {
                Debug.LogError($"Can't parse int: {valueString}");
            }
        }
        
        //BOOL
        private void OnLoadBoolClick()
        {
            _loadBoolToogle.isOn = NativePrefs.GetBool(BOOL_SAVE_KEY);
        }

        private void OnSaveBoolClick()
        {
            NativePrefs.SaveBool(BOOL_SAVE_KEY, _saveBoolToogle.isOn);
        }
        
        //STRING
        private void OnLoadStringClick()
        {
            _loadStringText.text = NativePrefs.GetString(STRING_SAVE_KEY);
        }

        private void OnSaveStringClick()
        {
            var valueString = _saveStringText.text;
            
            if (!string.IsNullOrEmpty(valueString))
            {
                NativePrefs.SaveString(STRING_SAVE_KEY, valueString);
            }
            else
            {
                Debug.LogError("Can't save null string");
            }
        }
    }
}