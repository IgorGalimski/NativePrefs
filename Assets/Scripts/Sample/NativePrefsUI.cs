using UnityEngine;
using UnityEngine.UI;

namespace NativePrefs.Sample
{
    public class NativePrefsUI : MonoBehaviour
    {
        private const string DOUBLE_SAVE_KEY = "double";
        
        [SerializeField] 
        private Text _loadDoubleText;
        
        [SerializeField] 
        private Button _loadDoubleButton;
        
        [SerializeField] 
        private Text _saveDoubleText;

        [SerializeField] 
        private Button _saveDoubleButton;

        public void Awake()
        {
            _loadDoubleButton.onClick.AddListener(OnLoadDoubleClick);
            _saveDoubleButton.onClick.AddListener(OnSaveDoubleClick);
        }

        public void OnDestroy()
        {
            _loadDoubleButton.onClick.RemoveAllListeners();
            _saveDoubleButton.onClick.RemoveAllListeners();
        }

        private void OnLoadDoubleClick()
        {
            _loadDoubleText.text = NativePrefs.GetDouble(DOUBLE_SAVE_KEY).ToString();
        }
        
        private void OnSaveDoubleClick()
        {
            if (double.TryParse(_saveDoubleText.text, out var value))
            {
                NativePrefs.SaveDouble(DOUBLE_SAVE_KEY, value);
            }
        }
    }
}